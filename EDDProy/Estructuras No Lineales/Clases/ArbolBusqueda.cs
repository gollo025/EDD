using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;
        NodoBinario miRaiz;



        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
            miRaiz = null;



        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;


        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {



            if (Busqueda(Dato, Nodo))
            {

                MessageBox.Show("El valor " + Dato + " ya existe en el árbol.");
            }



            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                Nodo.Dato = Dato;
                Nodo.Izq = null;
                Nodo.Der = null;

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }
        public void Muestra(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            Muestra(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "     ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            Muestra(nivel + 1, nodo.Izq);
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + "- ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + " - ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + " - ";

            return;
        }

        public bool Busqueda(int Dato, NodoBinario nodo)
        {
            if (nodo == null)
                return false;

            if (Dato < nodo.Dato)
                return Busqueda(Dato, nodo.Izq);
            else if (Dato > nodo.Dato)
                return Busqueda(Dato, nodo.Der);
            else
                return true;
        }

        public void PodarArbol(ref NodoBinario nodo)
        {
            // Si el nodo es nulo, no hay nada que podar
            if (nodo == null)
                return;

            // Recorrer recursivamente el subárbol izquierdo y derecho
            PodarArbol(ref nodo.Izq);
            PodarArbol(ref nodo.Der);

            // Una vez recorridos los subárboles, eliminamos el nodo actual
            nodo = null;
        }

        public void PodarArbolCompleto()
        {
            PodarArbol(ref Raiz);
            Raiz = null; // Finalmente, establecemos la raíz en null para indicar que el árbol está vacío
        }

        private NodoBinario EncontrarPredecesor(NodoBinario nodo)
        {
            // Encuentra el nodo con el valor máximo en el subárbol izquierdo
            while (nodo.Der != null)
            {
                nodo = nodo.Der;
            }
            return nodo;
        }

        public void EliminarNodo(int Dato)
        {
            EliminarNodo(ref Raiz, Dato);
        }

        private void EliminarNodo(ref NodoBinario nodo, int Dato)
        {
            if (nodo == null)
            {
                MessageBox.Show("El nodo no existe en el árbol.");
                return;
            }

            if (Dato < nodo.Dato)
            {
                // Eliminar en el subárbol izquierdo
                EliminarNodo(ref nodo.Izq, Dato);
            }
            else if (Dato > nodo.Dato)
            {
                // Eliminar en el subárbol derecho
                EliminarNodo(ref nodo.Der, Dato);
            }
            else // Nodo encontrado
            {
                if (nodo.Izq == null && nodo.Der == null)
                {
                    // Caso 1: Nodo sin hijos (es una hoja)
                    nodo = null;
                }
                else if (nodo.Izq == null)
                {
                    // Caso 2: Nodo con solo hijo derecho
                    nodo = nodo.Der;
                }
                else if (nodo.Der == null)
                {
                    // Caso 2: Nodo con solo hijo izquierdo
                    nodo = nodo.Izq;
                }
                else
                {
                    // Caso 3: Nodo con dos hijos
                    NodoBinario predecesor = EncontrarPredecesor(nodo.Izq);
                    nodo.Dato = predecesor.Dato; // Copiar el valor del predecesor al nodo actual
                    EliminarNodo(ref nodo.Izq, predecesor.Dato); // Eliminar el predecesor
                }
            }
        }

        public NodoBinario EncontrarSucesor(NodoBinario nodo)
        {
            if (nodo.Der != null)
            {
                NodoBinario actual = nodo.Der;
                while (actual.Izq != null)
                {
                    actual = actual.Izq;
                }
                return actual;
            }
            return null;
        }


        public void EliminarNodoSucesor(int Dato)
        {
            NodoBinario nodo = BuscarNodo(Raiz, Dato); // Encuentra el nodo con el valor especificado
            if (nodo == null)
            {
                MessageBox.Show($"El nodo con valor {Dato} no se encontró en el árbol.");
                return;
            }

            NodoBinario sucesor = EncontrarSucesor(nodo); // Encuentra el sucesor
            if (sucesor != null)
            {
                EliminarNodo(ref Raiz, sucesor.Dato); // Elimina el sucesor
            }
            else
            {
                MessageBox.Show("El nodo no tiene sucesor en el árbol.");
            }
        }

        private NodoBinario BuscarNodo(NodoBinario nodo, int valor)
        {
            if (nodo == null)
                return null;

            if (valor < nodo.Dato)
                return BuscarNodo(nodo.Izq, valor);
            else if (valor > nodo.Dato)
                return BuscarNodo(nodo.Der, valor);
            else
                return nodo;
        }

        public void RecorrerPorNiveles()
        {
            strRecorrido = ""; // Limpia el contenido anterior de strRecorrido

            if (Raiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(Raiz);

            while (cola.Count > 0)
            {
                NodoBinario nodoActual = cola.Dequeue();
                strRecorrido += nodoActual.Dato + " - ";

                if (nodoActual.Izq != null)
                {
                    cola.Enqueue(nodoActual.Izq);
                }

                if (nodoActual.Der != null)
                {
                    cola.Enqueue(nodoActual.Der);
                }
            }
        }

        public int Altura()
        {
            return Altura(Raiz);
        }

        private int Altura(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0; // Si el nodo es null, la altura es 0
            }

            int alturaIzquierda = Altura(nodo.Izq); // Altura del subárbol izquierdo
            int alturaDerecha = Altura(nodo.Der);   // Altura del subárbol derecho

            return Math.Max(alturaIzquierda, alturaDerecha) + 1; // Retorna la altura mayor + 1 para incluir el nodo actual
        }
        public int ContarHojas()
        {
            return ContarHojas(Raiz);
        }

        private int ContarHojas(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0; // Si el nodo es null, no hay hojas
            }
            if (nodo.Izq == null && nodo.Der == null)
            {
                return 1; // Es una hoja
            }

            // Suma recursiva de las hojas en los subárboles izquierdo y derecho
            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }

        public int ContarNodos()
        {
            return ContarNodos(Raiz);
        }

        private int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0; // Si el nodo es null, no hay nodo que contar
            }

            // Suma recursiva: el nodo actual (1) más los nodos en los subárboles izquierdo y derecho
            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }
        public bool EsArbolBinarioCompleto()
        {
            if (Raiz == null)
                return true; // Un árbol vacío se considera completo

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(Raiz);
            bool nodoVacioEncontrado = false; // Indica si encontramos un nodo sin hijos completos

            while (cola.Count > 0)
            {
                NodoBinario nodoActual = cola.Dequeue();

                // Verificamos el hijo izquierdo
                if (nodoActual.Izq != null)
                {
                    if (nodoVacioEncontrado)
                        return false; // Si ya se encontró un nodo vacío antes, no puede haber más hijos

                    cola.Enqueue(nodoActual.Izq);
                }
                else
                {
                    nodoVacioEncontrado = true; // Si el nodo izquierdo está vacío, activamos el indicador
                }

                // Verificamos el hijo derecho
                if (nodoActual.Der != null)
                {
                    if (nodoVacioEncontrado)
                        return false; // Si ya se encontró un nodo vacío antes, no puede haber más hijos

                    cola.Enqueue(nodoActual.Der);
                }
                else
                {
                    nodoVacioEncontrado = true; // Si el nodo derecho está vacío, activamos el indicador
                }
            }

            return true; // Si pasamos todas las verificaciones, el árbol es completo
        }


        public bool EsArbolBinarioLleno()
        {
            return EsArbolBinarioLleno(Raiz);
        }

        private bool EsArbolBinarioLleno(NodoBinario nodo)
        {
            // Si el nodo es null, es un árbol lleno por defecto
            if (nodo == null)
                return true;

            // Si el nodo es una hoja, cumple con la condición de un árbol lleno
            if (nodo.Izq == null && nodo.Der == null)
                return true;

            // Si el nodo tiene exactamente dos hijos, verificamos ambos subárboles
            if (nodo.Izq != null && nodo.Der != null)
                return EsArbolBinarioLleno(nodo.Izq) && EsArbolBinarioLleno(nodo.Der);

            // Si el nodo tiene solo un hijo, no es un árbol binario lleno
            return false;
        }


    }


}
