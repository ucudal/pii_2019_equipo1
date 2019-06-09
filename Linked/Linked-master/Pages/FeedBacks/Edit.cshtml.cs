using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

namespace Linked.Pages.FeedBacks
{
    public class EditModel : PageModel
    {
        private readonly Linked.Models.LinkedContext _context;

        public EditModel(Linked.Models.LinkedContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["ProjectID"] = new SelectList(_context.Project, "ProjectID", "ProjectID");
           ViewData["ScoreSheetID"] = new SelectList(_context.ScoreSheet, "ScoreSheetID", "ScoreSheetID");
           ViewData["UserID"] = new SelectList(_context.User, "UserID", "UserID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FeedBack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeedBackExists(FeedBack.ProjectID))
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

        private bool FeedBackExists(int id)
        {
            return _context.FeedBack.Any(e => e.ProjectID == id);
        }
    }
}
