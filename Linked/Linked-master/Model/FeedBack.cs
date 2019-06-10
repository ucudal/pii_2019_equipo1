using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Linked.Areas.Identity.Data;

namespace Linked.Models{
    public class FeedBack{
        public int TechnicianID { get; set; }
        public Technician Technician { get; set; }
        public int ScoreSheetID { get; set; }
        public ScoreSheet ScoreSheet { get; set; }
    }
}