using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace RazorPagesLinked.Models
{
    public class FeedBack
    {
        public int ID { get; set; }
        public List<FeedBackItem> Items { get; set; }
        private int totalscore;

        public int TotalScore 
        {
            get
            {   
                //CalculateScore()
                return this.totalscore;
            }
        }

    }
}