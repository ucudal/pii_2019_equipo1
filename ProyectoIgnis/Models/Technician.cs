using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoIgnis.Models
{
    public class Technician : Person
    {
        public string Level {set; get;}
        public string Role {get; set;}
        
    }
}