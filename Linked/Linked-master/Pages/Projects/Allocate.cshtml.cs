using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Linked.Models;
using Microsoft.EntityFrameworkCore;
using Linked.Areas.Identity.Data;

namespace Linked.Pages.Projects
{
    public class AllocateModel : PageModel
    {
        private readonly Linked.Models.LinkedContext _context;

        public AllocateModel(Linked.Models.LinkedContext context)
        {
            _context = context;
        }

        public Project Project { get; set; }

        public IEnumerable<Technician> Technicians {get;set;}

        public IEnumerable<Technician> LoadTechnicians(){
            var db = _context;
            IEnumerable<Technician> e = Enumerable.Empty<Technician>();
            IEnumerable<Technician> f = Enumerable.Empty<Technician>();
            try {
                foreach(Employ emp in db.Employ.Where(p=> p.ProjectID == Project.ProjectID)){
                    f = f.Concat(db.Technician.Where(t => t.TechnicianID == emp.TechnicianID).AsEnumerable());
                }
                foreach(Technician technician in db.Technician.Include(c=>c.Employers).AsEnumerable()){
                    if (technician.Role == Project.Role && technician.Level == Project.Level && !f.Contains(technician)){
                        e = e.Append(technician);
                    }
                }
            }catch{}
            return e;
        }

        public IEnumerable<Technician> TechniciansAlternativos {get;set;}

        public IEnumerable<Technician> LoadTechniciansAlternativos(){
            var db = _context;
            IEnumerable<Technician> e = Enumerable.Empty<Technician>();
            IEnumerable<Technician> f = Enumerable.Empty<Technician>();
            try {
                foreach(Employ emp in db.Employ.Where(p=> p.ProjectID == Project.ProjectID)){
                    f = f.Concat(db.Technician.Where(t => t.TechnicianID == emp.TechnicianID).AsEnumerable());
                }
                foreach(Technician technician in db.Technician.Include(c=>c.Employers).AsEnumerable()){
                    if (technician.Role == Project.Role && technician.Level != Project.Level && !f.Contains(technician)){
                        e = e.Append(technician);
                    }
                }
            }catch{}
            return e;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Project.FirstOrDefaultAsync(m => m.ProjectID == id);

            Technicians = LoadTechnicians();
            TechniciansAlternativos = LoadTechniciansAlternativos();

            if (Project == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}