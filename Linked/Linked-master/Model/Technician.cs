using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Linked.Areas.Identity.Data;

    /// <summary>
    /// El modelo de esta aplicación representa datos con respecto a distintos proyectos y sus participantes.
    /// Esto es una aproximación virtual de los participantes y elementos asociados a un proyecto.
    /// Este modelo es la pieza que representa el estado y el comportamiento de bajo nivel (getters y setters) de la aplicaciòn.
    /// El modelo no tiene conocimiento específico sobre ningún controlador o vista.
    /// 
    /// Technician es un subtipo de Applicationuser.
    /// Technician hereda las propiedades y el comportamiento de ApplicationUser. Permite crear tipos especialidos de objetos preexistentes.
    /// El principal propósito en la herencia del tipo ApplicationUser por parte de Technician y Client, es jerarquizar la clasificación
    /// de las clases ApplicationUser, Client y Technician.
    /// 
    /// Su propósito es contener la información de un usuario que es un técnico.
    ///
    /// Colaboradores: Specialty, Employ y Level. 
    ///
    /// Principios:
    /// 
    /// SRP- La única razón de cambio para esta clase es para modificar la información personalizada de Technician.
    /// Esto es así porque todos los atributos de las instancias de Client tienen un único propósito.
    /// 
    /// OCP- Technician expande el tipo ApplicationUser, respetando el tipo base y expandiendo sobre él.
    /// y siempre podemos agregar nuevos métodos.
    /// 
    /// LSP- Sí, ya que ApplicationUser puede siempre ser sustituído por una entidad del tipo Technician y no generar error.
    /// Considere la siguiente línea de código: var result = await _userManager.CreateAsync(user, Input.Password)
    /// El método CreateAsync toma como parámetro un objeto del tipo IdentityUser, por lo tanto puede ser sustituído por un objeto
    /// del subtipo Technician. Este ejemplo en particular se ve en el controlador Register.
    /// 
    /// ISP- El diseño de esta clase respeta ISP ya que utiliza todos los métodos en el tipo ApplicationUser: 
    /// en particular Name y DOB son utilizados en el perfil del técnico, y Role es utilizado por los controladores para administrar permisos.
    /// </summary>

namespace Linked.Models{

    public class Technician : ApplicationUser{
        public string TechnicianID { get{return this.Id;}}
        
        [DataType(DataType.Date), Range(typeof(DateTime),"3/4/2010","1/2/1900", ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime Birthday { get {return this.DOB;} }
        
        public Specialty Specialty { get; set; }
        public Level Level { get; set; }

        public List<Employ> Employers { get; set; } //Projects
        public IList<Interest> InterestingProjects { get; set; } // Interesting Projects
    }   
}