using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linked.Models{
    public class FeedBack{
        [Key]
        public string TechnicianID { get; set; }
        [Required]
        public Technician Technician { get; set; }
        [Key]
        public string ScoreSheetID { get; set; }
        [Required]
        public ScoreSheet ScoreSheet { get; set; }
    }
}