using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Linked.Models{
    public class Employ{
        [Key]
        public int TechnicianID { get; set; }

        [Key]
        public int  ProjectID { get; set; }

        [Required]
        public Technician Technician { get; set; }

        [Required]
        public Project Project { get; set; }
    }
}