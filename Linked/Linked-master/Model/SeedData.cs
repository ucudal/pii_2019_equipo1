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

                var Projects = new Project[]{
                    new Project { Title = "p1", Date = DateTime.Parse("2019-05-01")},
                    new Project { Title = "p2", Date = DateTime.Parse("2019-05-02")},
                    new Project { Title = "p3", Date = DateTime.Parse("2019-05-03")},
                    new Project { Title = "p4", Date = DateTime.Parse("2019-05-04")},
                    new Project { Title = "p5", Date = DateTime.Parse("2019-05-05")},
                    new Project { Title = "p6", Date = DateTime.Parse("2019-05-06")},
                    new Project { Title = "p7", Date = DateTime.Parse("2019-05-07")}
                };

                foreach (Project p in Projects){
                    context.Project.Add(p);
                };
                context.SaveChanges();

                var Users = new User[]{
                    new User { FirstName = "fn1", Birthday = DateTime.Parse("2000-05-01")},
                    new User { FirstName = "fn2", Birthday = DateTime.Parse("2000-05-02")},
                    new User { FirstName = "fn3", Birthday = DateTime.Parse("2000-05-03")},
                    new User { FirstName = "fn4", Birthday = DateTime.Parse("2000-05-04")},
                    new User { FirstName = "fn5", Birthday = DateTime.Parse("2000-05-05")},
                    new User { FirstName = "fn6", Birthday = DateTime.Parse("2000-05-06")},
                    new User { FirstName = "fn7", Birthday = DateTime.Parse("2000-05-07")}
                };

                foreach (User u in Users){
                    context.User.Add(u);
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

                var FeedBacks = new FeedBack[]{
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 0).ScoreSheetID,UserID = Users.Single(u => u.UserID == 0).UserID,ProjectID = Projects.Single(p => p.ProjectID == 0).ProjectID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 1).ScoreSheetID,UserID = Users.Single(u => u.UserID == 0).UserID,ProjectID = Projects.Single(p => p.ProjectID == 1).ProjectID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 2).ScoreSheetID,UserID = Users.Single(u => u.UserID == 1).UserID,ProjectID = Projects.Single(p => p.ProjectID == 0).ProjectID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 3).ScoreSheetID,UserID = Users.Single(u => u.UserID == 2).UserID,ProjectID = Projects.Single(p => p.ProjectID == 0).ProjectID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 4).ScoreSheetID,UserID = Users.Single(u => u.UserID == 3).UserID,ProjectID = Projects.Single(p => p.ProjectID == 2).ProjectID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 5).ScoreSheetID,UserID = Users.Single(u => u.UserID == 4).UserID,ProjectID = Projects.Single(p => p.ProjectID == 2).ProjectID},
                    new FeedBack {ScoreSheetID = ScoreSheets.Single(s => s.ScoreSheetID == 6).ScoreSheetID,UserID = Users.Single(u => u.UserID == 5).UserID,ProjectID = Projects.Single(p => p.ProjectID == 3).ProjectID}
                };

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

                foreach (FeedBack f in FeedBacks){
                    context.FeedBack.Add(f);
                };
                context.SaveChanges();
            }
        }
    }
}