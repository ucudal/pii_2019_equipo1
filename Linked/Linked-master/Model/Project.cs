using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
    
   /// <summary>
   ///
   /// El modelo de esta aplicación representa datos con respecto a distintos proyectos y sus participantes.
   /// Esto es una aproximación virtual de los participantes y elementos asociados a un proyecto.
   /// Este modelo es la pieza que representa el estado y el comportamiento de bajo nivel (getters y setters) de la aplicaciòn.
   /// El modelo no tiene conocimiento específico sobre ningún controlador o vista.
   ///
   /// Su propósito es contener la información de un proyecto. Esta es una clase de alto nivel que colabora con clases de menor nivel, 
   ///
   /// Colaboradores: Client, Employ, Interest, Requirement. Cada instancia de Project está compuesta por un Client, una lista de Employees,
   /// una lista de InterestedTechnicians y de Requirements.
   ///
   /// Alta cohesión: la información almacenada en la clase es coherente y está relacionada entre sí.
   ///
   /// Principios:
   ///
   /// SRP- La única razón de cambio para esta clase es para modificar la información personalizada de Project.
   /// Esto es así porque todos los atributos de las instancias de Project tienen el único propósito de representar información.
   ///
   /// ISP- Project no implementa ninguna interfaz que no utilice completamente.
   ///
   /// </summary>

namespace Linked.Models{

    public class Project{
        public string ProjectID { get; set; }

        
        [Required, StringLength(50, MinimumLength = 3), RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Title { get; set; }


        [Required, StringLength(150, MinimumLength = 3), RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Description { get; set; }
        

        public bool CompletionStatus {get; set;}

        
        [Display(Name = "Date"), DataType(DataType.Date)]
        public DateTime Date { get; set; }

        
        public IList<Employ> Employees { get; set; } // Technicians
        public IList<Interest> InterestedTechnicians { get; set; } // Interested Technicians
        public IList<Requirement> Requirements { get; set; } // Required Technicians


        public string ClientID { get; set; } 
        public Client Client { get; set; }
    }   
}