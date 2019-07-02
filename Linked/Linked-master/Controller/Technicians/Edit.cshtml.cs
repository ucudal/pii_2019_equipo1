using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Linked.Models;

namespace Linked.Pages.Technicians
{
    public class EditModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public EditModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Technician Technician { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Technician = await _context.Technician.FirstOrDefaultAsync(m => m.TechnicianID == id);

            if (Technician == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Technician).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TechnicianExists(Technician.TechnicianID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TechnicianExists(string id)
        {
            return _context.Technician.Any(e => e.TechnicianID == id);
        }
    }
}
