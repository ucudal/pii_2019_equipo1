using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Linked.Models;

   /// <summary>
   /// Los controladores son los encargados de traducir las entradas de los usuarios en acciones a ser llevadas a cabo por el modelo.
   /// Es decir, maneja las interacciones con los usuarios y provee un mecanismo por el cual se produce un cambio en el estado del modelo.
   /// Uno de los propósitos en MVC es separar el modelo de las vistas a modo de que cambios en las vistas no se tengan que verse reflejadas
   /// en el modelo y viceversa, en otras palabras, modularizar la aplicación.
   /// 
   /// Esta clase hereda de PageModel de modo que extiende sus propiedades y comportamiento sin necesidad de volver a implementarlo. Por lo tanto, la clase CreateProject tiene una clasificación jerárquica por debajo de PageModel.
   ///
   /// Su propósito es crear instancias de Project y persistirlas en la base de datos.
   ///
   /// Colaboradores: Project, Client, User.Identity y Linked.Areas.Identity.Data.IdentityContext   
   ///
   /// Patrones: 
   ///
   /// Singleton - User.Identity es un objeto de alcance global dentro de la aplicación y el mismo es instanciado solo una vez cuando
   /// el usuario entra a la aplicación. Desde esta clase se accede a su propiedad Name.
   /// 
   /// Expert / Creator - Este controlador es quien contiene la información requerida para crear instancias de Project: Title, Client,
   /// Description y Date. Title, Description y Date se obtienen en colaboración con View, que contiene un formulario.
   /// 
   /// Don’t repeat yourself (DRY) - En la aplicación se respeta el principio DRY ya que los comportamientos específicos se encuentran
   /// implementados en una sola clase, en este caso, la creación de entidades de proyectos.
   ///
   /// Principios:
   ///
   /// SRP- La única razón de cambio válida en este controlador es cambios en el comportamiento que crea y persiste proyectos. Todos los atributos y métodos en esta clase cumplen este único propósito.
   /// </summary>

namespace Linked.Pages.ProjectsC{
    public class CreateModel : PageModel{
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public CreateModel(Linked.Areas.Identity.Data.IdentityContext context){
            _context = context;
        }

        [BindProperty]
        public Project Project { get; set; }
        public Client currentUser { get; set; } // Current Client logged in the app

        public async Task<IActionResult> OnPostAsync(){
            
            try {
                string userId = User.Identity.Name; // Gets the current logged email
                currentUser = _context.Client.FirstOrDefault(x => x.Email == userId); // Gets from context the Client with that email
            } catch (Exception e) {
                Console.WriteLine("Something went wrong getting the logged user: " + e);
                return RedirectToPage("https://localhost:5001/");
            }

            Project.ClientID = currentUser.ClientID; // Adds the clientID to the Project

            if (!ModelState.IsValid){
                return RedirectToPage("./MyProjects");
            }

            _context.Project.Add(Project);
            await _context.SaveChangesAsync();
            
            return RedirectToPage("./MyProjects");
        }
    }
}