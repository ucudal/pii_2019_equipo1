using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

namespace Linked.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public IndexModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; }

        public async Task OnGetAsync()
        {
            Project = await _context.Project
                .Include(p => p.Client).ToListAsync();
        }
    }
}
