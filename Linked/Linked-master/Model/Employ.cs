using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 
    /// Su propósito es la conexión many to many entre Project y Technician. Cada Employ individual representa uno de estos vínculos.
    ///
    /// Colaboradores: Project y Technician. 
    ///
    /// Principios:
    /// 
    /// SRP- La única razón de cambio para esta clase son cambios en la represntación en el vínculo entre Project y Technician. Un ejemplo
    /// para modificar esta clase puede ser agregar mas información a la representación del vínculo.
    /// 
    /// LSP- Employ está abierta a la extensión ya que podría ser la llave entre la relación entre Project y un subtipo de Technician.
    /// 
    /// </summary>

namespace Linked.Models{
    public class Employ{
        [Key]
        public string TechnicianID { get; set; }
        [Key]
        public string  ProjectID { get; set; }
        [Required]
        public Technician Technician { get; set; }
        [Required]
        public Project Project { get; set; }
    }
}