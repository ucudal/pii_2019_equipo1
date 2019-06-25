using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Linked.Models{

    public class Project{
        public string ProjectID { get; set; }

        
        [Required, StringLength(50, MinimumLength = 3), RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Title { get; set; }


        [Required, StringLength(150, MinimumLength = 3), RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Description { get; set; }
        

        public bool CompletionStatus {get; set;}

        
        [Display(Name = "Date"), DataType(DataType.Date)]
        public DateTime Date { get; set; }

        
        public IList<Employ> Employees { get; set; } // Technicians
        public IList<Interest> InterestedTechnicians { get; set; } // Interested Technicians
        public IList<Requirement> Requirements { get; set; } // Required Technicians


        public string ClientID { get; set; } 
        public Client Client { get; set; }
    }   
}