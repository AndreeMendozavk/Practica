using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_respuesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila L1 = new Pila();
            Pila L2 = new Pila();

            L1.Apilar(8);
            L1.Apilar(0);
            L1.Apilar(9);
            L1.Apilar(-6);
            L1.Apilar(5);
            L1.Apilar(19);


            L2.Apilar(4);
            L2.Apilar(41);
            L2.Apilar(6);
            L2.Apilar(9);
            L2.Apilar(-6);
            L2.Apilar(21);

            Pila union = ObtenerUnion(L1, L2);
            Console.WriteLine("Unión de L1 y L2 (sin repetidos): ");
            union.Mostrar();

            // Intersección de L1 y L2
            Pila interseccion = ObtenerInterseccion(L1, L2);
            Console.WriteLine("Intersección de L1 y L2: ");
            interseccion.Mostrar();

            Console.ReadLine();
        }

        public static Pila ObtenerUnion(Pila L1, Pila L2)
        {
            Pila resultado = new Pila();
            Pila temp = new Pila();

            // Primero agregamos todos los elementos de L1 a la pila de resultado si no están ya en temp
            Pila L1Copia = L1.Copiar(); // Copia de L1
            while (!L1Copia.EsVacio())
            {
                int dato = L1Copia.Desapilar();
                if (!temp.Contiene(dato))
                {
                    resultado.Apilar(dato); // Añadir al resultado
                    temp.Apilar(dato);       // Añadir a temp para evitar duplicados
                }
            }

            // Luego, agregamos los elementos de L2 a la pila de resultado si no están ya en temp
            Pila L2Copia = L2.Copiar(); // Copia de L2
            while (!L2Copia.EsVacio())
            {
                int dato = L2Copia.Desapilar();
                if (!temp.Contiene(dato))
                {
                    resultado.Apilar(dato); // Añadir al resultado
                    temp.Apilar(dato);       // Añadir a temp para evitar duplicados
                }
            }
            return resultado;
        }

        public static Pila ObtenerInterseccion(Pila L1, Pila L2)
        {
            Pila resultado = new Pila();

            // Copiamos las pilas para no modificar las originales
            Pila L1Copia = L1.Copiar();
            Pila L2Copia = L2.Copiar();

            // Recorremos L1 y buscamos si esos elementos están en L2
            while (!L1Copia.EsVacio())
            {
                int dato = L1Copia.Desapilar();
                if (L2Copia.Contiene(dato)) // Si L2 contiene el elemento de L1, lo agregamos al resultado
                {
                    resultado.Apilar(dato);
                }
            }

            return resultado;
        }
    }
}
