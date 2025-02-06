using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_respuesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol=new ArbolBinario();

            arbol.Insertar(10);
            arbol.Insertar(5);
            arbol.Insertar(14);
            arbol.Insertar(3);
            arbol.Insertar(7);
            arbol.Insertar(13);

            int dato = arbol.BuscarNivel(14);
            Console.WriteLine(dato);

            /*Console.WriteLine("Ingrese el número que desea buscar en el árbol:");
            if (int.TryParse(Console.ReadLine(), out int numeroBuscado))
            {
                int nivel = arbol.BuscarNivel(numeroBuscado); // Buscar el nivel del número

                if (nivel == -1)
                {
                    Console.WriteLine($"El número {numeroBuscado} no se encuentra en el árbol.");
                }
                else
                {
                    Console.WriteLine($"El número {numeroBuscado} se encuentra en el nivel {nivel}.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número.");
            }
            */
            Console.ReadLine();
        }
    }
}
