using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Linked.Models{
    public class ScoreSheet{
        public string ScoreSheetID { get; set; }


        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        [Required, Range(0, 10, ErrorMessage = "Can only be between 0 .. 10"), StringLength(2, ErrorMessage = "Max 2 digits")]
        public int Puntualidad{ get; set; }


        [Required, Range(0, 10, ErrorMessage = "Can only be between 0 .. 10"), StringLength(2, ErrorMessage = "Max 2 digits")]
        public int Respeto {get; set; }


        [Required, Range(0, 10, ErrorMessage = "Can only be between 0 .. 10"), StringLength(2, ErrorMessage = "Max 2 digits")]
        public int Formalidad{ get; set; }


        [Required, Range(0, 10, ErrorMessage = "Can only be between 0 .. 10"), StringLength(2, ErrorMessage = "Max 2 digits")]
        public int Profesionalismo{ get; set; }


        [Required, Range(0, 10, ErrorMessage = "Can only be between 0 .. 10"), StringLength(2, ErrorMessage = "Max 2 digits")]
        public int Compromiso{ get; set; }


        public int Score { get{ return (Compromiso+Puntualidad+Formalidad+Respeto+Profesionalismo)/5; } }


        public FeedBack FeedBack { get; set; }
    } 
}