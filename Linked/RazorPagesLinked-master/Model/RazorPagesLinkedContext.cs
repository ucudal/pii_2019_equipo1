using Microsoft.EntityFrameworkCore;

namespace RazorPagesLinked.Models
{
    public class RazorPagesLinkedContext : DbContext
    {
        public RazorPagesLinkedContext (DbContextOptions<RazorPagesLinkedContext> options)
            : base(options)
        {
        }

        //public DbSet<RazorPagesLinked.Models.Linked> Linked { get; set; }
    }
}