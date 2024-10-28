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
    if (nodo == null) // Si el nodo es nulo, el valor no se encuentra en el árbol
        return false;

    if (Dato < nodo.Dato) // Si el valor es menor, busca en el subárbol izquierdo
        return Busqueda(Dato, nodo.Izq);
    else if (Dato > nodo.Dato) // Si el valor es mayor, busca en el subárbol derecho
        return Busqueda(Dato, nodo.Der);
    else // Si encuentra el valor, regresa true
        return true;
}


    }
}
