using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Linked.Models;

namespace Linked.Pages.ProjectsC
{
    public class CreateModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public CreateModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Project Project { get; set; }

        public Client currentUser { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            string userId = User.Identity.Name;
            currentUser = _context.Client.FirstOrDefault(x => x.Email == userId);

            Project.ClientID = currentUser.ClientID;

            _context.Project.Add(Project);
            await _context.SaveChangesAsync();
            
            return RedirectToPage("./MyProjects");
        }
    }
}