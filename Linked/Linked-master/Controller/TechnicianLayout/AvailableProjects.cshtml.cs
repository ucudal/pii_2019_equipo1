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

        public IndexModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            try {
                string userId = User.Identity.Name; // Gets the current logged email
                currentUser = _context.Technician.FirstOrDefault(x => x.Email == userId); // Gets from context the Client with that email
            } catch (Exception e) {
                Console.WriteLine("Something went wrong getting the logged user: " + e);
                return RedirectToPage("https://localhost:5001/");
            }

            if (currentUser == null){return RedirectToPage("https://localhost:5001/");}

            Specialty = currentUser.Specialty;

            Requirements = await _context.Requirement
                .Where(r => r.Specialty == currentUser.Specialty).Include(r => r.Project).ToListAsync();
            
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            string ProjectID = Request.Form["ProjectID"];
            string userId = User.Identity.Name; // Gets the current logged email
            currentUser = _context.Technician.FirstOrDefault(x => x.Email == userId); // Gets from context the Client with that email

            Interest newInterest = new Interest();
            newInterest.ProjectID = ProjectID;
            newInterest.TechnicianID = currentUser.TechnicianID;
            
            try{
                _context.Interest.Add(newInterest);
                await _context.SaveChangesAsync();
            } catch (Exception e) {
                Console.WriteLine("The user is already interested in this project: "+e);
            }

            return RedirectToPage("./MyProjects");
        }
    }
}