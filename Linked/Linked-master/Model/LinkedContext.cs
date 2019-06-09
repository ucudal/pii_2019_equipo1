using Microsoft.EntityFrameworkCore;
using Linked.Models;

namespace Linked.Models
{
    public class LinkedContext : DbContext
    {
        public LinkedContext (DbContextOptions<LinkedContext> options)
            : base(options){
        }

        //public DbSet<Linked.Models.FeedBack> FeedBack { get; set; }
        
        public DbSet<Linked.Models.Project> Project { get; set; }
        public DbSet<Linked.Models.Technician> Technician { get; set; }
        public DbSet<Linked.Models.ScoreSheet> ScoreSheet { get; set; }
        public DbSet<Linked.Models.Client> Client { get; set; }
        
        public DbSet<Employ> Employ { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employ>().ToTable("Employ")
                .HasKey(e => new { e.TechnicianID, e.ProjectID });
            
            modelBuilder.Entity<FeedBack>().ToTable("FeedBack")
                .HasKey(f => new { f.TechnicianID, f.ScoreSheetID});
        }
    }
}