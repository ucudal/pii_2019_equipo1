using System;
using Xunit;
using Linked.Models;
using System.Globalization;

namespace Linked_tests
{
    public class ProjectTests
    {  
        [Fact]
        public void CrearProyecto()
        {
            Project proyecto = new Project();

            string titulo = "Shrek";
            string des = "La mejor peli";
            Level nivel = Level.Avanzado;
            Role rol = Role.Director;

            proyecto.Title=titulo;
            proyecto.Description=des;
            proyecto.Role = rol;
            proyecto.Level = nivel;

            Assert.Equal(titulo, proyecto.Title);
            Assert.Equal(des, proyecto.Description);
            Assert.Equal(rol, proyecto.Role);
            Assert.Equal(nivel, proyecto.Level);         
        }
        [Fact] 
        public void NullValuesProyecto()
        {
            Project proyecto = new Project();

            string titulo = "Shrek";
            string des = "La mejor peli";

            string titulomal = "";
            string desmal = "";   

            proyecto.Title=titulo;
            proyecto.Description=des;

            proyecto.Title=titulomal;
            proyecto.Description=desmal;

            proyecto.Title=null;
            proyecto.Description=null;
            
            Assert.Equal(titulo, proyecto.Title);
            Assert.Equal(des, proyecto.Description);

        }
        [Fact]
            public void AsignarGenteProyecto()
        {
            Project proyecto = new Project();

            string titulo = "Shrek";
            string des = "La mejor peli";

            Level nivel = Level.Avanzado;
            Role rol = Role.Director;

            proyecto.Title=titulo;
            proyecto.Description=des;
            proyecto.Role = rol;
            proyecto.Level = nivel;

            Client cliente = new Client();
            cliente.Name = "Maria";

            Technician tecnico = new Technician();

            proyecto.Client = cliente;

            DateTime fecha = DateTime.Now;

            tecnico.Level = nivel;
            tecnico.Role = rol;
            tecnico.Birthday= fecha;

            Employ contratacion = new Employ();
            contratacion.Technician=tecnico;
            contratacion.Project=proyecto;

            Assert.Equal(contratacion.Technician,tecnico);
            Assert.Equal(contratacion.Project,proyecto);

        }

    }
}