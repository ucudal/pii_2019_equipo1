using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Areas.Identity.Data;
using Linked.Models;

namespace Linked.Pages.Requirements
{
    public class IndexModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public IndexModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public IList<Requirement> Requirement { get;set; }

        public async Task OnGetAsync()
        {
            Requirement = await _context.Requirement.ToListAsync();
        }
    }
}
