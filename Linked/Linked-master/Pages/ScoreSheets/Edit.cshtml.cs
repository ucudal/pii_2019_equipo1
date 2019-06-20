using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

namespace Linked.Pages.ScoreSheets
{
    public class EditModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public EditModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ScoreSheet ScoreSheet { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ScoreSheet = await _context.ScoreSheet.FirstOrDefaultAsync(m => m.ScoreSheetID == id);

            if (ScoreSheet == null)
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

            _context.Attach(ScoreSheet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoreSheetExists(ScoreSheet.ScoreSheetID))
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

        private bool ScoreSheetExists(string id)
        {
            return _context.ScoreSheet.Any(e => e.ScoreSheetID == id);
        }
    }
}
