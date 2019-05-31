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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLinked.Models.RazorPagesLinkedContext _context;

        public IndexModel(RazorPagesLinked.Models.RazorPagesLinkedContext context)
        {
            _context = context;
        }

        public IList<FeedBack> FeedBack { get;set; }

        public async Task OnGetAsync()
        {
            FeedBack = await _context.FeedBack_1.ToListAsync();
        }
    }
}
