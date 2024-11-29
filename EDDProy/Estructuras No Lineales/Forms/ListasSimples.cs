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

namespace EDDemo.Estructuras_No_Lineales.Forms
{

    public partial class ListasSimples : Form
    {
        private ListaSimple lista = new ListaSimple();
        public ListasSimples()
        {
            InitializeComponent();
        }

        private void ListasSimples_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtDato.Text); // txtDato se refiere a tu TextBox
                                                
            int posicion = int.Parse(txtPosicion.Text); // txtPosicion se refiere a tu TextBox
                                                         
                                                          
            lista.Insertar(dato, posicion); txtDato.Clear(); 
            
            txtPosicion.Clear(); 
            
            MostrarLista();
        }

        private void MostrarLista() { listBox1.Items.Clear();
            
            Nodo actual = lista.Inicio;
            
            while (actual != null)
            {

                listBox1.Items.Add(actual.Dato); 
                
                
                actual = actual.Sig;
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = int.Parse(txtPosicion.Text); // txtPosicion se refiere a tu TextBox
                                                            
                lista.Eliminar(posicion); txtPosicion.Clear(); 
                
                MostrarLista();

            } catch (Exception ex) 
            
            { MessageBox.Show(ex.Message);
            
            }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtDato.Text); // txtDato se refiere a tu TextBox
                                                
            bool encontrado = lista.Buscar(dato); 
            
            MessageBox.Show(encontrado ? "Dato encontrado" : "Dato no encontrado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lista.Limpiar();

            listBox1.Items.Clear();
        }
    }
}
