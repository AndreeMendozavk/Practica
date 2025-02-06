using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Evaluación_T1 {
    public  class ArbolBinario 
    {
        public Nodo Raiz;

        public ArbolBinario() 
        {
            Raiz = null;
        }

        public void Insertar (int dato) 
        {
            Raiz=InsertarRecusivo(Raiz,dato);
        }

        public Nodo InsertarRecusivo(Nodo raiz, int dato) 
        {
            if (raiz==null)
                raiz=new Nodo(dato);
            if (dato<raiz.info)
                raiz.Izquierda=InsertarRecusivo(raiz.Izquierda,dato);
            else if (dato>raiz.info)
                raiz.Derecha=InsertarRecusivo(raiz.Derecha,dato);
            return raiz;

        }

        public int BuscarNivel(int dato) {
            return BuscarNivelRecursivo(Raiz,dato,0);

        }
        public int BuscarNivelRecursivo(Nodo raiz, int dato, int nivel) 
        {
            if (raiz==null) {
                Console.WriteLine($"\nEl dato {dato} no se encuentra en el arbol ");
                return -1;
            }
               

            if (raiz.info==dato) 
            {
                Console.WriteLine($"El dato {dato} si se encuentra en el arbol ");
                Console.Write("Nivel: ");
                return nivel;
            }

            if (dato<raiz.info)
                return BuscarNivelRecursivo(raiz.Izquierda,dato,nivel+1);
            else
                return BuscarNivelRecursivo(raiz.Derecha,dato,nivel+1);
        }
    }
}
