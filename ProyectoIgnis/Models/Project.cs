using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoIgnis.Models
{
    public class Project : IProject
    {
        public int ID { get; set; }
        public int HourLoad {get; set;}
        // Conocer compensation
        //Conocer feedback
        //public bool ApprovedStatus {get; set;}
        //public bool CompletionStatus {get; set;}
        public string Description {get; set;}
        public string Client {get; set;}
        public string Level {get; set;}
        public string Role {get; set;}

    }
}