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

namespace Linked.Pages.MyProjects
{
    public class IndexModel : PageModel
    {
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public Technician currentUser { get; set; }

        public IndexModel(Linked.Areas.Identity.Data.IdentityContext context)
        {
            _context = context;
        }

        public IEnumerable<Project> Projects {get;set;}

        public IEnumerable<Project> LoadProjects(string id){
            var db = _context;
            IEnumerable<Project> e = Enumerable.Empty<Project>();
            try {
                foreach(Employ emp in db.Employ.Where(p=> p.TechnicianID == id)){
                    e = e.Concat(db.Project.Where(t => t.ProjectID == emp.ProjectID).AsEnumerable());
                }
           }catch{}
            return e;
        }

        public async Task OnGetAsync()
        {
            string userId = User.Identity.Name;
            currentUser = _context.Technician.FirstOrDefault(x => x.Email == userId);
            
            Projects = LoadProjects(currentUser.TechnicianID);
        }
    }
}