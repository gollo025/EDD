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
            strRecorrido="";
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
        public void Muestra(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            Muestra(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
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

            strRecorrido = strRecorrido + nodo.Dato + "--- ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + " --- ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + " --- ";

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

        public  void PodarArbolCompleto()
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




    }

   
}
