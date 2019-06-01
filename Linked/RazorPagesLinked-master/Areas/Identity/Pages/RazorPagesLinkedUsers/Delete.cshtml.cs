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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesLinked.Areas.Identity.Data.RazorPagesLinkedIdentityDbContext _context;

        public DeleteModel(RazorPagesLinked.Areas.Identity.Data.RazorPagesLinkedIdentityDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RazorPagesLinkedUser RazorPagesLinkedUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RazorPagesLinkedUser = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (RazorPagesLinkedUser == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RazorPagesLinkedUser = await _context.Users.FindAsync(id);

            if (RazorPagesLinkedUser != null)
            {
                _context.Users.Remove(RazorPagesLinkedUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
