using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_respuesta
{
    internal class ArbolBinario
    {
        public Nodo Raiz;

        public ArbolBinario()
        {
            Raiz = null;
        }

        public  void Insertar(int dato)
        {
            Raiz = InsertarRecursivo(Raiz, dato);
        }

        public  Nodo InsertarRecursivo(Nodo raiz, int dato)
        {
            if (raiz == null)
                raiz = new Nodo(dato);
            if (dato < raiz.info)
                raiz.Izquierda = InsertarRecursivo(raiz.Izquierda, dato);
            else if (dato > raiz.info)
                raiz.Derecha = InsertarRecursivo(raiz.Derecha, dato);
            return raiz;
        }

        public int BuscarNivel(int dato)
        {
            return BuscarNivelRecursivo(Raiz, dato, 0); // Comienza con nivel 0 desde la raíz
        }

        public int BuscarNivelRecursivo(Nodo raiz, int dato, int nivel)
        {
            // Caso base: Si el nodo es null, el dato no se encuentra en el árbol
            if (raiz == null)
            {
                Console.WriteLine($"El dato {dato} no esta en el arbol ");
                return -1;
            }
            // Si encontramos el dato, devolvemos el nivel actual
            if (raiz.info == dato)
            {
                Console.WriteLine($"El dato {dato} si esta en el arbol");
                Console.Write("Nivel ");
                return nivel;
            }

            // Si el dato es menor, buscamos en el subárbol izquierdo
            if (dato < raiz.info)
                return BuscarNivelRecursivo(raiz.Izquierda, dato, nivel + 1);

            // Si el dato es mayor, buscamos en el subárbol derecho
            else
            return BuscarNivelRecursivo(raiz.Derecha, dato, nivel + 1);
        }
    }

}
