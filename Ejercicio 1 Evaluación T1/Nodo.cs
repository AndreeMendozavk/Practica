using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Evaluación_T1 {
    public class Nodo
    {
       public Estudiante Estudianteinfo {  get; set; }
        public Nodo sig { get; set; }
        public Nodo(Estudiante estudiante)
        {
            Estudianteinfo=estudiante;
            sig=null;
        }
    }
}
