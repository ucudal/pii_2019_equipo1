using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

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
        //[DefaultValue(false)]
        //public bool Fulfilled { get; set; }
        //hacer las migrations denuevo para agregar este campo
    }
}