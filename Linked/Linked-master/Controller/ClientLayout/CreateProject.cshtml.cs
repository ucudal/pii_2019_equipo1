using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Linked.Models;

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