using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Linked.Models;

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