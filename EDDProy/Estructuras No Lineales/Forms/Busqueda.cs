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
    public partial class Busqueda : Form
    {
        private Recursivos recursivos = new Recursivos(); // Instanci
        public Busqueda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { int[] array = txtArreglo.Text.Split(',').Select(int.Parse).ToArray();
                int objetivo = int.Parse(txtValor.Text); 
                
                int resultado = recursivos.BusquedaBinaria(array, 0, array.Length - 1, objetivo); 
                
                if (resultado != -1) { txtResultado.Text = $"Valor encontrado en el índice {resultado}";
                } else { txtResultado.Text = "Valor no encontrado";
                } } catch (FormatException) 
            
            { txtResultado.Text = "Por favor, ingresa números válidos y separados por comas."; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Busqueda_Load(object sender, EventArgs e)
        {

        }
    
}
    
}
