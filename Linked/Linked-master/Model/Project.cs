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
        
        [DataType(DataType.Date)] 
        public DateTime Date { get; set; }

        public List<FeedBack> FeedBacks { get; set; }
    }   
}