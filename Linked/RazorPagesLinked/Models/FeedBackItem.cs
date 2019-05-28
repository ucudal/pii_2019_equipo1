using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesLinked.Models
{
    public class FeedBackItem
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public int Score { get; set; }
    }
}