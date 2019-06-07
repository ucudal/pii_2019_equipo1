// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.RazorPages;
// using Microsoft.AspNetCore.Mvc.Rendering;
// using ProyectoIgnis.Models;

// namespace ProyectoIgnis.Pages.ProjectsAllocated
// {
//     public class CreateModel : PageModel
//     {
//         private readonly ProyectoIgnis.Models.IgnisContext _context;

//         public CreateModel(ProyectoIgnis.Models.IgnisContext context)
//         {
//             _context = context;
//         }

//         public IActionResult OnGet()
//         {
//             return Page();
//         }

//         [BindProperty]
//         public ProjectAllocated ProjectAllocated { get; set; }

//         public async Task<IActionResult> OnPostAsync()
//         {
//             if (!ModelState.IsValid)
//             {
//                 return Page();
//             }

//             _context.ProjectAllocated.Add(ProjectAllocated);
//             await _context.SaveChangesAsync();

//             return RedirectToPage("./Index");
//         }
//     }
// }