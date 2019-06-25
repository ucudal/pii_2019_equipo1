using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Linked.Areas.Identity.Data;
using Linked.Models;

namespace Linked.Pages.AddRequirement{
    public class CreateModel : PageModel{
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public CreateModel(Linked.Areas.Identity.Data.IdentityContext context){
            _context = context;
        }

        [BindProperty]
        public Requirement Requirement { get; set; }

        public Project Project { get; set; }

        public List<SelectListItem> Specialties{ get; set; }
        public List<SelectListItem> Levels{ get; set; }

        public async Task OnGetAsync(string id){
            Project = _context.Project.Where(p=> p.ProjectID == id).FirstOrDefault<Project>();

            Specialties = Enum.GetValues(typeof(Specialty)).Cast<Specialty>().ToList()
            .Select(spy => new SelectListItem
            {
                Value = spy.ToString(),
                Text = spy.ToString()
            })
            .ToList();

            Levels = Enum.GetValues(typeof(Level)).Cast<Level>().ToList()
            .Select(lvl => new SelectListItem
            {
                Value = lvl.ToString(),
                Text = lvl.ToString()
            })
            .ToList();
        }

        public async Task<IActionResult> OnPostAsync(string id){
            Requirement.ProjectID = id;

            _context.Requirement.Add(Requirement);
            await _context.SaveChangesAsync();

            if(User.IsInRole(IdentityData.NonAdminRoleNames[0])){
                return RedirectToPage("../ClientLayout/MyProjects");
            }

            return RedirectToPage("./Index");
        }
    }
}