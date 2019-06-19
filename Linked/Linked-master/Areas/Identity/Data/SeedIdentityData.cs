using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Linked.Models;

namespace Linked.Areas.Identity.Data
{
    /// <summary>
    /// Inicializa en la base de datos de identidad los usuarios y roles necesarios para el funcionamiento de la aplicaci�n
    /// la primera vez que se ejecuta.
    /// </summary>
    public static class SeedIdentityData
    {
        /// <summary>
        /// Crea los usuarios y roles necesarios para el funcionamiento de la aplicaci�n si ya no existente.
        /// </summary>
        /// <param name="serviceProvider">El <see cref="IServiceProvider"/> al que se han injectado previamente un
        /// <see cref="UserManager<T>"/> y un <see cref="RoleManager<T>"/>.</param>
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            SeedRoles(roleManager);
            SeedUsers(userManager);
            SeedClients(userManager,serviceProvider);
            SeedTechnicians(userManager,serviceProvider);
        }

        private static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            // Crea el primer y �nico administrador si no existe. Primero crea un usuario y luego se asigna el rol de adminstrador.
            if (userManager.FindByNameAsync(IdentityData.AdminUserName).Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.Name = IdentityData.AdminName;
                user.UserName = IdentityData.AdminUserName;
                user.Email = IdentityData.AdminMail;
                user.DOB = IdentityData.AdminDOB;
                // Es necesario tener acceso a RoleManager para poder buscar el rol de este usuario; se asigna aquí para poder
                // buscar por rol después cuando no hay acceso a RoleManager.
                user.AssignRole(userManager, IdentityData.AdminRoleName);

                IdentityResult result = userManager.CreateAsync(user, IdentityData.AdminPassword).Result;

                if (result.Succeeded)
                {
                    IdentityResult addRoleResult = userManager.AddToRoleAsync(user, IdentityData.AdminRoleName).Result;
                    if (!addRoleResult.Succeeded)
                    {
                        throw new InvalidOperationException(
                            $"Unexpected error ocurred adding role '{IdentityData.AdminRoleName}' to user '{IdentityData.AdminName}'.");
                    }
                }
                else
                {
                    throw new InvalidOperationException($"Unexpected error ocurred creating user '{IdentityData.AdminName}'.");
                }
            }
        }

        private static void CreateRole(RoleManager<IdentityRole> roleManager, string roleName)
        {
            // Crea un rol si no existe.
            if (!roleManager.RoleExistsAsync(roleName).Result)
            {
                IdentityRole role = new IdentityRole(roleName);
                IdentityResult createRoleResult = roleManager.CreateAsync(role).Result;
                if (!createRoleResult.Succeeded)
                {
                    throw new InvalidOperationException($"Unexpected error ocurred creating role '{role}'.");
                }
            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            // Crea el rol de administrador si no existe
            CreateRole(roleManager, IdentityData.AdminRoleName);

            foreach (var roleName in IdentityData.NonAdminRoleNames)
            {
                CreateRole(roleManager, roleName);
            }
        }
        private static void SeedClients(UserManager<ApplicationUser> userManager, IServiceProvider serviceProvider)
        {   
            using (var context = new IdentityContext(serviceProvider.GetRequiredService<DbContextOptions<IdentityContext>>())){

                if (context.Client.Any()){
                    return;   // DB has been seeded
                };
            }

            for (int i = 0; i < ClientData.ClientNames.Count(); i++)
            {
                CreateClient(ClientData.ClientNames[i],
                ClientData.fecha,
                ClientData.ClientMail[i],
                IdentityData.AdminPassword,
                userManager);
            }
        }
        private static void SeedTechnicians(UserManager<ApplicationUser> userManager, IServiceProvider serviceProvider)
        {   
            using (var context = new IdentityContext(serviceProvider.GetRequiredService<DbContextOptions<IdentityContext>>())){

                if (context.Technician.Any()){
                    return;   // DB has been seeded
                };
            }

            for (int i = 0; i < TechnicianData.TechnicianNames.Count(); i++)
            {
                CreateTechnician(
                TechnicianData.TechnicianNames[i],
                TechnicianData.fechas[i],
                TechnicianData.TechnicianMail[i],
                IdentityData.AdminPassword,
                TechnicianData.Roles[i],
                TechnicianData.Niveles[i],
                userManager);
            }
        }
        private static void CreateClient(
        string nombre,
        DateTime fecha,
        string correo,
        string contraseña,
        UserManager<ApplicationUser> userManager)
        {
             var user = new Client {
                    Name = nombre,
                    DOB = fecha,
                    UserName = correo,
                    Email = correo
                };
            var result = userManager.CreateAsync(user, contraseña);
        }
        private static void CreateTechnician(
        string nombre,
        DateTime fecha,
        string correo,
        string contraseña,
        Specialty rol,
        Level nivel,
        UserManager<ApplicationUser> userManager)
        {
             var user = new Technician {
                    Name = nombre,
                    DOB = fecha,
                    UserName = correo,
                    Email = correo
                };
            user.Specialty=rol;
            user.Level=nivel;
            var result = userManager.CreateAsync(user, contraseña);
            
        }
    }
}