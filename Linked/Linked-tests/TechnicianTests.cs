using System;
using Xunit;
using Linked.Models;
using System.Globalization;

namespace Linked_tests
{
    public class TechnicianTests
    {
        [Fact]
        public void CrearTechnician()
        {
            Technician tecnico = new Technician();

            DateTime fecha = DateTime.Now;
            Level nivel = Level.Avanzado;
            Role rol = Role.Director;

            tecnico.Level = nivel;
            tecnico.Role = rol;
            tecnico.Birthday= fecha;

            Assert.Equal(fecha, tecnico.Birthday);
            Assert.Equal(rol, Role.Director);
            Assert.Equal(nivel, tecnico.Level);
                    
        }
    }
}