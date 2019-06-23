using System;
using System.Collections.Generic;
using Linked.Areas.Identity.Data;

namespace Linked.Models{
    public class Client : ApplicationUser{
        public string ClientID { get{ return this.Id; } }
        public IList<Project> Projects { get; set; }
    }   
}