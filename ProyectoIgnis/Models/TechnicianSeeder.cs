using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection; 
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProyectoIgnis.Models
{
    public static class TechnicianSeeder
    {
    public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IgnisContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<IgnisContext>>()))
            {
                
                if (context.Technician.Any())
                {
                    return; 
                }

            var technicians = new Technician[]
            {
            new Technician{Name="Carson",LastName="Alexander",MailAdress="carson@gmail.com",Level="Basico",Role="Sonidista"},
            new Technician{Name="Meredith",LastName="Alonso",MailAdress="meredith@gmail.com",Level="Basico",Role="Sonidista"},
            new Technician{Name="Arturo",LastName="Anand",MailAdress="arturo@gmail.com",Level="Basico",Role="Camarografo"},
            new Technician{Name="Gytis",LastName="Barzdukas",MailAdress="gytis@gmail.com",Level="Basico",Role="Fotografo"},
            new Technician{Name="Yan",LastName="Li",MailAdress="yan@gmail.com",Level="Avanzado",Role="Editor"},
            new Technician{Name="Peggy",LastName="Justice",MailAdress="peggy@gmail.com",Level="Avanzado",Role="Editor"},
            new Technician{Name="Laura",LastName="Norman",MailAdress="laura@gmail.com",Level="Avanzado",Role="Guionista"},
            new Technician{Name="Nino",LastName="Olivetto",MailAdress="nino@gmail.com",Level="Avanzado",Role="Fotografo"}
            };
            foreach (Technician t in technicians)
            {
                context.Technician.Add(t);
            }
            context.SaveChanges();
            }
        }
    }

}