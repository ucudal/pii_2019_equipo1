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
    public class DetailsModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public DetailsModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public Requirement Requirement { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Requirement = await _context.Requirement.FirstOrDefaultAsync(m => m.ProjectID == id);

            if (Requirement == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
