using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesLinked.Models
{
    public class LinkedUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool ApprovedStatus { get; set; }
    }
}