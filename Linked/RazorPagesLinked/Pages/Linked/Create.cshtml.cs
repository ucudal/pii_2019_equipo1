using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesLinked.Models;

namespace RazorPagesLinked.Pages.Linked
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesLinked.Models.RazorPagesLinkedContext _context;

        public CreateModel(RazorPagesLinked.Models.RazorPagesLinkedContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FeedBackItem FeedBackItem { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FeedBackItem.Add(FeedBackItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}