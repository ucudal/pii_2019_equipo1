using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

  /// <summary>
  /// Los patrones y principios que son aplicados en estas clases son explicitados y explicados en las clases de Client ya que estas 
  /// se pueden considerar semejantes en su diseño debido a que se hacen con scaffolding.
  /// </summary>

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
