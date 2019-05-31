using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLinked.Models;

namespace RazorPagesLinked.Pages.Linked3
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesLinked.Models.RazorPagesLinkedContext _context;

        public DetailsModel(RazorPagesLinked.Models.RazorPagesLinkedContext context)
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

            FeedBack = await _context.FeedBack_1.FirstOrDefaultAsync(m => m.ID == id);

            if (FeedBack == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
