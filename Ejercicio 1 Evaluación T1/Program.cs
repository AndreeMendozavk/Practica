using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Evaluación_T1 {
    internal class Program {
        static void Main(string[] args) 
        {
            ListaEnlazadaSimple lista=new ListaEnlazadaSimple();
            string opcion;
            do {
                Console.WriteLine("Ingrese los datos del estudiante:");
                Console.Write("\nIngrese el nombre: ");
                string nombre = Console.ReadLine();


                Console.Write("\nIngrese el apellido: ");
                string apellido = Console.ReadLine();

                Console.Write("\nIngrese el correo: ");
                string correo = Console.ReadLine();

                Console.Write("\nIngrese el celular: ");
                string celular = Console.ReadLine();

                Estudiante nuevoEstudiante = new Estudiante(nombre,apellido,correo,celular);

                lista.AgregarEstudiante(nuevoEstudiante);

                Console.WriteLine("\nSi quiere continuar presione s/n");
                opcion = Console.ReadLine();

                Console.Clear();

            } while (opcion.ToUpper()=="S");


            lista.OrdenarApellido();

            Console.WriteLine("Estudiante ordenados por Apellido");
            Console.WriteLine();

            lista.mostrarestudiante();
            Console.ReadLine();
        }
    }
}
