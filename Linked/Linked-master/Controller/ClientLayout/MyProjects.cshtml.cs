using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
   /// Su propósito es recuperar de IdentityContext los proyectos asociados a un cliente, y pasar esta información a View para que la
   /// represente.
   ///
   /// Colaboradores: Project, Client, User.Identity y Linked.Areas.Identity.Data.IdentityContext   
   ///
   /// Patrones: 
   ///
   /// Singleton - User.Identity es un objeto de alcance global dentro de la aplicación y el mismo es instanciado solo una vez cuando el
   /// usuario entra a la aplicación. Desde esta clase se accede a su propiedad Name.
   ///
   /// Principios:
   ///
   /// SRP- La única razón de cambio válida en este controlador es cambios en la manera de representar todos los proyectos asociados a un
   /// cliente.
   /// </summary>

namespace Linked.Pages.MyProjectsC
{
    public class IndexModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public Client currentUser { get; set; }

        public IndexModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public IList<Project> Projects {get;set;}

        public async Task OnGetAsync()
        {
            try {
                string userId = User.Identity.Name; // Gets the current logged email
                currentUser = _context.Client.FirstOrDefault(x => x.Email == userId); // Gets from context the Client with that email
                Projects = await  _context.Project.Where( p => p.ClientID == currentUser.ClientID ).ToListAsync(); //Gets projects from Client
            } catch (ArgumentNullException e) {
                Console.WriteLine("Something went wrong getting the logged user: " + e);
                RedirectToPage("https://localhost:5001/");
            }
        }
    }
}