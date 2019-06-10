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
    public class DetailsModel : PageModel
    {
        private readonly Linked.Models.LinkedContext _context;

        public DetailsModel(Linked.Models.LinkedContext context)
        {
            _context = context;
        }

        public ScoreSheet ScoreSheet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
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
    }
}
