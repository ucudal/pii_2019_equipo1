using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

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