using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Linked.Areas.Identity.Data;

namespace Linked.Models{

    public class Technician : Person
    {
        public int TechnicianID { get; set; }
        
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/2/1900", "3/4/2010",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime Birthday { get; set; }
        
        public Role Role { get; set; }
        public Level Level { get; set; }

        public List<FeedBack> FeedBacks { get; set; } //Feedbacks
        public List<Employ> Employers { get; set; } //Projects
    }   
}