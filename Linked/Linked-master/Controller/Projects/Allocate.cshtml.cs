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

namespace Linked.Pages.Projects{
    public class AllocateModel : PageModel{
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public AllocateModel(Linked.Areas.Identity.Data.IdentityContext context){
            _context = context;
        }

        public Project Project { get; set; }
        public ApplicationUser currentUser { get; set; }

        public Technician TechnicianSelected {get; set;}
        public IList<Technician> Technicians {get;set;}
        public IList<Technician> TechniciansAlternativos {get;set;}
        public IList<Technician> InterestedTechnicians {get;set;}
        public IList<Technician> CurrentTechnicians {get;set;}
        
        public async Task OnGetAsync(string id){
            Project = await _context.Project.FindAsync(id);

            List<Technician> curTec = new List<Technician>();
            foreach(Employ e in _context.Employ.Where( emp => emp.ProjectID == Project.ProjectID)){
                curTec.Add(_context.Technician.Find( e.TechnicianID ));
            }

            CurrentTechnicians = curTec;
            Technicians = LoadTechnicians();
            TechniciansAlternativos = LoadTechniciansAlternativos();
            InterestedTechnicians = LoadInterestedTechnicians();
        }

        public IList<Technician> LoadTechnicians(){
            List<Technician> reqTec = new List<Technician>();
            foreach(Requirement required in _context.Requirement.Where(i => i.ProjectID == Project.ProjectID)){
                foreach(Technician posTec in _context.Technician.Where(t => t.Specialty == required.Specialty)){
                    if(posTec.Level == required.Level && !CurrentTechnicians.Contains(posTec)){
                        reqTec.Add(posTec);
                    }
                }
            }
            return reqTec;
        }
        
        public IList<Technician> LoadTechniciansAlternativos(){
            List<Technician> altTec = new List<Technician>();
            foreach(Requirement required in _context.Requirement.Where(i => i.ProjectID == Project.ProjectID)){
                foreach(Technician posTec in _context.Technician.Where(t => t.Specialty == required.Specialty)){
                    if(posTec.Level != required.Level && !CurrentTechnicians.Contains(posTec)){
                        altTec.Add(posTec);
                    }
                }
            }
            return altTec;
        }

        public IList<Technician> LoadInterestedTechnicians(){
            IList<Technician> intTec = new List<Technician>();
            foreach(Interest interest in _context.Interest.Where(i => i.ProjectID == Project.ProjectID)){
                foreach (Technician posTec in _context.Technician.Where(t => t.TechnicianID == interest.TechnicianID)){
                    if(!CurrentTechnicians.Contains(posTec)){
                        intTec.Add(posTec);
                    }
                }
            }
            return intTec;
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
}       