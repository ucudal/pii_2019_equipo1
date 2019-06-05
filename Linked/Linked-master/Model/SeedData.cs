using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Linked.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            // using (var context = new LinkedContext(
            //     serviceProvider.GetRequiredService<
            //         DbContextOptions<LinkedContext>>()))
            // {
                // // Look for any Linkeds.
                // if (context.Linked.Any())
                // {
                //     return;   // DB has been seeded
                // }

                // context.Linked.AddRange(
                //     new Linked
                //     {
                //         Title = "When Harry Met Sally",
                //         ReleaseDate = DateTime.Parse("1989-2-12"),
                //         Genre = "Romantic Comedy",
                //         Price = 7.99M,
                //         Rating = "R"
                //     },

                //     new Linked
                //     {
                //         Title = "Ghostbusters ",
                //         ReleaseDate = DateTime.Parse("1984-3-13"),
                //         Genre = "Comedy",
                //         Price = 8.99M,
                //         Rating = "R"
                //     },

                //     new Linked
                //     {
                //         Title = "Ghostbusters 2",
                //         ReleaseDate = DateTime.Parse("1986-2-23"),
                //         Genre = "Comedy",
                //         Price = 9.99M,
                //         Rating = "R"
                //     },

                //     new Linked
                //     {
                //         Title = "Rio Bravo",
                //         ReleaseDate = DateTime.Parse("1959-4-15"),
                //         Genre = "Western",
                //         Price = 3.99M,
                //         Rating = "R"
                //     }
                //);
                //context.SaveChanges();
            //}
        }
    }
}