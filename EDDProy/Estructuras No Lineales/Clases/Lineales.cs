using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales.Clases
{
    public class Nodo
    {
        public int Dato { get; set; }
        public Nodo Sig { get; set; }
    }

    public class Pila
    {
        public Nodo Top; // Representa la cima de la pila
       
        // Inicializar la pila
        public void Inicializar()
        {
            Top = null;
        }

        // Verificar si la pila está vacía
        public bool EstaVacia()
        {
            return Top == null;
        }

        // Insertar un dato en la pila (Push)
        public void Push(int dato)
        {
            Nodo Nuevo = new Nodo { Dato = dato, Sig = null };

            if (EstaVacia())
            {
                Top = Nuevo;
            }
            else
            {
                Nuevo.Sig = Top;
                Top = Nuevo;
            }
        }

        // Extraer un dato de la pila (Pop)
        public int Pop()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La pila está vacía");
            }

            int dato = Top.Dato;
            Top = Top.Sig;
            return dato;
        }

        // Buscar un dato en la pila de forma recursiva
        public bool Buscar(int dato)
        {
            return BuscarRecursivo(Top, dato);
        }

        private bool BuscarRecursivo(Nodo actual, int dato)
        {
            if (actual == null)
            {
                return false;
            }
            if (actual.Dato == dato)
            {
                return true;
            }
            return BuscarRecursivo(actual.Sig, dato);
        }

        // Limpiar toda la pila
        public void Limpiar()
        {
            Top = null;
        }

        // Recorrer y mostrar los datos de la pila (Recursivo)
        public void Recorrer()
        {
            RecorrerRecursivo(Top);
        }

        private void RecorrerRecursivo(Nodo actual)
        {
            if (actual != null)
            {
                Console.WriteLine(actual.Dato);
                RecorrerRecursivo(actual.Sig);
            }
        }
    }
}
