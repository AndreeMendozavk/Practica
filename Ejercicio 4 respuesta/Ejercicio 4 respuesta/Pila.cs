using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_4_respuesta
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
            nuevo =new Nodo(); 
            nuevo.info = dato;
            nuevo.sig = cima;
            cima = nuevo;
        }

        public int Desapilar()
        {
            if(EsVacio())
            {
                return -1;
            }
            else
            {
                int dato = cima.info;
                cima=cima.sig;
                return dato;
            }
        }
        public void Mostrarpila()
        {
            ptr = cima;
            while( ptr != null )
            {
                Console.WriteLine("{0} ", ptr.info);
                ptr = ptr.sig;
            }
        }
    }
}
