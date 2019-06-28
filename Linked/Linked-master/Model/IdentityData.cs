using System;
using Linked.Models;

namespace Linked.Areas.Identity.Data
{
    public static class IdentityData
    {
        public const string AdminUserName = "admin@contoso.com";

        public const string AdminName = "Administrator";

        public const string AdminMail = "admin@contoso.com";

        public static DateTime AdminDOB = new DateTime(1967, 3, 31);

        public const string AdminPassword = "P@55w0rd";

        public const string AdminRoleName = "Administrator";

        public static string[] NonAdminRoleNames = new string[] { "Client", "Technician" };
    }
    public static class ClientData
    {
        public static string[] ClientNames = new string [] {
        "ESPN",
        "DreamWorks",
        "Universidad de la República",
        "Pixar Studio",
        "Illumination Studios",
        "Centro Ignis Marketing",
        "Passanger Band"
        };
        public static string[] ClientMail = new string [] {
        "espn@gmail.com",
        "dreams@gmail.com",
        "udelar@gmail.com",
        "pixar@gmail.com",
        "illu@gmail.com",
        "ignis@gmail.com",
        "passba@gmail.com"
        };
        public static DateTime fecha = DateTime.Parse("2009-02-01");
    }
    public static class TechnicianData
    {   
        public static string[] TechnicianNames = new string [] {
        "Rodolfo Martinez",
        "Sergio Pérez",
        "Camila Fernández",
        "Lorena Vásquez",
        "Rodrigo Kan",
        "James Cameron",
        "Ignacio Sica",
        "Martin Perdomo",
        "Hola Hola"
        };
        public static string[] TechnicianMail = new string [] {
        "Rodolfo@gmail.com",
        "Sergio@gmail.com",
        "Camila@gmail.com",
        "Lorena@gmail.com",
        "Rodrigo@gmail.com",
        "James@gmail.com",
        "Ignacio@gmail.com",
        "Martin@gmail.com"
        };
        public static DateTime[] fechas = new DateTime[]
        {
            DateTime.Parse("2000-05-01"),
            DateTime.Parse("1986-07-02"),
            DateTime.Parse("1974-08-03"),
            DateTime.Parse("1963-05-04"),
            DateTime.Parse("1995-04-05"),
            DateTime.Parse("1956-03-06"),
            DateTime.Parse("1999-07-07"),
            DateTime.Parse("1983-11-08"),
        };
        public static Specialty[] Roles = new Specialty[]
        {
            Specialty.Director,
            Specialty.Camarógrafo,
            Specialty.Sonidista,
            Specialty.Director,
            Specialty.Fotógrafo,
            Specialty.Actor,
            Specialty.Sonidista,
            Specialty.Fotógrafo
        };
        public static Level[] Niveles = new Level[]
        {
            Level.Intermedio,
            Level.Básico,
            Level.Profesional,
            Level.Intermedio,
            Level.Básico,
            Level.Profesional,
            Level.Intermedio,
            Level.Básico,
        };
    }
}