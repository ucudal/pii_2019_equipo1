using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

  /// <summary>
  /// Los controladores son los encargados de traducir las entradas de los usuarios en acciones a ser llevadas a cabo por el modelo.
  /// Es decir, maneja las interacciones con los usuarios y provee un mecanismo por el cual se produce un cambio en el estado del modelo.
  /// Uno de los propósitos en MVC es separar el modelo de las vistas a modo de que cambios en las vistas no se tengan que verse reflejadas
  /// en el modelo y viceversa, en otras palabras, modularizar la aplicación.
  ///
  /// Esta clase hereda de PageModel de modo que extiende sus propiedades y comportamiento sin necesidad de volver a implementarlo.
  /// Por lo tanto, la clase EditModel tiene una clasificación jerárquica por debajo de PageModel.
  ///
  /// Su propósito es pasar a una Página/View la información con respecto a una instancia de Client para esta poder ser editada por el
  /// usuario. Esta información la recupera de IdentityContext
  ///
  /// Colaboradores: Client y Linked.Areas.Identity.Data.IdentityContext  
  ///
  /// Patrones:
  ///
  /// Expert - Esta clase se le asigna la responsabilidad de editar las instancias de Client, ya que conoce al formulario de View de 
  /// edición y tiene acceso a la base de de datos.
  ///
  ///
  /// Principios:
  /// Don’t repeat yourself (DRY) - En la aplicación se respeta el principio DRY ya que los comportamientos específicos se encuentran
  /// implementados en una sola clase, en este caso, la edición de instancias de Client.
  ///
  /// SRP- La única razón de cambio válida en este controlador es cambios en el vínculo entre el método para modificar la información de
  /// la instancia de Client a editar, y surepresentaciòn gráfica.
  ///
  /// ISP: Edit implementa todos los tipos (IAsyncPageFilter, IFilterMetadata, IPageFilter) expresados explícitamente en las interfaces
  /// implementadas por el supertipo PageModel. Por esta razón Edit no se ve forzada a implementar tipos que no utiliza, ya que las
  /// interfaces implementadas aseguran el funcionamiento del controlador.
  ///
  /// OCP - PageModel está abierta a la extensión y cerrada a la modificación porque pudimos extenderla con Edit sin necesidad de 
  /// modificarla.
  /// 
  /// LSP -  PageModel se puede sustituir por su subtipo Edit, ya que Edit extiende el comportamiento de PageModel, respetando los
  /// tipos en PageModel.
  /// </summary>
  
namespace Linked.Pages.Clients
{
    public class EditModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public EditModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Client Client { get; set; }

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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(Client.ClientID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClientExists(string id)
        {
            return _context.Client.Any(e => e.ClientID == id);
        }
    }
}