﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_4_respuesta
{
    internal class Cola
    {
        Nodo cabeza, ultimo, nuevo, ptr;

        public Cola()
        {
            cabeza = null;
        }

        public bool EsVacio()
        {
            return cabeza == null;
        }

        public void Encolar(int dato)
        {
            nuevo = new Nodo();
            nuevo.info = dato;
            nuevo.sig = null;

            if (cabeza == null)
            {
                cabeza = ultimo = nuevo;
            }
            else
            {
                ultimo.sig = nuevo;
                ultimo = nuevo;
            }
        }
        public int Desencolar()
        {
            if (EsVacio())
                return -1;
            else
            {
                int dato = cabeza.info;
                cabeza = cabeza.sig;
                return dato;
            }
        }
        public void Mostrarcola()
        {
            ptr = cabeza;
            while (ptr != null)
            {
                Console.Write("{0} ", ptr.info);
                ptr = ptr.sig;
            }
        }
    }
}
