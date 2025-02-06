using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Evaluación_T1 {
    internal class Program {
        static void Main(string[] args)
        {
            ArbolBinario arbol=new ArbolBinario();
            int dato;

            arbol.Insertar(8);
            arbol.Insertar(45);
            arbol.Insertar(68);
            arbol.Insertar(2);
            arbol.Insertar(9);


            dato = arbol.BuscarNivel(8);
            Console.Write(dato);

            dato=arbol.BuscarNivel(21);
            Console.Write(dato);

            Console.ReadLine();

        }
    }
}
