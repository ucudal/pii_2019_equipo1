using System;
using System.Collections.Generic;
using Linked.Areas.Identity.Data;
    
    /// <summary>
    /// Client es un subtipo de Applicationuser.
    /// 
    /// Su propósito es encapsular la información de un usuario que es un cliente.
    ///
    /// Colaboradores: Project. Cada instancia de Client esta compuesta por una lista de Project.
    ///
    /// Principios:
    /// 
    /// SRP- La única razón de cambio para esta clase es para modificar la información personalizada de Client.
    /// Esto es así porque todos los atributos de las instancias de Client tienen un único propósito.
    /// 
    /// OCP- Client expande el tipo ApplicationUser, respetando el tipo base y expandiendo sobre él.
    /// y siempre podemos agregar nuevos métodos.
    /// 
    /// LSP- Sí, ya que ApplicationUser puede siempre ser sustituído por una entidad del tipo Client y no generar error.
    /// Considere la siguiente línea de código: var result = await _userManager.CreateAsync(user, Input.Password)
    /// El método CreateAsync toma como parámetro un objeto del tipo IdentityUser, por lo tanto puede ser sustituído por un objeto
    /// del subtipo Client. Este ejemplo en particular se ve en el controlador Register.
    /// 
    /// ISP- El diseño de esta clase respeta ISP ya que utiliza todos los métodos en el tipo ApplicationUser: 
    /// en particular Name y DOB son utilizados en el perfil del cliente, y Role es utilizado por los controladores para administrar permisos.
    /// 
    /// </summary>

namespace Linked.Models{
    public class Client : ApplicationUser{
        public string ClientID { get{ return this.Id; } }
        public IList<Project> Projects { get; set; }
    }   
}