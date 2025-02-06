using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_respuesta
{
    internal class ListaEnlazadaSimple
    {
        Nodo raiz, nuevo,ant, ptr;

        public ListaEnlazadaSimple()
        {
            raiz = null;
        }

        public  void InsertarEnPosicion(int dato, int posicion)
        {
            // Crear el nuevo nodo con el dato a insertar
            nuevo = new Nodo();
            nuevo.info = dato;

            // Si la posición es 0, insertar al inicio
            if (posicion == 0)
            {
                nuevo.sig = raiz;  // El nuevo nodo apunta a la raiz (el primer nodo)
                raiz = nuevo;      // La raiz se actualiza al nuevo nodo
                return;            // Terminamos la inserción
            }

            // Si la posición es mayor a 0, recorremos la lista hasta la posición deseada
            
             ptr = raiz;
             ant = null;

            int contador = 0;

            // Recorremos hasta la posición donde insertar
            while (ptr != null && contador < posicion)
            {
                ant = ptr;
                ptr = ptr.sig;
                contador++;
            }

            // Insertamos el nodo en la posición indicada
            if (contador == posicion)
            {
                ant.sig = nuevo;
                nuevo.sig = ptr; // El nuevo nodo apunta al siguiente
            }
            else
            {
                Console.WriteLine("Posición no valida");
            }
        }

        public void Mostrar()
        {
            ptr = raiz;
            while(ptr != null)
            {
                Console.Write("{0} ", ptr.info);
                ptr = ptr.sig;
            }
        }

    }
}
