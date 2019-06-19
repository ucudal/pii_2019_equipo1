using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Linked.Models;
using Linked.Areas.Identity.Data;

namespace Linked.Pages.Clients
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
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Client.Add(Client);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}