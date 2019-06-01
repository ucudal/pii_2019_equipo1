using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesLinked.Areas.Identity.Data;

namespace RazorPagesLinked.Areas.Identity.Pages.RazorPagesLinkedUsers
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesLinked.Areas.Identity.Data.RazorPagesLinkedIdentityDbContext _context;

        public EditModel(RazorPagesLinked.Areas.Identity.Data.RazorPagesLinkedIdentityDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(RazorPagesLinkedUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RazorPageLinkedUserExists(RazorPagesLinkedUser.Id))
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

        private bool RazorPageLinkedUserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
