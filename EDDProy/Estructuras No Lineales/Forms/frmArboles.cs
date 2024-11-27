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
            txtArbol.Text = "";
            txtDato.Text = "";
            lblInOrden.Text = "";
            lblPostOrden.Text = "";
            lblPreOrden.Text = "";
            lblBuscado = null;
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

                miRaiz = miArbol.RegresaRaiz();


                miArbol.InsertaNodo(Dato, ref miRaiz);
            }


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

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void btnPodar_Click(object sender, EventArgs e)
        {

            miArbol.PodarArbolCompleto();

            MessageBox.Show("El árbol ha sido podado exitosamente.");

            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
            lblInOrden.Text = "";
            lblPostOrden.Text = "";
            lblPreOrden.Text = "";
            lblBuscado = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (int.TryParse(txtDato.Text, out int valor)) // Convierte el texto a un número entero
            {
                miArbol.EliminarNodo(valor); // Llama al método EliminarNodoPredecesor con el valor ingresado
                MessageBox.Show($"El predecesor del nodo con valor {valor} ha sido eliminado del árbol.");

                // Actualiza la visualización del árbol
                miArbol.strArbol = ""; // Limpia el contenido anterior de strArbol
                miArbol.Muestra(0, miArbol.RegresaRaiz()); // Llama a Muestra para regenerar el árbol en strArbol

                // Muestra el árbol actualizado en el TextBox o Label correspondiente
                txtArbol.Text = miArbol.strArbol; // txtArbol es el control donde muestras el árbol en el formulario
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo de texto.");
            }


        }

        private void txtArbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSucesor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor)) // Convierte el texto a un número entero
            {
                miArbol.EliminarNodoSucesor(valor); // Llama al método EliminarNodoSucesor con el valor ingresado
                MessageBox.Show($"El sucesor del nodo con valor {valor} ha sido eliminado del árbol.");

                // Actualiza la visualización del árbol
                miArbol.strArbol = ""; // Limpia el contenido anterior de strArbol
                miArbol.Muestra(0, miArbol.RegresaRaiz()); // Llama a Muestra para regenerar el árbol en strArbol

                // Muestra el árbol actualizado en el TextBox o Label correspondiente
                txtArbol.Text = miArbol.strArbol; // txtArbol es el control donde muestras el árbol en el formulario
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo de texto.");
            }
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            miArbol.RecorrerPorNiveles();
            txtRecorrido.Text = miArbol.strRecorrido; // txtRecorrido es el control donde muestras el recorrido en el formulario
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            int altura = miArbol.Altura();
            lblAltura.Text = altura.ToString(); // txtAltura es el control donde muestras la altura en el formulario
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            int cantidadNodos = miArbol.ContarNodos();
            lblNodos.Text = cantidadNodos.ToString(); // txtNodos es el control donde muestras la cantidad de nodos en el formulario
        }

        private void btnHojas_Click(object sender, EventArgs e)
        {
            int cantidadHojas = miArbol.ContarHojas();
            lblHojas.Text = cantidadHojas.ToString(); // txtHojas es el control donde muestras la cantidad de hojas en el formulario
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArbolBusqueda arbol = new ArbolBusqueda(); // Asegúrate de que "arbol" sea una instancia del árbol que estás utilizando
            bool esCompleto = arbol.EsArbolBinarioCompleto();

            if (esCompleto)
                MessageBox.Show("El árbol es un árbol binario completo.");
            else
                MessageBox.Show("El árbol no es un árbol binario completo.");
        }

        private void btnArbolLleno_Click(object sender, EventArgs e)
        {

            ArbolBusqueda arbol = new ArbolBusqueda(); // Asegúrate de que "arbol" sea la instancia del árbol que estás utilizando
            bool esLleno = arbol.EsArbolBinarioLleno();

            if (esLleno)
                MessageBox.Show("El árbol es un árbol binario lleno.");
            else
                MessageBox.Show("El árbol no es un árbol binario lleno.");

        }
    }



    }


    
  

    

