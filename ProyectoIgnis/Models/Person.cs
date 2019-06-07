using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoIgnis.Models
{
    // Intento crear "herencia multiple" para que role sea base de technician
    public abstract class Person 
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public string LastName {get; set;}
        public string MailAdress {get; set;}

    }
}