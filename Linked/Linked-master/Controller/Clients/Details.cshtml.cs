using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

   /// <summary>
   /// Los controladores son los encargados de traducir las entradas de los usuarios en acciones a ser llevadas a cabo por el modelo. 
   /// Es decir, maneja las interacciones con los usuarios y provee un mecanismo por el cual se produce un cambio en el estado del modelo. 
   /// Uno de los propósitos en MVC es separar el modelo de las vistas a modo de que cambios en las vistas no se tengan que verse reflejadas
   /// en el modelo y viceversa, en otras palabras, modularizar la aplicación.
   ///
   /// Esta clase hereda de PageModel de modo que extiende sus propiedades y comportamiento sin necesidad de volver a implementarlo. 
   /// Por lo tanto, la clase DeleteModel tiene una clasificación jerárquica por debajo de PageModel.
   ///
   /// Su propósito es pasar a una Página/View la información con respecto a una instancia de Client. 
   /// Esta información la recupera de IdentityContext
   ///
   /// Colaboradores: Client, Project y Linked.Areas.Identity.Data.IdentityContext   
   ///
   /// Principios:
   ///
   /// SRP- La única razón de cambio válida en este controlador es cambios en el vínculo entre el método para recuperar la información de
   /// la instancia de Client, y surepresentaciòn gráfica.
   /// 
   /// ISP: Details implementa todos los tipos (IAsyncPageFilter, IFilterMetadata, IPageFilter) expresados explícitamente en las interfaces
   /// implementadas por el supertipo PageModel. Por esta razón Details no se ve forzada a implementar tipos que no utiliza, ya que las
   /// interfaces implementadas aseguran el funcionamiento del controlador.
   /// 
   /// OCP - PageModel está abierta a la extensión y cerrada a la modificación porque pudimos extenderla con Details sin necesidad de
   /// modificarla.
   /// LSP -  PageModel se puede sustituir por su subtipo Details, ya que Details extiende el comportamiento de PageModel, respetando los
   /// tipos en PageModel. 
   /// </summary>

namespace Linked.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public DetailsModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public Client Client { get; set; }
        public IEnumerable<Project> Projects {get;set;}

        public IEnumerable<Project> LoadProjects(){
            return _context.Project.Where(p=>p.ClientID == Client.ClientID).AsEnumerable();
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Client.FirstOrDefaultAsync(m => m.ClientID == id);

            if (Client == null)
            {
                return NotFound();
            }

            Projects = LoadProjects();

            return Page();
        }
    }
}