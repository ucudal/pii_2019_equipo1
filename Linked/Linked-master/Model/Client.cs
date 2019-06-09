using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Linked.Models{
    public class Client{
        public int ClientID { get; set; }
        public string Name { get; set; }

        public IList<Project> Projects { get; set; }
    }   
}