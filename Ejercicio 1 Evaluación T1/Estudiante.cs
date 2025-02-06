using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Evaluación_T1 {
    public class Estudiante
    {
        public string Nombre;
        public string Apellido;
        public string Correo;
        public string Celular;

        public Estudiante(string nombre, string apellido,string correo,string celular) 
        {
            Nombre=nombre;
            Apellido=apellido;
            Correo=correo;
            Celular=celular;

        }
    }
}
