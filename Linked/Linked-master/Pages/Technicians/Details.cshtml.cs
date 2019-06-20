using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

namespace Linked.Pages.Technicians
{
    public class DetailsModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public DetailsModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public Technician Technician { get; set; }

        public IEnumerable<Project> Projects {get;set;}

        public IEnumerable<Project> LoadProjects(){
            var db = _context;
            IEnumerable<Project> e = Enumerable.Empty<Project>();
            try {
                foreach(Employ emp in db.Employ.Where(p=> p.TechnicianID == Technician.TechnicianID)){
                    e = e.Concat(db.Project.Where(t => t.ProjectID == emp.ProjectID).AsEnumerable());
                }
           }catch{}
            return e;
        }

        public IEnumerable<ScoreSheet> ScoreSheets { get; set; }

        public IEnumerable<ScoreSheet> LoadScoreSheets(){
            var db = _context;
            IEnumerable<ScoreSheet> e = Enumerable.Empty<ScoreSheet>();
            try{
                foreach(FeedBack fb in db.FeedBack.Where(p => p.TechnicianID == Technician.TechnicianID)){
                    e = e.Concat(db.ScoreSheet.Where(t => t.ScoreSheetID == fb.ScoreSheetID).AsEnumerable());
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

            Technician = await _context.Technician.FirstOrDefaultAsync(m => m.TechnicianID == id);

            Projects = LoadProjects();

            ScoreSheets = LoadScoreSheets();

            if (Technician == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
