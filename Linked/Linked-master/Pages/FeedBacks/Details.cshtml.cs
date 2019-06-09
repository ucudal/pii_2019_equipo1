using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

namespace Linked.Pages.FeedBacks
{
    public class DetailsModel : PageModel
    {
        private readonly Linked.Models.LinkedContext _context;

        public DetailsModel(Linked.Models.LinkedContext context)
        {
            _context = context;
        }

        public FeedBack FeedBack { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FeedBack = await _context.FeedBack
                .Include(f => f.Project)
                .Include(f => f.ScoreSheet)
                .Include(f => f.User).FirstOrDefaultAsync(m => m.ProjectID == id);

            if (FeedBack == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
