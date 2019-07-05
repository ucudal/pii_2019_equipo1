using System; 
   /// <summary>
   /// Estas listas son una parte de bajo nivel del modelo por lo tanto tienen bajo acoplamiento.
   /// El propósito de estas listas es representar las distintas especialidades y niveles que hay requeridas en un proyecto.
   /// </summary>

namespace Linked.Models {
    public enum Specialty {
        Director, Actor, Camarógrafo, Fotógrafo, Sonidista
    }
    public enum Level {
        Profesional, Avanzado, Intermedio, Básico
    }
}