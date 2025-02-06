using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_respuesta
{
    internal class Nodo
    {
        public int info { get; set; }

        public Nodo Izquierda { get; set; }

        public Nodo Derecha { get; set; }


        public Nodo(int dato)
        {

            info = dato;
            Izquierda = null;
            Derecha = null;
        }        

    }
}
