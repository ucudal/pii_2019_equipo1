using System;
using Xunit;
using Linked.Models;

namespace Linked_tests
{
    public class FeedbackTests
    {
        [Fact]
        public void CrearScoreSheet()
        {
            ScoreSheet hoja = new ScoreSheet();

            // public int Puntualidad{ get; set; }
            // public int Respeto{ get; set; }
            // public int Formalidad{ get; set; }
            // public int Profesionalismo{ get; set; }
            // public int Compromiso{ get; set; }

            int puntual = 1;
            int respet = 2;
            int formal = 3;
            int prof = 4;
            int comprom = 5;
            int total = (puntual+respet+formal+prof+comprom)/5;
            
            hoja.Puntualidad=puntual;
            hoja.Respeto=respet;
            hoja.Formalidad=formal;
            hoja.Profesionalismo=prof;
            hoja.Compromiso=comprom;

            Assert.Equal(puntual,hoja.Puntualidad);  
            Assert.Equal(respet,hoja.Respeto); 
            Assert.Equal(formal,hoja.Formalidad);
            Assert.Equal(prof,hoja.Profesionalismo);
            Assert.Equal(comprom,hoja.Compromiso);
            Assert.Equal(total,hoja.Score);

            Technician tecnico = new Technician();

            DateTime fecha = DateTime.Now;
            Level nivel = Level.Avanzado;
            Role rol = Role.Director;

            tecnico.Level = nivel;
            tecnico.Role = rol;
            tecnico.Birthday= fecha;

            FeedBack feed = new FeedBack();
            feed.ScoreSheet=hoja;
            feed.Technician=tecnico;

            Assert.Equal(hoja,feed.ScoreSheet);  
            Assert.Equal(tecnico,feed.Technician);  




        }
    }
}