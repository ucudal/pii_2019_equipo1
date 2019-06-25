using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Linked.Areas.Identity.Data;
using Linked.Models;

namespace Linked.Pages.Requirements
{
    public class EditModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public EditModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Requirement Requirement { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Requirement = await _context.Requirement.FirstOrDefaultAsync(m => m.ProjectID == id);

            if (Requirement == null)
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

            _context.Attach(Requirement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequirementExists(Requirement.ProjectID))
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

        private bool RequirementExists(string id)
        {
            return _context.Requirement.Any(e => e.ProjectID == id);
        }
    }
}
