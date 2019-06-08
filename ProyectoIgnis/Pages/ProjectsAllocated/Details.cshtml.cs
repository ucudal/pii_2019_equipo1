using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProyectoIgnis.Models;

namespace ProyectoIgnis.Pages.ProjectsAllocated
{
    public class DetailsModel : PageModel
    {
        private readonly ProyectoIgnis.Models.IgnisContext _context;

        public DetailsModel(ProyectoIgnis.Models.IgnisContext context)
        {
            _context = context;
        }

        public ProjectAllocated ProjectAllocated { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProjectAllocated = await _context.ProjectAllocated.Include(p => p.Technician).FirstOrDefaultAsync(m => m.ID == id);

            if (ProjectAllocated == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
