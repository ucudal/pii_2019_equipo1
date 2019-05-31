using Microsoft.EntityFrameworkCore;
using RazorPagesLinked.Models;

namespace RazorPagesLinked.Models
{
    public class RazorPagesLinkedContext : DbContext
    {
        public RazorPagesLinkedContext (DbContextOptions<RazorPagesLinkedContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesLinked.Models.Role> Role { get; set; }
        public DbSet<RazorPagesLinked.Models.FeedBackItem> FeedBackItem { get; set; }
        public DbSet<RazorPagesLinked.Models.FeedBackItem> FeedBack { get; set; }
        public DbSet<RazorPagesLinked.Models.FeedBack> FeedBack_1 { get; set; }
    }
}