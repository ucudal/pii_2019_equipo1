using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Linked.Areas.Identity.Data;

namespace Linked.Models{
    public class Client : ApplicationUser
    {
        public string ClientID { get; set; }
        public IList<Project> Projects { get; set; }
    }   
}