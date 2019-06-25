using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Linked.Areas.Identity.Data;
using System.Security.Principal;
using Linked.Models;

namespace Linked.Pages.AvailableProjects
{
    public class IndexModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public IList<Requirement> Requirements { get;set; }
        public Technician currentUser { get; set; }
        public Project Project { get; set; }
        public Specialty Specialty { get; set; }
        public string AlreadyInterested { get;set; }

        public IndexModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            string userId = User.Identity.Name;
            currentUser = _context.Technician.FirstOrDefault(x => x.Email == userId);
            Specialty = currentUser.Specialty;
            Requirements = await _context.Requirement
                .Where(r => r.Specialty == currentUser.Specialty).Include(r => r.Project).ToListAsync();
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            string ProjectID = Request.Form["ProjectID"];
            string userId = User.Identity.Name;
            currentUser = _context.Technician.FirstOrDefault(x => x.Email == userId);

            Interest newInterest = new Interest();
            newInterest.ProjectID = ProjectID;
            newInterest.TechnicianID = currentUser.TechnicianID;
            _context.Interest.Add(newInterest);
            await _context.SaveChangesAsync();
            //catch you have already showed interest in this project
            return RedirectToPage("./MyProjects");
        }
    }
}