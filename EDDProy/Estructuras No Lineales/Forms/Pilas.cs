using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales.Clases; // Asegúrate de usar el namespace correcto

namespace EDDemo.Estructuras_No_Lineales.Forms
{
    public partial class Pilas : Form
    {
        private Pila miPila;

        public Pilas()
        {
            InitializeComponent();
            miPila = new Pila(); // Inicializa la instancia de la clase Pila
            miPila.Inicializar(); // Asegúrate de inicializar la pila
        }

        private void Pilas_Load(object sender, EventArgs e)
        {

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtDato.Text);
                miPila.Push(dato);
                MessageBox.Show("Dato agregado correctamente");
                txtDato.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = miPila.Pop();
                MessageBox.Show($"Dato extraído: {dato}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtDato.Text);
                bool encontrado = miPila.Buscar(dato);
                MessageBox.Show(encontrado ? "Dato encontrado" : "Dato no encontrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miPila.Limpiar();
            lstDatos.Items.Clear();
            MessageBox.Show("Pila limpiada");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            RecorrerRecursivo(miPila.Top);
        }
        private void RecorrerRecursivo(Nodo actual)
        {
            if (actual != null)
            {
                lstDatos.Items.Add(actual.Dato);
                RecorrerRecursivo(actual.Sig);
            }
        }
    }
}
