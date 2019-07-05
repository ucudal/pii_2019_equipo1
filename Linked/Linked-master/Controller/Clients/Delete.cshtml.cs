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
   /// Su propósito es brindar por medio de View acceso al método para eliminar una instancia de Client en IdentityContext.
   ///
   /// Colaboradores: Client y Linked.Areas.Identity.Data.IdentityContext   
   ///
   /// Principios:
   /// Don’t repeat yourself (DRY) - En la aplicación se respeta el principio DRY ya que los comportamientos específicos se encuentran
   /// implementados en una sola clase, en este caso, la eliminación de entidades de clientes.
   ///
   /// SRP- La única razón de cambio válida en este controlador es cambios en el vínculo entre el método para eliminar una instancia de
   /// Client en IdentityContext, y la Página/View, que da acceso al usuario a este método.
   /// </summary>

namespace Linked.Pages.Clients
{
    public class DeleteModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public DeleteModel(Linked.Areas.Identity.Data.IdentityContext context)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Client.FindAsync(id);

            if (Client != null)
            {
                _context.Client.Remove(Client);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}