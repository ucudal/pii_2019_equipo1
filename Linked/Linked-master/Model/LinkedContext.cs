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
        public DbSet<Linked.Models.User> User { get; set; }
        public DbSet<Linked.Models.ScoreSheet> ScoreSheet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<FeedBack>()
                .HasKey(fb => new { fb.ProjectID, fb.UserID, fb.ScoreSheetID });
            
            modelBuilder.Entity<FeedBack>()
                .HasOne(pt => pt.Project)
                .WithMany(p => p.FeedBacks)
                .HasForeignKey(pt => pt.ProjectID); 

            modelBuilder.Entity<FeedBack>()
                .HasOne(pt => pt.User)
                .WithMany(t => t.FeedBacks)
                .HasForeignKey(pt => pt.UserID);
            
            modelBuilder.Entity<FeedBack>()
                .HasOne(pt => pt.ScoreSheet)
                .WithOne(s => s.FeedBack);
                //.HasForeignKey(pt => pt.ScoreSheetID);
        }

        public DbSet<Linked.Models.FeedBack> FeedBack { get; set; }
    }
}