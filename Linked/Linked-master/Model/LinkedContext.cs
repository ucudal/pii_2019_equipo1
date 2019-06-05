using Microsoft.EntityFrameworkCore;

namespace Linked.Models
{
    public class LinkedContext : DbContext
    {
        public LinkedContext (DbContextOptions<LinkedContext> options)
            : base(options)
        {
        }

        //public DbSet<Linked.Models.Linked> Linked { get; set; }
    }
}