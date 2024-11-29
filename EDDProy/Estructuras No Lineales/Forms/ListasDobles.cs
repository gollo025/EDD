using EDDemo.Estructuras_No_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EDDemo.Estructuras_No_Lineales.Clases.ListaSimple;

namespace EDDemo.Estructuras_No_Lineales.Forms
{
    public partial class ListasDobles : Form
    {

        private ListaDoble lista = new ListaDoble();
        public ListasDobles()
        {
            InitializeComponent();
        }

        private void ListasDobles_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtDato.Text);

            int posicion = int.Parse(txtPosicion.Text);

            lista.Insertar(dato, posicion); txtDato.Clear();

            txtPosicion.Clear(); MostrarLista();
        }

        private void MostrarListaInversa()
        {
            listBox1.Items.Clear();

            NodoDoble actual = lista.Fin;

            while (actual != null)
            {
                listBox1.Items.Add(actual.Dato);

                actual = actual.Anterior;
            }
        }

        private void MostrarLista()
        {
            listBox1.Items.Clear();

            NodoDoble actual = lista.Inicio;


            while (actual != null)
            {

                listBox1.Items.Add(actual.Dato);

                actual = actual.Siguiente;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = int.Parse(txtPosicion.Text);

                lista.Eliminar(posicion);

                txtPosicion.Clear(); MostrarLista();
            }
            catch (Exception ex)

            { MessageBox.Show(ex.Message); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                int dato = int.Parse(txtDato.Text); // txtDato se refiere a tu TextBox

                bool encontrado = lista.Buscar(dato);

                MessageBox.Show(encontrado ? "Dato encontrado" : "Dato no encontrado");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarListaInversa();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lista.Limpiar(); 
            
            listBox1.Items.Clear();
        }
    }
}

