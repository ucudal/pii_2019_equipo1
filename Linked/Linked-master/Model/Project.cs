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

        private string title;

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get{return title;} 
        set{if (!string.IsNullOrEmpty(value))
        {title=value;}
        } 
        }

        private string description;

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Description { get{return description;} 
        set{if (!string.IsNullOrEmpty(value))
        {description=value;}
        } 
        }
        public bool CompletionStatus {get; set;}
        
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