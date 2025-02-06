using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_respuesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaSimple milista = new ListaEnlazadaSimple();

            milista.InsertarEnPosicion(2, 0);
            milista.InsertarEnPosicion(4, 1);
            milista.InsertarEnPosicion(8, 2);
            milista.InsertarEnPosicion(19, 3); 
            milista.InsertarEnPosicion(21, 4);



            Console.WriteLine("Lista después de las inserciones:");
            milista.Mostrar();

            // Insertar un dato en una posición específica
            Console.WriteLine("\nInsertando 15 en la posición 1...");
            milista.InsertarEnPosicion(15, 1);  // Insertar en la posición 1
            milista.Mostrar();

            Console.WriteLine("\nInsertando 41 en la posición 4...");
            milista.InsertarEnPosicion(41, 4);  // Insertar en la posición 4
            milista.Mostrar();


            Console.ReadLine();
            

        }
    }
}
