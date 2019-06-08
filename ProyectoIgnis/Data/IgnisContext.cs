using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoIgnis.Models;

namespace ProyectoIgnis.Models
{
    public class IgnisContext : DbContext
    {
        public IgnisContext (DbContextOptions<IgnisContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Project { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Technician> Technician { get; set; }

        public DbSet<ProyectoIgnis.Models.ProjectAllocated> ProjectAllocated { get; set; }
    }
}
