using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Linked.Models;

namespace Linked.Pages.FeedBacks
{
    public class CreateModel : PageModel
    {
        private readonly Linked.Models.LinkedContext _context;

        public CreateModel(Linked.Models.LinkedContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ProjectID"] = new SelectList(_context.Project, "ProjectID", "ProjectID");
        ViewData["ScoreSheetID"] = new SelectList(_context.ScoreSheet, "ScoreSheetID", "ScoreSheetID");
        ViewData["UserID"] = new SelectList(_context.User, "UserID", "UserID");
            return Page();
        }

        [BindProperty]
        public FeedBack FeedBack { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FeedBack.Add(FeedBack);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}