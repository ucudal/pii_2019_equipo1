using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Areas.Identity.Data;
using Linked.Models;

namespace Linked.Pages.Requirements
{
    public class DeleteModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public DeleteModel(Linked.Areas.Identity.Data.IdentityContext context)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Requirement = await _context.Requirement.FindAsync(id);

            if (Requirement != null)
            {
                _context.Requirement.Remove(Requirement);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
