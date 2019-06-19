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
        private readonly Linked.Models.LinkedContext _context;

        public DetailsModel(Linked.Models.LinkedContext context)
        {
            _context = context;
        }

        public Project Project { get; set; }

        public IEnumerable<Technician> Technicians {get;set;}

        public IEnumerable<Technician> LoadTechnicians(){
            var db = _context;
            IEnumerable<Technician> e = Enumerable.Empty<Technician>();
            try {
                foreach(Employ emp in db.Employ.Where(p=> p.ProjectID == Project.ProjectID)){
                    e = e.Concat(db.Technician.Where(t => t.TechnicianID == emp.TechnicianID).AsEnumerable());
                }
           }catch{}
            return e;
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Project
                .Include(p => p.Client).FirstOrDefaultAsync(m => m.ProjectID == id);

            Technicians = LoadTechnicians();

            if (Project == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
