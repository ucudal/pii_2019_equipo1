using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Linked.Models;
using Microsoft.EntityFrameworkCore;
using Linked.Areas.Identity.Data;

  /// <summary>
  /// Los controladores son los encargados de traducir las entradas de los usuarios en acciones a ser llevadas a cabo por el modelo.
  /// Es decir, maneja las interacciones con los usuarios y provee un mecanismo por el cual se produce un cambio en el estado del modelo.
  /// Uno de los propósitos en MVC es separar el modelo de las vistas a modo de que cambios en las vistas no se tengan que verse reflejadas
  /// en el modelo y viceversa, en otras palabras, modularizar la aplicación.
  ///
  /// Esta clase hereda de PageModel de modo que extiende sus propiedades y comportamiento sin necesidad de volver a implementarlo.
  /// Por lo tanto, la clase AllocateModel tiene una clasificación jerárquica por debajo de PageModel.
  ///
  /// Su propósito es brindarle la posibilidad a un cliente de asignar un técnico a un proyecto
  ///
  /// Colaboradores: Project, Technician, Specialty, Level, Employ y Linked.Areas.Identity.Data.IdentityContext  
  ///
  /// Expert / Creator - Sobre esta clase sobrecae la responsabilidad de crear los objetos de Employ ya que conoce toda la información 
  /// necesaria para hacerlo logrando de este modo una mayor cohesión.
  ///
  /// DRY - Esta clase es la única capaz de crear relaciones entre los técnicos y los proyectos a través de los nexos Employ
  ///
  /// Principios:
  /// SRP- La única responsabilidad de esta clase es crear instancias de Employ.
  ///
  /// ISP: AllocateModel implementa todos los tipos (IAsyncPageFilter, IFilterMetadata, IPageFilter) expresados explícitamente en las 
  /// interfaces implementadas por el supertipo PageModel. Por esta razón AllocateModel no se ve forzada a implementar tipos que no utiliza. 
  /// Las interfaces implementadas aseguran el funcionamiento del controlador.
  ///
  /// OCP - PageModel está abierta a la extensión y cerrada a la modificación porque pudimos extenderla con AllocateModel sin necesidad 
  /// de modificarla.
  ///   
  /// LSP -  PageModel se puede sustituir por su subtipo AllocateModel, ya que extiende el comportamiento de PageModel, respetando los
  /// tipos en PageModel, sin modificar su comportamiento. User.IsInRole(IdentityData.NonAdminRoleNames[0]) aca se puede ver un ejemplo 
  /// donde ya sea un Client o un ApplicationUser el tipo del usuario logeado, la expresión funciona igual.
  /// </summary>

namespace Linked.Pages.Projects{
    public class AllocateModel : PageModel{
        private readonly Linked.Areas.Identity.Data.IdentityContext _context;

        public AllocateModel(Linked.Areas.Identity.Data.IdentityContext context){
            _context = context;
        }

        public Project Project { get; set; }
        public ApplicationUser currentUser { get; set; }

        public Technician TechnicianSelected {get; set;}
        public IList<Technician> Technicians {get;set;}
        public IList<Technician> TechniciansAlternativos {get;set;}
        public IList<Technician> InterestedTechnicians {get;set;}
        public IList<Technician> CurrentTechnicians {get;set;}
        
        public async Task<IActionResult> OnGetAsync(string id){
            if (id == null){ return NotFound(); }
            Project = await _context.Project.FindAsync(id);
            if (Project == null){ return NotFound(); }

            List<Technician> curTec = new List<Technician>();
            foreach(Employ e in _context.Employ.Where( emp => emp.ProjectID == Project.ProjectID)){
                curTec.Add(_context.Technician.Find( e.TechnicianID ));
            }

            CurrentTechnicians = curTec;

            Technicians = LoadTechnicians();
            TechniciansAlternativos = LoadTechniciansAlternativos();
            InterestedTechnicians = LoadInterestedTechnicians();
            
            return Page();
        }

        public IList<Technician> LoadTechnicians(){
            List<Technician> reqTec = new List<Technician>();
            try{
                foreach(Requirement required in _context.Requirement.Where(i => i.ProjectID == Project.ProjectID)){
                    foreach(Technician posTec in _context.Technician.Where(t => t.Specialty == required.Specialty)){
                        if(posTec.Level == required.Level && !CurrentTechnicians.Contains(posTec)){
                            reqTec.Add(posTec);
                        }
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Exception ocurred while getting the required technicians: "+e);
            }
            return reqTec;
        }
        
        public IList<Technician> LoadTechniciansAlternativos(){
            List<Technician> altTec = new List<Technician>();
            try{
                foreach(Requirement required in _context.Requirement.Where(i => i.ProjectID == Project.ProjectID)){
                    foreach(Technician posTec in _context.Technician.Where(t => t.Specialty == required.Specialty)){
                        if(posTec.Level != required.Level && !CurrentTechnicians.Contains(posTec)){
                            altTec.Add(posTec);
                        }
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Exception ocurred while getting the alternative technicians: "+e);
            }
            return altTec;
        }

        public IList<Technician> LoadInterestedTechnicians(){
            IList<Technician> intTec = new List<Technician>();
            try{
                foreach(Interest interest in _context.Interest.Where(i => i.ProjectID == Project.ProjectID)){
                    foreach (Technician posTec in _context.Technician.Where(t => t.TechnicianID == interest.TechnicianID)){
                        if(!CurrentTechnicians.Contains(posTec)){
                            intTec.Add(posTec);
                        }
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Exception ocurred while getting the interested technicians: "+e);
            }
            return intTec;
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null){return NotFound();}
            Project = await _context.Project.FindAsync(id);
            if (Project == null){return NotFound();}

            string ParsedTechId = Request.Form["TechnicianID"];
            if (ParsedTechId == null){return NotFound();}
            TechnicianSelected = await _context.Technician.FindAsync(ParsedTechId);
            if (TechnicianSelected == null){return NotFound();}

            AllocateTechnician(id, ParsedTechId);
            
            if(User.IsInRole(IdentityData.NonAdminRoleNames[0])){
                return RedirectToPage("../ClientLayout/MyProjects");
            }

            return RedirectToPage("./Index");
        }
        public async void AllocateTechnician(string id, string techid)
        {
            Employ NewEmploy = new Employ();
            NewEmploy.TechnicianID = techid;
            NewEmploy.ProjectID = id;
            _context.Employ.Add(NewEmploy);
            await _context.SaveChangesAsync();
        }
    }
}       