using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Linked.Areas.Identity.Data;
using System.Security.Principal;
using Linked.Models;

namespace Linked.Pages.MyProjectsC
{
    public class IndexModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public Client currentUser { get; set; }

        public IndexModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public IList<Project> Projects {get;set;}

        public async Task OnGetAsync()
        {
            string userId = User.Identity.Name;
            currentUser = _context.Client.FirstOrDefault(x => x.Email == userId);
            
            Projects = await  _context.Project.Where( p => p.ClientID == currentUser.ClientID ).ToListAsync();
        }
    }
}