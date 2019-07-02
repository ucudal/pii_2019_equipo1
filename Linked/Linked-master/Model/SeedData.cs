using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Linked.Areas.Identity.Data;

namespace Linked.Models{
    public static class SeedData{
        public static void Initialize(IServiceProvider serviceProvider)
        {
            SeedProjects(serviceProvider);
            SeedEmploys(serviceProvider);           
        }      

            public static void SeedProjects(IServiceProvider serviceProvider)
            {
                using (var context = new IdentityContext(serviceProvider.GetRequiredService<DbContextOptions<IdentityContext>>()))
                {
                    if (context.Project.Any()){
                        return;   // DB has been seeded
                    };

                    var Projects = new Project[]{
                        new Project { Title = "Reclame UCU Enseña", Date = DateTime.Parse("2019-02-01"),
                        Description = "Reclame de 5 minutos",CompletionStatus = false},
                        new Project { Title = "Propaganda Copa América", Date = DateTime.Parse("2019-03-02"),
                        Description = "Titulares y Highlights de la Copa 2015", CompletionStatus = false},
                        new Project { Title = "Kung Fu Panda 5", Date = DateTime.Parse("2019-07-03"),
                        Description = "Trailer de la nueva Película", CompletionStatus = false},
                        new Project { Title = "Open Fing Clases", Date = DateTime.Parse("2019-11-04"),
                        Description = "Grabar Curso 779283 completo ", CompletionStatus = false},
                        new Project { Title = "Toy Story 5", Date = DateTime.Parse("2019-12-05"),
                        Description = "Trailer de la Nueva Pelicula de Pixar", CompletionStatus = false},
                        new Project { Title = "Mi Villano Favorito", Date = DateTime.Parse("2019-10-04"),
                        Description = "Mindstorming de la nueva Película", CompletionStatus = false},
                        new Project { Title = "Podcast con Alumnos", Date = DateTime.Parse("2019-04-06"),
                        Description = "Entrevistas casuales acerca de la vida estudiantil en UCU", CompletionStatus = true},
                        new Project { Title = "VideoClip Musical Survivors", Date = DateTime.Parse("2019-09-07"),
                        Description = "Filmar el nuevo videoclip para Survivors", CompletionStatus = false}
                    };

                    foreach (Project p in Projects){
                        Client query = context.Client
                        .Where(s => s.Name == "ESPN")
                        .FirstOrDefault<Client>();
                        p.Client=query;
                        p.ClientID=query.ClientID;
                        context.Project.Add(p);
                    };
                    context.SaveChanges();

                }
            }

            public static void SeedEmploys(IServiceProvider serviceProvider)
            {
                using (var context = new IdentityContext(serviceProvider.GetRequiredService<DbContextOptions<IdentityContext>>())){

                if (context.Employ.Any()){
                    return;   // DB has been seeded
                };

                Technician QueryTechnician = context.Technician
                    .Where(s => s.Name == "Rodrigo Kan")
                    .FirstOrDefault<Technician>();

                Project QueryProject = context.Project
                    .Where(s => s.Title == "Toy Story 5")
                    .FirstOrDefault<Project>();                

                var Employs = new Employ[]{

                    new Employ{

                        Project=QueryProject,
                        Technician=QueryTechnician,
                        TechnicianID = QueryTechnician.TechnicianID,
                        ProjectID = QueryProject.ProjectID,
                    }
                };

                foreach (Employ e in Employs){
                    
                    context.Employ.Add(e);
                }
                context.SaveChanges();

            }
        }
    }
}
    