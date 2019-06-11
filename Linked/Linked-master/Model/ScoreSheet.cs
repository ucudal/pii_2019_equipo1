using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linked.Models{
    public class ScoreSheet{
        public int ScoreSheetID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Range(0, 10, ErrorMessage = "Can only be between 0 .. 10")]
        [StringLength(2, ErrorMessage = "Max 2 digits")]
        [Required]
        public int Puntualidad{ get; set; }

        [Range(0, 10, ErrorMessage = "Can only be between 0 .. 10")]
        [StringLength(2, ErrorMessage = "Max 2 digits")]
        [Required]
        public int Respeto {get; set; }

        [Range(0, 10, ErrorMessage = "Can only be between 0 .. 10")]
        [StringLength(2, ErrorMessage = "Max 2 digits")]
        [Required]
        public int Formalidad{ get; set; }

        [Range(0, 10, ErrorMessage = "Can only be between 0 .. 10")]
        [StringLength(2, ErrorMessage = "Max 2 digits")]
        [Required]
        public int Profesionalismo{ get; set; }

        [Range(0, 10, ErrorMessage = "Can only be between 0 .. 10")]
        [StringLength(2, ErrorMessage = "Max 2 digits")]
        [Required]
        public int Compromiso{ get; set; }
        public int Score {get{return (Compromiso+Puntualidad+Formalidad+Respeto+Profesionalismo)/5;}}
        public FeedBack FeedBack { get; set; }
    } 
}