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
    public class IndexModel : PageModel
    {
        private readonly Linked.Models.LinkedContext _context;

        public IndexModel(Linked.Models.LinkedContext context)
        {
            _context = context;
        }

        public IList<FeedBack> FeedBack { get;set; }

        public async Task OnGetAsync()
        {
            FeedBack = await _context.FeedBack
                .Include(f => f.Project)
                .Include(f => f.ScoreSheet)
                .Include(f => f.User).ToListAsync();
        }
    }
}
