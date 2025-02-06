using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Evaluación_T1 {
    internal class ListaEnlazadaSimple
    {
        Nodo cabeza;
        public ListaEnlazadaSimple() 
        {
            cabeza=null;
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Nodo nuevo=new Nodo(estudiante);         

            if (cabeza==null)
            {
               cabeza=nuevo;
            } 
            else 
            {
                Nodo aux = cabeza;
                while(aux.sig!=null) {
                    aux=aux.sig;
                }
                aux.sig=nuevo;
            }
        }

        public void OrdenarApellido() {
            if (cabeza==null ||cabeza.sig==null) 
                return;
            bool intercambio;
            do 
            {
                Nodo actual = cabeza;
                
                Nodo siguiente = cabeza.sig;
                intercambio=false;

                while (siguiente!=null) {
                    if (string.Compare(actual.Estudianteinfo.Apellido,siguiente.Estudianteinfo.Apellido)>0) {
                        Estudiante auxEstudiante = actual.Estudianteinfo;
                        actual.Estudianteinfo=siguiente.Estudianteinfo;
                        siguiente.Estudianteinfo=auxEstudiante;
                        intercambio=true;
                    }

                    actual=siguiente;
                    siguiente=siguiente.sig;
                }
            }while (intercambio);
            
        }

        public void mostrarestudiante() {
            Nodo aux = cabeza;
            while (aux!=null) {
                Console.WriteLine($"\nNombre: {aux.Estudianteinfo.Nombre} | Apellido: {aux.Estudianteinfo.Apellido} | Correo: {aux.Estudianteinfo.Correo} |Celular: {aux.Estudianteinfo.Celular}");

                aux=aux.sig;
            }
        }

    }
}
