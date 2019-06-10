using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Linked.Models;

namespace Linked.Pages.Technicians
{
    public class CreateModel : PageModel
    {
        private readonly Linked.Models.LinkedContext _context;

        public CreateModel(Linked.Models.LinkedContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Technician Technician { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Technician.Add(Technician);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}