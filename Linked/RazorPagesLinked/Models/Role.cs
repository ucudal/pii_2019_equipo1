using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesLinked.Models
{
    public class Role
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
    }
}