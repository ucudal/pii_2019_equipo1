using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Linked.Models{
    public class Person{
        private string name;
        public string Name { 
            get{
                return name;
               }
            set{   
                if(!string.IsNullOrEmpty(value))
                {
                name = value;
                }
         } 
         }

    }   
}