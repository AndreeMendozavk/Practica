using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_practica
{
    internal class ListaEnlazadaSimple
    {
        public Nodo raiz, nuevo, ant, ptr;

        //metodo constructor
        public ListaEnlazadaSimple()
        {
            raiz = null;
        }

        public void Agregar(int dato)
        {
            nuevo=new Nodo(); 
            nuevo.info = dato;
            nuevo.sig = raiz;
            raiz = nuevo;

        }

        public void InsertarOrdenado(int dato)
        {
            // Creamos el nuevo nodo
            nuevo = new Nodo();
            nuevo.info = dato;

            // Si la lista está vacía o el dato es menor que el primer nodo (raíz)
            if (raiz == null || raiz.info >= dato)
            {
                nuevo.sig = raiz;  // El nuevo nodo apunta a la raíz
                raiz = nuevo;      // El nuevo nodo se convierte en la raíz
            }
            else
            {
                ant = null;
                ptr = raiz;

                // Recorremos la lista hasta encontrar la posición correcta
                while (ptr != null && ptr.info < dato)
                {
                    ant = ptr;         // Guardamos el nodo actual en ant
                    ptr = ptr.sig;     // Avanzamos al siguiente nodo
                }

                //En caso el termino lo insertamos en una posicion intermedia
                ant.sig = nuevo;   // El nodo anterior apunta al nuevo nodo
                nuevo.sig = ptr;   // El nuevo nodo apunta al siguiente nodo de ptr
            }
        }


        // Método para imprimir la lista
        public void Mostrar()
        {
            ptr = raiz;
            while (ptr != null)
            {
                Console.Write(ptr.info + " ");
                ptr = ptr.sig;
            }
            Console.WriteLine();
        }
    }
}
