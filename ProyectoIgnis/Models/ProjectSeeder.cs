using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection; 
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProyectoIgnis.Models
{
    public static class ProjectSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IgnisContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<IgnisContext>>()))
            {
            if (context.Project.Any())
            {
                return;
            }

                var projects = new Project[]
                {
                new Project{HourLoad=3,Description="Buscamos fotografo",Client="UCU",Level="Basico",Role="Fotografo"},
                new Project{HourLoad=8,Description="Buscamos sonidista",Client="UCU",Level="Basico",Role="Sonidista"},
                new Project{HourLoad=4,Description="Buscamos editor",Client="UCU",Level="Avanzado",Role="Editor"},
                new Project{HourLoad=9,Description="Buscamos camarografo",Client="UCU",Level="Avanzado",Role="Camarografo"},
                new Project{HourLoad=1,Description="Buscamos fotografo",Client="UCU",Level="Basico",Role="Fotografo"},
                new Project{HourLoad=5,Description="Buscamos editor",Client="UCU",Level="Avanzado",Role="Editor"},
                new Project{HourLoad=10,Description="Buscamos fotografo",Client="UCU",Level="Basico",Role="Fotografo"},
                };
                foreach (Project p in projects)
                {
                    context.Project.Add(p);
                }
                context.SaveChanges();
            }
        }
    }
    
    
}