using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linked.Models{
    public class Interest{
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