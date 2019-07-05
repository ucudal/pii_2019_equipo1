using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Linked.Areas.Identity.Data;
using Linked.Models;
using Microsoft.EntityFrameworkCore;

  /// <summary>
  /// Los controladores son los encargados de traducir las entradas de los usuarios en acciones a ser llevadas a cabo por el modelo.
  /// Es decir, maneja las interacciones con los usuarios y provee un mecanismo por el cual se produce un cambio en el estado del modelo.
  /// Uno de los propósitos en MVC es separar el modelo de las vistas a modo de que cambios en las vistas no se tengan que verse reflejadas
  /// en el modelo y viceversa, en otras palabras, modularizar la aplicación.
  ///
  /// Esta clase hereda de PageModel de modo que extiende sus propiedades y comportamiento sin necesidad de volver a implementarlo.
  /// Por lo tanto, la clase AddRequirement tiene una clasificación jerárquica por debajo de PageModel.
  ///
  /// Su propósito es brindarle la posibilidad a un cliente de crear un Requirement para su proyecto y persistir al objeto en la base de 
  /// datos.
  ///
  /// Colaboradores: Requirement, Project, Specialties, Levels y Linked.Areas.Identity.Data.IdentityContext  
  ///
  /// DRY - Esta clase es la única capaz de crear Requirements, en otras palabras, no se repite este comportamiento en ninguna otra parte 
  /// de la aplicaión.
  ///
  /// Principios:
  /// SRP- La única razón de cambio válida en este controlador es cambios en el vínculo entre el formulario para crear una instancia de 
  /// Requirement en View, y su persistencia en IdentityContext.
  ///
  /// ISP: AddRequirement implementa todos los tipos (IAsyncPageFilter, IFilterMetadata, IPageFilter) expresados explícitamente en las 
  /// interfaces implementadas por el supertipo PageModel. Por esta razón AddRequirement no se ve forzada a implementar tipos que no 
  /// utiliza. Las interfaces implementadas aseguran el funcionamiento del controlador.
  ///
  /// OCP - PageModel está abierta a la extensión y cerrada a la modificación porque pudimos extenderla con AddRequirement sin necesidad 
  /// de modificarla.
  ///   
  /// LSP -  PageModel se puede sustituir por su subtipo AddRequirement, ya que extiende el comportamiento de PageModel, respetando los
  /// tipos en PageModel, sin modificar su comportamiento. User.IsInRole(IdentityData.NonAdminRoleNames[0]) aca se puede ver un ejemplo 
  /// donde ya sea un Client o un ApplicationUser el tipo del usuario logeado, la expresión funciona igual.
/// </summary>

namespace Linked.Pages.AddRequirement{
    public class CreateModel : PageModel{
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public CreateModel(Linked.Areas.Identity.Data.IdentityContext context){
            _context = context;
        }

        [BindProperty]
        public Requirement Requirement { get; set; }
        public Project Project { get; set; }

        public List<SelectListItem> Specialties{ get; set; }
        public List<SelectListItem> Levels{ get; set; }

        public async Task<IActionResult> OnGetAsync(string id){
            if (id == null){
                return NotFound();
            }

            Project = await _context.Project.FirstOrDefaultAsync(m => m.ProjectID == id);

            if (Project == null)
            {
                return NotFound();
            }

            Specialties = Enum.GetValues(typeof(Specialty)).Cast<Specialty>().ToList()
            .Select(spy => new SelectListItem{ Value = spy.ToString(), Text = spy.ToString() }).ToList();

            Levels = Enum.GetValues(typeof(Level)).Cast<Level>().ToList()
            .Select(lvl => new SelectListItem{ Value = lvl.ToString(), Text = lvl.ToString() }).ToList();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id){
            Requirement.ProjectID = id;

            _context.Requirement.Add(Requirement);
            await _context.SaveChangesAsync();

            if(User.IsInRole(IdentityData.NonAdminRoleNames[0])){
                return RedirectToPage("../ClientLayout/MyProjects");
            }

            return RedirectToPage("./Index");
        }
    }
}