using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;
using Linked.Areas.Identity.Data;
using Linked.Models;

namespace Linked.Tests
{
    public static class SeedTestData
    {
        public static void Initialize(IdentityContext context)
        {
            SeedClients(context);
            SeedTechnicians(context);
            SeedProjects(context);
            //SeedEmploys(context);

        }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IdentityContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<IdentityContext>>()))
            {
                SeedClients(context);

            }
        }

        private static void SeedClients(IdentityContext context)
        {
            // Look for any movies.
            if (context.Client.Any())
            {
                return;   // DB has been seeded
            }

            context.Client.AddRange(GetSeedingClients());
            context.SaveChanges();
        }

        public static List<Client> GetSeedingClients()
        {
            return new List<Client>()
            {
                new Client
                {
                    Name = "TestClient",
                    Id="c1"
                },

                new Client
                {
                    Name = "TestClient2",
                    Id="c2"
                },
            };
        }

        private static void SeedTechnicians(IdentityContext context)
        {
            // Look for any movies.
            if (context.Technician.Any())
            {
                return;   // DB has been seeded
            }

            context.Technician.AddRange(GetSeedingTechnicians());
            context.SaveChanges();
        }

        public static List<Technician> GetSeedingTechnicians()
        {
            return new List<Technician>()
            {
                new Technician
                {
                    Name = "TestTechnician",
                    Specialty = Specialty.Director,
                    Level = Level.Avanzado,
                    Id="t1"
                },

                new Technician
                {
                    Name = "TestTechnician2",
                    Specialty = Specialty.Sonidista,
                    Level = Level.Básico,
                    Id="t2"
                },
            };
        }

        private static void SeedProjects(IdentityContext context)
        {
            // Look for any movies.
            if (context.Project.Any())
            {
                return;   // DB has been seeded
            }

            context.Project.AddRange(GetSeedingProjects());
            context.SaveChanges();
        }

        public static List<Project> GetSeedingProjects()
        {
            return new List<Project>()
            {
                new Project
                {
                    Title = "TestProject",
                    ProjectID="p1",
                    Description="des1"
                },

                new Project
                {
                    Title = "TestProject2",
                    ProjectID="p2",
                    Description="des2"
                },
            };
        }

        private static void SeedEmploys(IdentityContext context)
        {
            // Look for any movies.
            if (context.Employ.Any())
            {
                return;   // DB has been seeded
            }

            context.Employ.AddRange(GetSeedingEmploys());
            context.SaveChanges();
        }

        public static List<Employ> GetSeedingEmploys()
        {
            return new List<Employ>()
            {
                new Employ
                {
                    Project = GetSeedingProjects()[0],
                    Technician=GetSeedingTechnicians()[0],               
                },
            };
        }


    }
}