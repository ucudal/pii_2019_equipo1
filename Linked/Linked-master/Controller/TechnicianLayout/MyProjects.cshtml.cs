using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
            IEnumerable<Project> projects = Enumerable.Empty<Project>();
            try {
                foreach(Employ emp in _context.Employ.Where(p=> p.TechnicianID == id)){
                    projects = projects.Concat(_context.Project.Where(t => t.ProjectID == emp.ProjectID).AsEnumerable());
                }
            } catch (Exception e) {
                Console.WriteLine("Exception ocurred while getting the projects: "+e);
            }
            return projects;
        }

        public void OnGet(){
            
            try {
                string userId = User.Identity.Name; // Gets the current logged email
                currentUser = _context.Technician.FirstOrDefault(x => x.Email == userId); // Gets from context the Client with that email
            } catch (Exception e) {
                Console.WriteLine("Something went wrong getting the logged user: " + e);
                RedirectToPage("https://localhost:5001/");
            }

            Projects = LoadProjects(currentUser.TechnicianID);
        }
    }
}