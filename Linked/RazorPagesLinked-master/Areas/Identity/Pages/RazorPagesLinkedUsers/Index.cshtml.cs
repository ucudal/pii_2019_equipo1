using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLinked.Areas.Identity.Data;

namespace RazorPagesLinked.Areas.Identity.Pages.RazorPagesLinkedUsers
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLinked.Areas.Identity.Data.RazorPagesLinkedIdentityDbContext _context;

        public IndexModel(RazorPagesLinked.Areas.Identity.Data.RazorPagesLinkedIdentityDbContext context)
        {
            _context = context;
        }

        public IList<RazorPagesLinkedUser> RazorPagesLinkedUser { get;set; }

        public async Task OnGetAsync()
        {
            RazorPagesLinkedUser = await _context.Users.ToListAsync();
        }
    }
}
