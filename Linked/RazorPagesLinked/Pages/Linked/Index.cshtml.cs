using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLinked.Models;

namespace RazorPagesLinked.Pages.Linked
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLinked.Models.RazorPagesLinkedContext _context;

        public IndexModel(RazorPagesLinked.Models.RazorPagesLinkedContext context)
        {
            _context = context;
        }

        public IList<FeedBackItem> FeedBackItem { get;set; }

        public async Task OnGetAsync()
        {
            FeedBackItem = await _context.FeedBackItem.ToListAsync();
        }
    }
}
