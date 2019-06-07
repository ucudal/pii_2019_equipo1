using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoIgnis.Models;

namespace ProyectoIgnis.Pages.ProjectsAllocated
{
    public class EditModel : PageModel
    {
        private readonly ProyectoIgnis.Models.IgnisContext _context;

        public EditModel(ProyectoIgnis.Models.IgnisContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProjectAllocated).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectAllocatedExists(ProjectAllocated.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProjectAllocatedExists(int id)
        {
            return _context.ProjectAllocated.Any(e => e.ID == id);
        }
    }
}
