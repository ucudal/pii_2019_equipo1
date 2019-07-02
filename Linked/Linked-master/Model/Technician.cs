using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Linked.Areas.Identity.Data;


namespace Linked.Models{

    public class Technician : ApplicationUser{
        public string TechnicianID { get{return this.Id;}}
        
        [DataType(DataType.Date), Range(typeof(DateTime),"3/4/2010","1/2/1900", ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime Birthday { get {return this.DOB;} }
        
        public Specialty Specialty { get; set; }
        public Level Level { get; set; }

        public List<Employ> Employers { get; set; } //Projects
        public IList<Interest> InterestingProjects { get; set; } // Interesting Projects
    }   
}