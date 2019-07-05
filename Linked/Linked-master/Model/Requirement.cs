using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

   /// <summary>
   /// El modelo de esta aplicación representa datos con respecto a distintos proyectos y sus participantes.
   /// Esto es una aproximación virtual de los participantes y elementos asociados a un proyecto.
   /// Este modelo es la pieza que representa el estado y el comportamiento de bajo nivel (getters y setters) de la aplicaciòn.
   /// El modelo no tiene conocimiento específico sobre ningún controlador o vista.
   /// 
   /// Su propósito es contener la información de los requerimientos (Specialty, Level y Hourload) de un proyecto. 
   /// Entre la clase Project y Requirement se da una relacion de one-to-many.
   ///
   /// Colaboradores: Project, Specialty, Level
   ///
   /// Principios:
   ///
   /// SRP- La única razón de cambio para esta clase son cambios en la representación en el vínculo entre Project
   ///  y los requerimientos mencionados anteriormente. Un ejemplo
   /// para modificar esta clase puede ser agregar más información a la representación del vínculo.
   /// </summary>

namespace Linked.Models{
    public class Requirement{
        public string RequirementID { get; set; }
        public string  ProjectID { get; set; }
        [Required]
        public Project Project { get; set; }
        [Required]
        public Specialty Specialty { get; set; }
        [Required]
        public Level Level { get; set; }
        [Required]
        public int Hourload { get; set; }
    }
}