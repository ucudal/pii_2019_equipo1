using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProyectoIgnis.Models
{
    public class Client : Person
    {
        public IList<Project> Projects = new List<Project>();

    }
}