using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

namespace Linked.Pages.ScoreSheets
{
    public class DeleteModel : PageModel
    {
        private readonly Linked.Models.LinkedContext _context;

        public DeleteModel(Linked.Models.LinkedContext context)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ScoreSheet = await _context.ScoreSheet.FindAsync(id);

            if (ScoreSheet != null)
            {
                _context.ScoreSheet.Remove(ScoreSheet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
