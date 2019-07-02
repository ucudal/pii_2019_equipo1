using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

namespace Linked.Pages.Projects
{
    public class DetailsModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public DetailsModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public Project Project { get; set; }

        public IEnumerable<Technician> Technicians {get;set;}

        public IEnumerable<Requirement> Requirements {get;set;}

        public IEnumerable<Technician> LoadTechnicians(){
            IEnumerable<Technician> tecEmployed = Enumerable.Empty<Technician>();
            try {
                foreach(Employ emp in _context.Employ.Where(p=> p.ProjectID == Project.ProjectID)){
                    tecEmployed = tecEmployed.Concat(_context.Technician.Where(t => t.TechnicianID == emp.TechnicianID).AsEnumerable());
                }
           } catch (Exception e) {
                Console.WriteLine("Exception ocurred while getting the employed technicians: "+e);
            }
            return tecEmployed;
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null){return NotFound();}

            Project = await _context.Project
                .Include(p => p.Client).FirstOrDefaultAsync(m => m.ProjectID == id);
                
            if (Project == null){return NotFound();}

            Requirements = await _context.Requirement.Where(m => m.ProjectID == id).ToListAsync();

            Technicians = LoadTechnicians();

            return Page();
        }
    }
}
