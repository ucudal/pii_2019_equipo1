using Microsoft.EntityFrameworkCore;

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
        public DbSet<RazorPagesLinked.Models.LinkedUser> LinkedUser { get; set; }
    }
}