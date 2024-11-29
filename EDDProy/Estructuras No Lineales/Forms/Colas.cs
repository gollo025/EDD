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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDDemo.Estructuras_No_Lineales.Forms
{
    public partial class Colas : Form
    {

        private Cola cola = new Cola();
        public Colas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtDato.Text); cola.Encolar(dato);
            
            txtDato.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = cola.Desencolar();

                MessageBox.Show($"Dato desencolado: {dato}");

                MostrarCola();

            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void MostrarCola() { listBox1.Items.Clear();
            Nodo actual = cola.Frente; 
            
            while (actual != null) 
            { 
                listBox1.Items.Add(actual.Dato); 
                
                actual = actual.Sig;
            } 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                int dato = int.Parse(txtDato.Text); 
            
            bool encontrado = cola.Buscar(dato);

            MessageBox.Show(encontrado ? "Dato encontrado" : "Dato no encontrado");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarCola();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cola.Limpiar();

            listBox1.Items.Clear ();


        }
    }
}
