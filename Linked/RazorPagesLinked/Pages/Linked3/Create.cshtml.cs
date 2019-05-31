using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesLinked.Models;

namespace RazorPagesLinked.Pages.Linked3
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
        public FeedBack FeedBack { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FeedBack_1.Add(FeedBack);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}