using EDDemo.Estructuras_No_Lineales.Clases;
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

    public class Cola
    {
        public Nodo Frente; // Representa el frente de la cola
        public Nodo Final;  // Representa el final de la cola

        // Inicializar la cola
        public void Inicializar()
        {
            Frente = Final = null;
        }

        // Verificar si la cola está vacía
        public bool EstaVacia()
        {
            return Frente == null;
        }

        // Insertar un dato en la cola (Encolar)
        public void Encolar(int dato)
        {
            Nodo Nuevo = new Nodo { Dato = dato, Sig = null };

            if (EstaVacia())
            {
                Frente = Final = Nuevo;
            }
            else
            {
                Final.Sig = Nuevo;
                Final = Nuevo;
            }
        }

        // Extraer un dato de la cola (Desencolar)
        public int Desencolar()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La cola está vacía");
            }

            int dato = Frente.Dato;
            Frente = Frente.Sig;

            if (Frente == null)
            {
                Final = null;
            }

            return dato;
        }

        // Buscar un dato en la cola de forma recursiva
        public bool Buscar(int dato)
        {
            return BuscarRecursivo(Frente, dato);
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

        // Limpiar toda la cola
        public void Limpiar()
        {
            Frente = Final = null;
        }

        // Recorrer y mostrar los datos de la cola (Recursivo)
        public void Recorrer()
        {
            RecorrerRecursivo(Frente);
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

    public class ListaSimple
    {
        public Nodo Inicio; // Representa el inicio de la lista

        // Inicializar la lista
        public void Inicializar()
        {
            Inicio = null;
        }

        // Verificar si la lista está vacía
        public bool EstaVacia()
        {
            return Inicio == null;
        }

        // Insertar un dato en la lista (al final)
        public void Insertar(int dato, int posicion)
        {
            Nodo nuevo = new Nodo { Dato = dato, Sig = null };

            if (posicion < 0)
            {
                throw new ArgumentOutOfRangeException("Posición inválida");
            }

            if (posicion == 0)
            {
                nuevo.Sig = Inicio;
                Inicio = nuevo;
            }
            else
            {
                InsertarRecursivo(Inicio, nuevo, posicion - 1);
            }
        }

        private void InsertarRecursivo(Nodo actual, Nodo nuevo, int posicion)
        {
            if (actual == null)
            {
                throw new ArgumentOutOfRangeException("Posición inválida");
            }

            if (posicion == 0)
            {
                nuevo.Sig = actual.Sig;
                actual.Sig = nuevo;
            }
            else
            {
                InsertarRecursivo(actual.Sig, nuevo, posicion - 1);
            }
        }


        // Extraer un dato de la lista (eliminar el primer nodo con ese dato)
        public void Eliminar(int dato)
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La lista está vacía");
            }

            if (Inicio.Dato == dato)
            {
                Inicio = Inicio.Sig;
            }
            else
            {
                EliminarRecursivo(Inicio, dato);
            }
        }

        private void EliminarRecursivo(Nodo actual, int dato)
        {
            if (actual.Sig == null)
            {
                throw new InvalidOperationException("Dato no encontrado en la lista");
            }

            if (actual.Sig.Dato == dato)
            {
                actual.Sig = actual.Sig.Sig;
            }
            else
            {
                EliminarRecursivo(actual.Sig, dato);
            }
        }

        // Buscar un dato en la lista de forma recursiva
        public bool Buscar(int dato)
        {
            return BuscarRecursivo(Inicio, dato);
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

        // Limpiar toda la lista
        public void Limpiar()
        {
            Inicio = null;
        }

        // Recorrer y mostrar los datos de la lista (Recursivo)
        public void Recorrer()
        {
            RecorrerRecursivo(Inicio);
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




