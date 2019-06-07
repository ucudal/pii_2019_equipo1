using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoIgnis.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoIgnis.Pages.Projects
{
    public class AllocateModel : PageModel
    {
        public Project Project {get; set;}
        public IList<Technician> Technician {get; set;}
        private readonly ProyectoIgnis.Models.IgnisContext _context;

        public AllocateModel(ProyectoIgnis.Models.IgnisContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int? id)
        {
            Project = await _context.Project.FindAsync(id);

            var technicians = from t in _context.Technician
                 select t;
            if (Project != null)
            {
                technicians = technicians.Where(tec => tec.Role.Equals(Project.Role)&&tec.Level.Equals(Project.Level));
            }
            Technician = await technicians.ToListAsync();
        }
        public Technician TechnicianSelected {get; set;}
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Project.FindAsync(id);
            TechnicianSelected = await _context.Technician.FindAsync(id);

            if (Project != null)
            {
                ProjectAllocated NewProject = new ProjectAllocated();
                NewProject.Technician = TechnicianSelected;
                NewProject.ID = Project.ID;
                NewProject.HourLoad = Project.HourLoad;
                NewProject.Description = Project.Description;
                NewProject.Client = Project.Client;
                NewProject.Level = Project.Level;
                NewProject.Role = Project.Role;

                _context.Project.Remove(Project);
                _context.ProjectAllocated.Add(NewProject);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}