using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Evaluación_T1 {
    internal class Program {
               
        static void Main(string[] args) 
        {
             Pila miPila=new Pila();
             Cola miCola=new Cola();

            miCola.Encolar(4);
            miCola.Encolar(8);
            miCola.Encolar(41);
            miCola.Encolar(9);
            miCola.Encolar(8);

            Console.WriteLine("Los elementos de la cola antes de operar ");
            miCola.MostrarCola();

            ColaaPila(ref miPila,ref miCola);

            Console.WriteLine("\nLos elementos de la pila despues de operar ");
            miPila.MostrarPila();

            Console.ReadLine();

        }


        
        //Se usa Una COLA AUXILIAR para guardar temporalmente los datos y pasarlos a la pila
        static void ColaaPila(ref Pila pila, ref Cola cola)
        {

            Cola ColaAuxiliar=new Cola();

            while (!cola.EsVacio())
            {
                int dato = cola.Desencolar();
                ColaAuxiliar.Encolar(dato);

            }
            while (!ColaAuxiliar.EsVacio())
            {
                int dato = ColaAuxiliar.Desencolar();
                pila.Apilar(dato);
            }

        }
    }
}
