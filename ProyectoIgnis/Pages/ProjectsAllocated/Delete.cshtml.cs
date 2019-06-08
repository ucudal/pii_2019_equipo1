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
    public class DeleteModel : PageModel
    {
        private readonly ProyectoIgnis.Models.IgnisContext _context;

        public DeleteModel(ProyectoIgnis.Models.IgnisContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProjectAllocated ProjectAllocated { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProjectAllocated = await _context.ProjectAllocated.FirstOrDefaultAsync(m => m.ID == id);

            if (ProjectAllocated == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProjectAllocated = await _context.ProjectAllocated.FindAsync(id);

            if (ProjectAllocated != null)
            {
                _context.ProjectAllocated.Remove(ProjectAllocated);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
