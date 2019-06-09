using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Linked.Models{

    public class Project{
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool CompletionStatus {get; set;}
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public Role Role{ get; set; }
        //public Role Role;
        public Level Level{ get; set; }
        //public Level Level;
        
        public IList<Employ> Employees { get; set; } // Technicians

        public int ClientID { get; set; } 
        public Client Client { get; set; }
    }   
}