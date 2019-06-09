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
                    new Client {Name = "c0"},
                    new Client {Name = "c1"},
                    new Client {Name = "c2"},
                    new Client {Name = "c3"},
                    new Client {Name = "c4"},
                    new Client {Name = "c5"},
                    new Client {Name = "c6"},
                    new Client {Name = "c7"}
                };

                foreach (Client c in Clients){
                    context.Client.Add(c);
                };
                context.SaveChanges();

                var Projects = new Project[]{
                    new Project { Title = "p1", Date = DateTime.Parse("2019-05-01"), 
                    Role = Role.Director, Level = Level.Avanzado, ClientID = 1, Description = "d1", CompletionStatus = false},
                    new Project { Title = "p2", Date = DateTime.Parse("2019-05-02"),
                    Role = Role.Actor, Level = Level.Básico, ClientID = 2, Description = "d2", CompletionStatus = false},
                    new Project { Title = "p3", Date = DateTime.Parse("2019-05-03"),
                    Role = Role.Camarógrafo, Level = Level.Intermedio, ClientID = 3, Description = "d3", CompletionStatus = false},
                    new Project { Title = "p4", Date = DateTime.Parse("2019-05-04"),
                    Role = Role.Sonidista, Level = Level.Profesional, ClientID = 4, Description = "d4", CompletionStatus = false},
                    new Project { Title = "p5", Date = DateTime.Parse("2019-05-05"),
                    Role = Role.Director, Level = Level.Intermedio, ClientID = 5, Description = "d5", CompletionStatus = false},
                    new Project { Title = "p6", Date = DateTime.Parse("2019-05-06"),
                    Role = Role.Camarógrafo, Level = Level.Básico, ClientID = 6, Description = "d6", CompletionStatus = true},
                    new Project { Title = "p7", Date = DateTime.Parse("2019-05-07"),
                    Role = Role.Actor, Level = Level.Avanzado, ClientID = 7, Description = "d7", CompletionStatus = false},
                };

                foreach (Project p in Projects){
                    context.Project.Add(p);
                };
                context.SaveChanges();

                var Technicians = new Technician[]{
                    new Technician { Name = "tec1", Birthday = DateTime.Parse("2000-05-01"), 
                    Role = Role.Director, Level = Level.Avanzado},
                    new Technician { Name = "tec2", Birthday = DateTime.Parse("2000-05-02"), 
                    Role = Role.Camarógrafo, Level = Level.Profesional},
                    new Technician { Name = "tec3", Birthday = DateTime.Parse("2000-05-03"), 
                    Role = Role.Sonidista, Level = Level.Básico},
                    new Technician { Name = "tec4", Birthday = DateTime.Parse("2000-05-04"), 
                    Role = Role.Director, Level = Level.Avanzado},
                    new Technician { Name = "tec5", Birthday = DateTime.Parse("2000-05-05"), 
                    Role = Role.Fotógrafo, Level = Level.Intermedio},
                    new Technician { Name = "tec6", Birthday = DateTime.Parse("2000-05-06"), 
                    Role = Role.Sonidista, Level = Level.Básico},
                    new Technician { Name = "tec7", Birthday = DateTime.Parse("2000-05-07"), 
                    Role = Role.Fotógrafo, Level = Level.Profesional},
                    new Technician { Name = "tec8", Birthday = DateTime.Parse("2000-05-08"), 
                    Role = Role.Actor, Level = Level.Básico},
                };

                foreach (Technician t in Technicians){
                    context.Technician.Add(t);
                };
                context.SaveChanges();

                var ScoreSheets = new ScoreSheet[]{
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 1,Puntualidad = 1,Formalidad = 1,Respeto = 1,Profesionalismo = 1},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 2,Puntualidad = 2,Formalidad = 2,Respeto = 2,Profesionalismo = 2},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 3,Puntualidad = 3,Formalidad = 3,Respeto = 3,Profesionalismo = 3},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 4,Puntualidad = 4,Formalidad = 4,Respeto = 4,Profesionalismo = 4},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 5,Puntualidad = 5,Formalidad = 5,Respeto = 5,Profesionalismo = 5},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 6,Puntualidad = 6,Formalidad = 6,Respeto = 6,Profesionalismo = 6},
                    new ScoreSheet {Date = DateTime.Now,Compromiso = 7,Puntualidad = 7,Formalidad = 7,Respeto = 7,Profesionalismo = 7}
                };

                foreach (ScoreSheet sc in ScoreSheets){
                    context.ScoreSheet.Add(sc);
                };
                context.SaveChanges();

                var Employs = new Employ[]{

                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.Name == "tec1").TechnicianID,
                        ProjectID = context.Project.Single(p => p.Title == "p1").ProjectID
                    },

                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.Name == "tec8").TechnicianID,
                        ProjectID = context.Project.Single(p => p.Title == "p2").ProjectID
                    },
                    
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.Name == "tec2").TechnicianID,
                        ProjectID = context.Project.Single(p => p.Title == "p3").ProjectID
                    },

                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.Name == "tec2").TechnicianID,
                        ProjectID = context.Project.Single(p => p.Title == "p4").ProjectID
                    },
                    
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.Name == "tec3").TechnicianID,
                        ProjectID = context.Project.Single(p => p.Title == "p5").ProjectID
                    },

                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.Name == "tec4").TechnicianID,
                        ProjectID = context.Project.Single(p => p.Title == "p6").ProjectID
                    },
                    
                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.Name == "tec5").TechnicianID,
                        ProjectID = context.Project.Single(p => p.Title == "p7").ProjectID
                    },

                    new Employ{
                        TechnicianID = context.Technician.Single(t => t.Name == "tec6").TechnicianID,
                        ProjectID = context.Project.Single(p => p.Title == "p1").ProjectID
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
                    TechnicianID = Technicians.Single(t => t.TechnicianID == 4).TechnicianID}
                };

                foreach (FeedBack f in FeedBacks){
                    context.FeedBack.Add(f);
                };
                context.SaveChanges();

                /*

                foreach (FeedBack f in FeedBacks){
                    var FeedBackInDataBase = context.FeedBack.Where(
                        s =>
                                s.User.UserID == f.UserID &&
                                s.ScoreSheet.ScoreSheetID == f.ScoreSheetID &&
                                s.Project.ProjectID == f.ProjectID
                                ).SingleOrDefault();
                    if (FeedBackInDataBase == null){
                        context.FeedBack.Add(f);
                    }
                }
                context.SaveChanges();

                */
            }
        }
    }
}