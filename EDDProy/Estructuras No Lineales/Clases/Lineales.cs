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

    public class NodoDoble
    {

        public int Dato { get; set; }
        public NodoDoble Anterior { get; set; }
        public NodoDoble Siguiente { get; set; }

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


        public class ListaDoble
        {
            public NodoDoble Inicio; // Representa el inicio de la lista
            public NodoDoble Fin;    // Representa el final de la lista

            // Verificar si la lista está vacía
            public bool EstaVacia()
            {
                return Inicio == null;
            }

            // Insertar un dato en una posición específica
            public void Insertar(int dato, int posicion)
            {
                NodoDoble nuevo = new NodoDoble { Dato = dato };

                if (posicion < 0)
                {
                    throw new ArgumentOutOfRangeException("Posición inválida");
                }

                if (posicion == 0)
                {
                    nuevo.Siguiente = Inicio;

                    if (Inicio != null)
                    {
                        Inicio.Anterior = nuevo;
                    }

                    Inicio = nuevo;

                    if (Fin == null) // Si la lista estaba vacía, Fin también debe apuntar a nuevo
                    {
                        Fin = nuevo;
                    }
                }
                else
                {
                    InsertarRecursivo(Inicio, nuevo, posicion - 1);
                }
            }

            private void InsertarRecursivo(NodoDoble actual, NodoDoble nuevo, int posicion)
            {
                if (actual == null)
                {
                    throw new ArgumentOutOfRangeException("Posición inválida");
                }

                if (posicion == 0)
                {
                    nuevo.Siguiente = actual.Siguiente;
                    nuevo.Anterior = actual;

                    if (actual.Siguiente != null)
                    {
                        actual.Siguiente.Anterior = nuevo;
                    }

                    actual.Siguiente = nuevo;

                    if (nuevo.Siguiente == null) // Si se inserta al final, actualizar Fin
                    {
                        Fin = nuevo;
                    }
                }
                else
                {
                    InsertarRecursivo(actual.Siguiente, nuevo, posicion - 1);
                }
            }

            // Eliminar un dato de la lista en una posición específica
            public void Eliminar(int posicion)
            {
                if (EstaVacia())
                {
                    throw new InvalidOperationException("La lista está vacía");
                }

                if (posicion < 0)
                {
                    throw new ArgumentOutOfRangeException("Posición inválida");
                }

                if (posicion == 0)
                {
                    if (Inicio.Siguiente != null)
                    {
                        Inicio.Siguiente.Anterior = null;
                    }

                    Inicio = Inicio.Siguiente;

                    if (Inicio == null) // Si la lista quedó vacía, actualizar Fin
                    {
                        Fin = null;
                    }
                }
                else
                {
                    EliminarRecursivo(Inicio, posicion - 1);
                }
            }

            private void EliminarRecursivo(NodoDoble actual, int posicion)
            {
                if (actual == null || actual.Siguiente == null)
                {
                    throw new ArgumentOutOfRangeException("Posición inválida");
                }

                if (posicion == 0)
                {
                    NodoDoble nodoEliminar = actual.Siguiente;
                    actual.Siguiente = nodoEliminar.Siguiente;

                    if (nodoEliminar.Siguiente != null)
                    {
                        nodoEliminar.Siguiente.Anterior = actual;
                    }

                    if (nodoEliminar == Fin) // Si se elimina el último nodo, actualizar Fin
                    {
                        Fin = actual;
                    }
                }
                else
                {
                    EliminarRecursivo(actual.Siguiente, posicion - 1);
                }
            }

            // Buscar un dato en la lista de forma recursiva
            public bool Buscar(int dato)
            {
                return BuscarRecursivo(Inicio, dato);
            }

            private bool BuscarRecursivo(NodoDoble actual, int dato)
            {
                if (actual == null)
                {
                    return false;
                }

                if (actual.Dato == dato)
                {
                    return true;
                }

                return BuscarRecursivo(actual.Siguiente, dato);
            }

            // Limpiar toda la lista
            public void Limpiar()
            {
                Inicio = Fin = null;
            }

            // Recorrer y mostrar los datos de la lista de manera recursiva hacia adelante
            public void Recorrer()
            {
                RecorrerRecursivo(Inicio);
            }

            private void RecorrerRecursivo(NodoDoble actual)
            {
                if (actual != null)
                {
                    Console.WriteLine(actual.Dato);
                    RecorrerRecursivo(actual.Siguiente);
                }
            }

            // Recorrer y mostrar los datos de la lista de manera recursiva hacia atrás
            public void RecorrerInverso()
            {
                RecorrerInversoRecursivo(Fin);
            }

            private void RecorrerInversoRecursivo(NodoDoble actual)
            {
                if (actual != null)
                {
                    Console.WriteLine(actual.Dato);
                    RecorrerInversoRecursivo(actual.Anterior);
                }
            }
        }

    }
}

    




