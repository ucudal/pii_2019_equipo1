using System;
using System.ComponentModel.DataAnnotations;
namespace RazorPagesLinked.Models
{
    public class Compensation
    {
        public int ID { get; set; }
        private int totalcompensation ;

        public int TotalCompensation 
        {
            get
            {   
                //CalculateTotalCompensation()
                return this.totalcompensation;
            }
        }

    }
}