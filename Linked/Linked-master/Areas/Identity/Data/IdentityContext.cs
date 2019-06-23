using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Linked.Areas.Identity.Data;
using Linked.Models;

namespace Linked.Areas.Identity.Data
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
        }
        
        public DbSet<Linked.Models.Project> Project { get; set; }
        public DbSet<Linked.Models.Technician> Technician { get; set; }
        public DbSet<Linked.Models.ScoreSheet> ScoreSheet { get; set; }
        public DbSet<Linked.Models.Client> Client { get; set; }
        public DbSet<Linked.Models.Requirement> Requirement { get; set; }
        
        public DbSet<Employ> Employ { get; set; }
        public DbSet<Interest> Interest { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employ>().ToTable("Employ")
                .HasKey(e => new { e.TechnicianID, e.ProjectID });
            
            modelBuilder.Entity<FeedBack>().ToTable("FeedBack")
                .HasKey(f => new { f.TechnicianID, f.ScoreSheetID});
            
            modelBuilder.Entity<Interest>().ToTable("Interest")
                .HasKey(g => new { g.TechnicianID, g.ProjectID});
            
            modelBuilder.Entity<Requirement>().ToTable("Requirement")
                .HasOne(h => new { h.ProjectID });
        }
    }
}
