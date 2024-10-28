using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
 
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text), ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.Muestra(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblInOrden.Text = "";
            lblPostOrden.Text = "";
            lblPreOrden.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblInOrden.Text = "El arbol esta vacio";
                return;
            }
            lblInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblPostOrden.Text = miArbol.strRecorrido;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            // Validamos que el árbol no esté vacío
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Convertimos el valor ingresado en la caja de texto a un entero
            int valorABuscar;
            if (int.TryParse(txtDato.Text, out valorABuscar))
            {
                // Llamamos al método de búsqueda
                if (miArbol.Busqueda(valorABuscar, miRaiz))
                {
                    lblBuscado.Text = $"El valor {valorABuscar} fue encontrado en el árbol.";
                }
                else
                {
                    lblBuscado.Text = $"El valor {valorABuscar} no se encuentra en el árbol.";
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.Muestra(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void txtNodos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblPreOrden_Click(object sender, EventArgs e)
        {

        }

        private void lblPostOrden_Click(object sender, EventArgs e)
        {

        }
    }

  
    }

