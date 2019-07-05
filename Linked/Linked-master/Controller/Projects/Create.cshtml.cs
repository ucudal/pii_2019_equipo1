using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Linked.Models;

  /// <summary>
  /// Los patrones y principios que son aplicados en estas clases son explicitados y explicados en las clases de Client ya que estas 
  /// se pueden considerar semejantes en su diseño debido a que se hacen con scaffolding.
  /// </summary>
  
namespace Linked.Pages.Projects
{
    public class CreateModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public CreateModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClientID"] = new SelectList(_context.Client, "ClientID", "ClientID");
            return Page();
        }

        [BindProperty]
        public Project Project { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Project.Add(Project);
            await _context.SaveChangesAsync();
            
            return RedirectToPage("./Index");
        }
    }
}