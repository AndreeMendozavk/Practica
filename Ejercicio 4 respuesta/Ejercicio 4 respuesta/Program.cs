using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_4_respuesta
{
    internal class Program
    {
        
       /* static void CopiarPilaACola(ref Pila pila, ref Cola cola)
        {
            // Paso 1: Usamos un arreglo para almacenar los elementos desapilados
            int[] elementos = new int[100];  // Suponemos que la pila no tendrá más de 100 elementos
            int contador = 0;

            // Transferimos los elementos de la pila al arreglo
            while (!pila.EsVacio())
            {
                int dato = pila.Desapilar();
                elementos[contador++] = dato;
            }

            // Paso 2: Transferimos los elementos del arreglo a la cola
            for (int i = contador - 1; i >= 0; i--)  // Recorremos el arreglo en orden inverso
            {
                cola.Encolar(elementos[i]);
            }

           
        }*/
        static void Main(string[] args)
        {
            Pila miPila = new Pila();
            Cola miCola = new Cola();

            miPila.Apilar(5);
            miPila.Apilar(4);
            miPila.Apilar(3);
            miPila.Apilar(24);
            miPila.Apilar(1);
                                  

            Console.WriteLine("Contenido de la pila P (antes de la operación):");
            miPila.Mostrarpila();

                     
            //Copiar los elementos de la pila P a la cola C
            CopiarPilaACola(ref miPila, ref miCola);
            
            Console.WriteLine("\nContenido de la cola C (después de copiar de la pila):");
            miCola.Mostrarcola();

            Console.ReadLine();
        }

        static void CopiarPilaACola(ref Pila pila, ref Cola cola)
        {
            // Paso 1: Usamos una pila auxiliar para invertir el orden de los elementos
            Pila pilaAuxiliar = new Pila();

            // Transferimos los elementos de la pila original a la pila auxiliar
            while (!pila.EsVacio())
            {
                int dato = pila.Desapilar();
                pilaAuxiliar.Apilar(dato);
            }

            // Paso 2: Transferimos los elementos de la pila auxiliar a la cola
            while (!pilaAuxiliar.EsVacio())
            {
                int dato = pilaAuxiliar.Desapilar();
                cola.Encolar(dato);
            }

        }
    }
}
