using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

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
            var db = _context;
            return db.Project.Where(p=>p.ClientID == Client.ClientID).AsEnumerable();
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Client.FirstOrDefaultAsync(m => m.ClientID == id);
            Projects = LoadProjects();

            if (Client == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
