using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Linked.Models{
    public static class SeedData{
        public static void Initialize(IServiceProvider serviceProvider){

            using (var context = new LinkedContext(serviceProvider.GetRequiredService<DbContextOptions<LinkedContext>>())){

                if (context.Project.Any()){
                    return;   // DB has been seeded
                };

                var Clients = new Client[]{
                    new Client {Name = "Universidad Católica del Uruguay"},
                    new Client {Name = "ESPN"},
                    new Client {Name = "DreamWorks"},
                    new Client {Name = "Universidad de la República"},
                    new Client {Name = "Pixar Studio"},
                    new Client {Name = "Illumination Studios"},
                    new Client {Name = "Centro Ignis Marketing"},
                    new Client {Name = "Passanger Band"}
                };

                foreach (Client c in Clients){
                    context.Client.Add(c);
                };
                context.SaveChanges();

                var Projects = new Project[]{
                    new Project { Title = "Reclame UCU Enseña", Date = DateTime.Parse("2019-02-01"), 
                    Role = Role.Director, Level = Level.Avanzado, ClientID = 1, Description = "Reclame de 5 minutos", CompletionStatus = false},
                    new Project { Title = "Propaganda Copa América", Date = DateTime.Parse("2019-03-02"),
                    Role = Role.Actor, Level = Level.Básico, ClientID = 2, Description = "Titulares y Highlights de la Copa 2015", CompletionStatus = false},
                    new Project { Title = "Kung Fu Panda 5", Date = DateTime.Parse("2019-07-03"),
                    Role = Role.Camarógrafo, Level = Level.Intermedio, ClientID = 3, Description = "Trailer de la nueva Película", CompletionStatus = false},
                    new Project { Title = "Open Fing Clases", Date = DateTime.Parse("2019-11-04"),
                    Role = Role.Sonidista, Level = Level.Profesional, ClientID = 4, Description = "Grabar Curso 779283 completo ", CompletionStatus = false},
                    new Project { Title = "Toy Story 5", Date = DateTime.Parse("2019-12-05"),
                    Role = Role.Director, Level = Level.Intermedio, ClientID = 5, Description = "Trailer de la Nueva Pelicula de Pixar", CompletionStatus = false},
                    new Project { Title = "Mi Villano Favorito", Date = DateTime.Parse("2019-10-04"),
                    Role = Role.Director, Level = Level.Intermedio, ClientID = 6, Description = "Mindstorming de la nueva Película", CompletionStatus = false},
                    new Project { Title = "Podcast con Alumnos", Date = DateTime.Parse("2019-04-06"),
                    Role = Role.Camarógrafo, Level = Level.Básico, ClientID = 7, Description = "Entrevistas casuales acerca de la vida estudiantil en UCU", CompletionStatus = true},
                    new Project { Title = "VideoClip Musical Survivors", Date = DateTime.Parse("2019-09-07"),
                    Role = Role.Actor, Level = Level.Avanzado, ClientID = 8, Description = "Filmar el nuevo videoclip para Survivors", CompletionStatus = false},
                };

                foreach (Project p in Projects){
                    context.Project.Add(p);
                };
                context.SaveChanges();

                var Technicians = new Technician[]{
                    new Technician { Name = "Rodolfo Martinez", Birthday = DateTime.Parse("2000-05-01"), 
                    Role = Role.Director, Level = Level.Avanzado},
                    new Technician { Name = "Sergio Pérez", Birthday = DateTime.Parse("1986-07-02"), 
                    Role = Role.Camarógrafo, Level = Level.Profesional},
                    new Technician { Name = "Camila Fernández", Birthday = DateTime.Parse("1974-08-03"), 
                    Role = Role.Sonidista, Level = Level.Básico},
                    new Technician { Name = "Lorena Vásquez", Birthday = DateTime.Parse("1963-05-04"), 
                    Role = Role.Director, Level = Level.Avanzado},
                    new Technician { Name = "Rodrigo Kan", Birthday = DateTime.Parse("1995-04-05"), 
                    Role = Role.Fotógrafo, Level = Level.Intermedio},
                    new Technician { Name = "James Cameron", Birthday = DateTime.Parse("1956-03-06"), 
                    Role = Role.Sonidista, Level = Level.Básico},
                    new Technician { Name = "Ignacio Sica", Birthday = DateTime.Parse("1999-07-07"), 
                    Role = Role.Fotógrafo, Level = Level.Profesional},
                    new Technician { Name = "Martin Perdomo", Birthday = DateTime.Parse("1983-11-08"), 
                    Role = Role.Actor, Level = Level.Básico},

                    new Technician { Name = "Matías Drully", Birthday = DateTime.Parse("1987-12-30"), 
                    Role = Role.Director, Level = Level.Intermedio},
                    new Technician { Name = "Federico Shenak", Birthday = DateTime.Parse("1989-05-06"), 
                    Role = Role.Sonidista, Level = Level.Avanzado},
                    new Technician { Name = "Agustina Molares", Birthday = DateTime.Parse("1988-09-30"), 
                    Role = Role.Fotógrafo, Level = Level.Básico},
                    new Technician { Name = "Sofía Letica", Birthday = DateTime.Parse("1968-09-27"), 
                    Role = Role.Sonidista, Level = Level.Avanzado},
                    new Technician { Name = "Valeria Sollier", Birthday = DateTime.Parse("1978-01-18"), 
                    Role = Role.Fotógrafo, Level = Level.Profesional},
                    new Technician { Name = "Miguel Bonapartere", Birthday = DateTime.Parse("1985-09-29"), 
                    Role = Role.Sonidista, Level = Level.Básico},
                    new Technician { Name = "Felipe Ayala", Birthday = DateTime.Parse("1978-11-17"), 
                    Role = Role.Sonidista, Level = Level.Intermedio},
                    new Technician { Name = "Lucía Cuadran", Birthday = DateTime.Parse("1968-10-09"), 
                    Role = Role.Actor, Level = Level.Intermedio},
                    new Technician { Name = "Shakira Llambí", Birthday = DateTime.Parse("1947-10-09"), 
                    Role = Role.Actor, Level = Level.Profesional},
                    new Technician { Name = "Luis Suarez", Birthday = DateTime.Parse("1989-11-05"), 
                    Role = Role.Director, Level = Level.Básico},
                    new Technician { Name = "Lewis Hamilton", Birthday = DateTime.Parse("1999-06-16"), 
                    Role = Role.Fotógrafo, Level = Level.Avanzado},
                    new Technician { Name = "Sebastian Vettel", Birthday = DateTime.Parse("1979-08-17"), 
                    Role = Role.Fotógrafo, Level = Level.Intermedio},
                    new Technician { Name = "Cristiano Ronaldo", Birthday = DateTime.Parse("1998-07-19"), 
                    Role = Role.Actor, Level = Level.Profesional},
                    new Technician { Name = "Eduardo Nomake", Birthday = DateTime.Parse("1967-08-18"), 
                    Role = Role.Sonidista, Level = Level.Básico},
                    new Technician { Name = "Tessa Buonarroti", Birthday = DateTime.Parse("1986-12-24"), 
                    Role = Role.Actor, Level = Level.Profesional},
                    new Technician { Name = "Clara Ipha", Birthday = DateTime.Parse("1986-05-30"), 
                    Role = Role.Director, Level = Level.Profesional}
                };

                foreach (Technician t in Technicians){
                    context.Technician.Add(t);
                };
                context.SaveChanges();

                var ScoreSheets = new ScoreSheet[]{
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 2,Puntualidad = 8,Formalidad = 9,Respeto = 9,Profesionalismo = 8},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 3,Puntualidad = 5,Formalidad = 8,Respeto = 9,Profesionalismo = 6},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 5,Puntualidad = 1,Formalidad = 6,Respeto = 8,Profesionalismo = 5},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 5,Puntualidad = 2,Formalidad = 5,Respeto = 8,Profesionalismo = 5},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 9,Puntualidad = 3,Formalidad = 4,Respeto = 9,Profesionalismo = 3},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 5,Puntualidad = 3,Formalidad = 2,Respeto = 7,Profesionalismo = 7},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 4,Puntualidad = 9,Formalidad = 4,Respeto = 8,Profesionalismo = 8},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 2,Puntualidad = 8,Formalidad = 2,Respeto = 9,Profesionalismo = 9},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 1,Puntualidad = 7,Formalidad = 6,Respeto = 7,Profesionalismo = 2},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 3,Puntualidad = 8,Formalidad = 8,Respeto = 8,Profesionalismo = 3},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 5,Puntualidad = 4,Formalidad = 7,Respeto = 7,Profesionalismo = 7},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 6,Puntualidad = 5,Formalidad = 7,Respeto = 9,Profesionalismo = 8},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 8,Puntualidad = 8,Formalidad = 7,Respeto = 9,Profesionalismo = 8},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 9,Puntualidad = 5,Formalidad = 9,Respeto = 9,Profesionalismo = 7},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 4,Puntualidad = 1,Formalidad = 9,Respeto = 8,Profesionalismo = 7},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 5,Puntualidad = 2,Formalidad = 5,Respeto = 8,Profesionalismo = 8},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 6,Puntualidad = 3,Formalidad = 6,Respeto = 9,Profesionalismo = 9},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 3,Puntualidad = 3,Formalidad = 6,Respeto = 7,Profesionalismo = 9},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 2,Puntualidad = 9,Formalidad = 4,Respeto = 8,Profesionalismo = 6},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 1,Puntualidad = 8,Formalidad = 2,Respeto = 9,Profesionalismo = 5},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 5,Puntualidad = 7,Formalidad = 1,Respeto = 7,Profesionalismo = 2},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 9,Puntualidad = 8,Formalidad = 2,Respeto = 8,Profesionalismo = 1},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 9,Puntualidad = 4,Formalidad = 4,Respeto = 7,Profesionalismo = 6},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 8,Puntualidad = 5,Formalidad = 3,Respeto = 9,Profesionalismo = 3},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 9,Puntualidad = 6,Formalidad = 6,Respeto = 8,Profesionalismo = 9}
                };

                foreach (ScoreSheet sc in ScoreSheets){
                    context.ScoreSheet.Add(sc);
                };
                context.SaveChanges();

                var Employs = new Employ[]{

                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 1).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 1).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 1).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 2).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 1).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 6).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 2).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 1).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 3).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 3).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 4).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 3).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 5).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 3).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 6).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 2).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 7).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 1).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 5).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 7).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 5).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 6).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 4).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 6).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 2).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 4).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 2).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 5).ProjectID
                    },

                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 8).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 1).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 8).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 2).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 8).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 3).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 9).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 1).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 9).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 3).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 9).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 5).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 10).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 5).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 10).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 6).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 11).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 4).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 11).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 3).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 12).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 2).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 12).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 1).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 15).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 1).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 15).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 6).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 14).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 7).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 14).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 6).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 13).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 4).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 13).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 5).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 18).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 3).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 17).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 2).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 19).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 1).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 20).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 2).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 22).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 6).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 23).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 5).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 22).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 5).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 21).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 1).ProjectID
                    },
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.TechnicianID == 21).TechnicianID,
                        ProjectID = context.Project.Single(p => p.ProjectID == 2).ProjectID
                    }
                };

                foreach (Employ e in Employs){
                    context.Employ.Add(e);
                }
                context.SaveChanges();

                var FeedBacks = new FeedBack[]{
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 1).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 1).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 2).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 2).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 3).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 3).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 4).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 4).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 5).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 4).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 6).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 4).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 7).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 7).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 8).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 5).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 9).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 5).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 10).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 1).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 11).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 6).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 12).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 2).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 13).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 10).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 14).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 10).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 15).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 8).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 16).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 8).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 17).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 15).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 18).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 16).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 19).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 16).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 20).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 5).TechnicianID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 21).ScoreSheetID,
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 18).TechnicianID}
                };

                foreach (FeedBack f in FeedBacks){
                    context.FeedBack.Add(f);
                };
                context.SaveChanges();
            }
        }
    }
}