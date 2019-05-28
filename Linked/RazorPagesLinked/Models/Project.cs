using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace RazorPagesLinked.Models
{
    public class Project
    {
        public int ID { get; set; }
        public int HourLoad { get; set; }
        public bool ApprovedStatus { get; set; }
        public bool CompletionStatus {get; set;}
        public List<Role> RequiredRoles { get; set; }
        private Compensation Compensation01;
        private FeedBack Feed01;
        //Esta clase tiene un objeto cliente que no ha sido implementado
        //Esta clase tiene una lista de techinician que no ha sido implementada

    }
}