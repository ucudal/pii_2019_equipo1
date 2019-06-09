using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Linked.Models{

    public class User{
        public int UserID { get; set; }
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public List<FeedBack> FeedBacks { get; set; }
    }   
}