using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_practica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListaEnlazadaSimple miLista = new ListaEnlazadaSimple();

            do
            {
                Console.WriteLine("\nInsertar numero:  para terminar presiona 0");
                int dato = int.Parse(Console.ReadLine());

                if (dato == 0) break;

                miLista.InsertarOrdenado(dato);
             
            } while (true);

            Console.WriteLine("\n----LISTA ORDENADA----");
            miLista.Mostrar();


            Console.ReadLine();

        }
    }
}
