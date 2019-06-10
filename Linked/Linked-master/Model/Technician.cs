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
        public DateTime Birthday { get; set; }
        
        public Role Role { get; set; }
        public Level Level { get; set; }

        public List<FeedBack> FeedBacks { get; set; } //Feedbacks
        public List<Employ> Employers { get; set; } //Projects
    }   
}