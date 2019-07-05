using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

   /// <summary>
   /// El modelo de esta aplicación representa datos con respecto a distintos proyectos y sus participantes.
   /// Esto es una aproximación virtual de los participantes y elementos asociados a un proyecto.
   /// Este modelo es la pieza que representa el estado y el comportamiento de bajo nivel (getters y setters) de la aplicaciòn.
   /// El modelo no tiene conocimiento específico sobre ningún controlador o vista.
   ///
   /// ApplicationUser es un subtipo de IdentityUser y un supertipo tanto de Technician como de Client.
   /// ApplicationUser hereda las propiedades y el comportamiento de IdentityUser y lo extiende.
   ///
   /// Su propósito es contener la información de un ApplicationUser.
   ///
   /// Colaboradores: UserManager.
   ///
   /// Principios:
   ///
   /// SRP- La única razón de cambio para esta clase es para modificar la información personalizada de ApplicationUser.
   /// Esto es así porque todos los atributos de las instancias de ApplicationUser tienen un único propósito.
   ///
   /// OCP- ApplicationUser expande el tipo IdentityUser, respetando el tipo base y expandiendo sobre él.
   /// y siempre podemos agregar nuevos métodos.
   ///
   /// LSP- Sí, ya que IdentityUser puede siempre ser sustituído por una entidad del tipo ApplicationUser y no generar error.
   /// Considere la siguiente línea de código: var result = await _userManager.CreateAsync(user, Input.Password)
   /// El método CreateAsync toma como parámetro un objeto del tipo IdentityUser, por lo tanto puede ser sustituído por un objeto
   /// del subtipo ApplicationUser. Este ejemplo en particular se ve en el controlador Register.
   ///
   /// ISP- El diseño de esta clase respeta ISP ya que utiliza todos los tipos de los cuales depende (IdentityUser) 
   /// </summary>


namespace Linked.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }

        // Es necesario tener acceso a IdentityManager para poder buscar el rol de este usuario; esta propiedad se asigna cada vez que se
        // cambia el rol usando IdentityManager para poder buscar por rol después cuando no hay acceso a IdentityManager. La propiedad
        // puede ser null para los usuarios que todavía no tienen un rol asignado.
        public string Role { get; private set; }

        // El IdentityManager que se recibe como argumento no se usa en el método; sólo fuera a que el rol del usuario sea cambiado cuando
        // existe en el contexto una instancia válida de IdentityManager.

        public DateTime DOB { get; set; }
        public void AssignRole(UserManager<ApplicationUser> identityManager, string role)
        {
            if (identityManager == null)
            {
                throw new ArgumentNullException("identityManager");
            }

            this.Role = role;
        }
    }
}
