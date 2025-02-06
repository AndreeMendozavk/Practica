using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_respuesta
{
    internal class Pila
    {
        Nodo cima, nuevo, ptr;

        public Pila()
        {
            cima = null;
        }

        public bool EsVacio()
        {
            return cima == null;
        }

        public void Apilar(int dato)
        {
            nuevo = new Nodo();
            nuevo.info = dato;
            nuevo.sig = cima;
            cima = nuevo;
        }

        public int Desapilar()
        {
            if (EsVacio())
            {
                Console.WriteLine("La Pila esta vacia");
                return -1;
            }

            else
            {
                int dato = cima.info;
                cima = cima.sig;
                return dato;
            }
        }

        public void Mostrar()
        {
            Nodo ptr = cima;
            while (ptr != null)
            {
                Console.Write("{0} ", ptr.info);
                ptr = ptr.sig;
            }
            Console.WriteLine();
        }

        public bool Contiene(int dato)
        {
            Nodo ptr = cima;
            while (ptr != null)
            {
                if (ptr.info == dato)
                    return true;
                ptr = ptr.sig;
            }
            return false;
        }

        public Pila Copiar()
        {
            Pila copia = new Pila();
            Nodo ptr = cima;
            while (ptr != null)
            {
                copia.Apilar(ptr.info);
                ptr = ptr.sig;
            }
            return copia;
        }



    }
}
