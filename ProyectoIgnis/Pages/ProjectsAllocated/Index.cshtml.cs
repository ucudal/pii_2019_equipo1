using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProyectoIgnis.Models;

namespace ProyectoIgnis.Pages.ProjectsAllocated
{
    public class IndexModel : PageModel
    {
        private readonly ProyectoIgnis.Models.IgnisContext _context;

        public IndexModel(ProyectoIgnis.Models.IgnisContext context)
        {
            _context = context;
        }

        public IList<ProjectAllocated> ProjectAllocated { get;set; }

        public async Task OnGetAsync()
        {
            ProjectAllocated = await _context.ProjectAllocated.ToListAsync();
        }
    }
}
