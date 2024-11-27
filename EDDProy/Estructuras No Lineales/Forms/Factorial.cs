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
    public partial class Factorial : Form
    {
        private Recursivos recursivos = new Recursivos(); // I
        public Factorial()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try { int numero = int.Parse(txtValor.Text); int resultado = recursivos.Factorial(numero); 
                txtResultado.Text = $"El factorial de {numero} es {resultado}"; 
            
            } catch (FormatException) { txtResultado.Text = "Por favor, ingresa un número válido."; }
        }
    }
}
    
