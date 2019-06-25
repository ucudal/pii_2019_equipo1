/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Linked.Models;
using Microsoft.EntityFrameworkCore;
using Linked.Areas.Identity.Data;

namespace Linked.Pages.Projects{
    public class AllocateModel : PageModel{
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public AllocateModel(Linked.Areas.Identity.Data.IdentityContext context){
            _context = context;
        }

        public Project Project { get; set; }
        public ApplicationUser currentUser { get; set; }
        
        public async Task OnGetAsync(string id){
            Project = await _context.Project.FindAsync(id);
            TechniciansAlternativos = LoadTechniciansAlternativos();
            Technician = LoadTechnicians();
            InterestedTechnicians = LoadInterestedTechnicians();
        }
        public Technician TechnicianSelected {get; set;}
        public IEnumerable<Technician> Technician {get;set;}

        public IEnumerable<Technician> TechniciansAlternativos {get;set;}

        public IEnumerable<Technician> InterestedTechnicians {get;set;}

        public IEnumerable<Technician> LoadTechniciansAlternativos(){
            var db = _context;
            IEnumerable<Technician> e = Enumerable.Empty<Technician>();
            IEnumerable<Technician> f = Enumerable.Empty<Technician>();
            try {
                foreach(Employ emp in db.Employ.Where(p=> p.ProjectID == Project.ProjectID)){
                    f = f.Concat(db.Technician.Where(t => t.TechnicianID == emp.TechnicianID).AsEnumerable());
                }
                foreach(Technician technician in db.Technician.Include(c=>c.Employers).AsEnumerable()){
                    if (technician.Specialty == Project.Specialty && technician.Level != Project.Level && !f.Contains(technician)){
                        e = e.Append(technician);
                    }
                }
            }catch{}
            return e;
        }

        public IEnumerable<Technician> LoadInterestedTechnicians(){
            var db = _context;
            IEnumerable<Technician> f = Enumerable.Empty<Technician>();
            foreach(Interest interest in db.Interest.Where(i => i.ProjectID == Project.ProjectID)){
                f = f.Concat(db.Technician.Where(t => t.TechnicianID == interest.TechnicianID).AsEnumerable());
            }
            return f;
        }

        public IEnumerable<Technician> LoadTechnicians(){
            var db = _context;
            IEnumerable<Technician> e = Enumerable.Empty<Technician>();
            IEnumerable<Technician> f = Enumerable.Empty<Technician>();
            try {
                foreach(Employ emp in db.Employ.Where(p=> p.ProjectID == Project.ProjectID)){
                    f = f.Concat(db.Technician.Where(t => t.TechnicianID == emp.TechnicianID).AsEnumerable());
                }
                foreach(Technician technician in db.Technician.Include(c=>c.Employers).AsEnumerable()){
                    if (technician.Specialty == Project.Specialty && technician.Level == Project.Level && !f.Contains(technician)){
                        e = e.Append(technician);
                    }
                }
            }catch{}
            return e;
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Project.FindAsync(id);
            string TechId = Request.Form["TechnicianID"];
            //string ParsedTechId = string.Parse(TechId);
            string ParsedTechId = TechId;
            TechnicianSelected = await _context.Technician.FindAsync(ParsedTechId);

            if (Project != null)
            {
                Employ NewEmploy = new Employ();
                NewEmploy.TechnicianID = ParsedTechId;
                NewEmploy.ProjectID = Project.ProjectID;
                _context.Employ.Add(NewEmploy);
                await _context.SaveChangesAsync();
            }
            
            if(User.IsInRole(IdentityData.NonAdminRoleNames[0])){
                return RedirectToPage("../ClientLayout/MyProjects");
            }

            return RedirectToPage("./Index");
        }
    }
}       */