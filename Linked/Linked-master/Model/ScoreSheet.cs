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

        public int Puntualidad{ get; set; }
        public int Respeto{ get; set; }
        public int Formalidad{ get; set; }
        public int Profesionalismo{ get; set; }
        public int Compromiso{ get; set; }
        public int Score {get{return (Compromiso+Puntualidad+Formalidad+Respeto+Profesionalismo)/5;}}

        public FeedBack FeedBack { get; set; }
    } 
}