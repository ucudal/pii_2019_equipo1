using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Linked.Areas.Identity.Data;
using System.Security.Principal;
using Linked.Models;

  /// <summary>
  /// Los controladores son los encargados de traducir las entradas de los usuarios en acciones a ser llevadas a cabo por el modelo.
  /// Es decir, maneja las interacciones con los usuarios y provee un mecanismo por el cual se produce un cambio en el estado del modelo.
  /// Uno de los propósitos en MVC es separar el modelo de las vistas a modo de que cambios en las vistas no se tengan que verse reflejadas
  /// en el modelo y viceversa, en otras palabras, modularizar la aplicación.
  ///
  /// Esta clase hereda de PageModel de modo que extiende sus propiedades y comportamiento sin necesidad de volver a implementarlo.
  /// Por lo tanto, la clase AvailableProjects tiene una clasificación jerárquica por debajo de PageModel.
  ///
  /// Su propósito es brindarle la posibilidad a un técnico de mostrar interés por un proyecto.
  ///
  /// Colaboradores: Project, Technician, Requirement, Specialty, Interest y Linked.Areas.Identity.Data.IdentityContext  
  ///
  /// Expert / Creator - Sobre esta clase sobrecae la responsabilidad de crear los objetos de Interest ya que conoce toda la información 
  /// necesaria para hacerlo y logrando de este modo una mayor cohesión.
  ///
  /// DRY - Esta clase es la única capaz de crear relaciones entre los técnicos y los proyectos a través de los nexos Interest en toda 
  /// la aplicación, por lo tanto, respeta el principio de DRY
  ///
  /// Principios:
  /// SRP- La única responsabilidad de esta clase es crear instancias de Interest.
  ///
  /// ISP: AvailableProjects implementa todos los tipos (IAsyncPageFilter, IFilterMetadata, IPageFilter) expresados explícitamente en las 
  /// interfaces implementadas por el supertipo PageModel. Por esta razón AvailableProjects no se ve forzada a implementar tipos que no 
  /// utiliza. Las interfaces implementadas aseguran el funcionamiento del controlador.
  ///
  /// OCP - PageModel está abierta a la extensión y cerrada a la modificación porque pudimos extenderla con AvailableProjects sin 
  /// necesidad de modificarla.
  ///   
  /// LSP -  PageModel se puede sustituir por su subtipo AvailableProjects, ya que extiende el comportamiento de PageModel, respetando los
  /// tipos en PageModel, sin modificar su comportamiento. 
  /// </summary>

namespace Linked.Pages.AvailableProjects
{
    public class IndexModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public IList<Requirement> Requirements { get;set; }
        public Technician currentUser { get; set; }
        public Project Project { get; set; }
        public Specialty Specialty { get; set; }

        public IndexModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            try {
                string userId = User.Identity.Name; // Gets the current logged email
                currentUser = _context.Technician.FirstOrDefault(x => x.Email == userId); // Gets from context the Client with that email
            } catch (Exception e) {
                Console.WriteLine("Something went wrong getting the logged user: " + e);
                return RedirectToPage("https://localhost:5001/");
            }

            if (currentUser == null){return RedirectToPage("https://localhost:5001/");}

            Specialty = currentUser.Specialty;

            Requirements = await _context.Requirement
                .Where(r => r.Specialty == currentUser.Specialty).Include(r => r.Project).ToListAsync();
            
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            string ProjectID = Request.Form["ProjectID"];
            string userId = User.Identity.Name; // Gets the current logged email
            currentUser = _context.Technician.FirstOrDefault(x => x.Email == userId); // Gets from context the Client with that email

            Interest newInterest = new Interest();
            newInterest.ProjectID = ProjectID;
            newInterest.TechnicianID = currentUser.TechnicianID;
            
            try{
                _context.Interest.Add(newInterest);
                await _context.SaveChangesAsync();
            } catch (Exception e) {
                Console.WriteLine("The user is already interested in this project: "+e);
            }

            return RedirectToPage("./MyProjects");
        }
    }
}