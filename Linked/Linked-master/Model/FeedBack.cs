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
        public int ProjectID { get; set; }
        public Project Project { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int ScoreSheetID { get; set; }
        public ScoreSheet ScoreSheet { get; set; }
    }
}