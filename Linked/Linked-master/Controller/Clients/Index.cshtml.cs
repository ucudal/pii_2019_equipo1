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
  /// Por lo tanto, la clase IndexModel tiene una clasificación jerárquica por debajo de PageModel.
  ///
  /// Su propósito es pasar a una Página/View la información con respecto a todas las instancias de Client presentes en la base de datos 
  /// para estas poder ser visualizadas por el usuario.
  /// Esta información la recupera de IdentityContext
  ///
  /// Colaboradores: Client y Linked.Areas.Identity.Data.IdentityContext  
  ///
  /// Principios:
  /// SRP- La única razón de cambio válida en este controlador es cambios en el vínculo entre la información recuperada de IdentityContext 
  /// y su representación gráfica en View.
  ///
  /// ISP: Index implementa todos los tipos (IAsyncPageFilter, IFilterMetadata, IPageFilter) expresados explícitamente en las interfaces
  /// implementadas por el supertipo PageModel. Por esta razón Index no se ve forzada a implementar tipos que no utiliza. Las
  /// interfaces implementadas aseguran el funcionamiento del controlador.
  ///
  /// OCP - PageModel está abierta a la extensión y cerrada a la modificación porque pudimos extenderla con Index sin necesidad de 
  /// modificarla.
  ///   
  /// LSP -  PageModel se puede sustituir por su subtipo Index, ya que extiende el comportamiento de PageModel, respetando los
  /// tipos en PageModel, sin modificar su comportamiento.
  /// </summary>
namespace Linked.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public IndexModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; }

        public async Task OnGetAsync()
        {
            Client = await _context.Client.ToListAsync();
        }
    }
}