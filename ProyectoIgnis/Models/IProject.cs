using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoIgnis.Models
{
    public interface IProject
    {
        int ID {get; set;}
        int HourLoad {get; set;}
        // Conocer compensation
        //Conocer feedback
        //bool ApprovedStatus {get; set;}
        //bool CompletionStatus {get; set;}
        string Description {get; set;}
        string Client {get; set;}
        string Level {get; set;}

    }
}