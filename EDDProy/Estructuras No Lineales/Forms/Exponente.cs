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
    public partial class Exponente : Form
    {

        private Recursivos recursivos = new Recursivos(); // Instancia de la clase Recursivos
        public Exponente()
        {
            InitializeComponent();

           
    }

        private void Exponente_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try { int baseNum = int.Parse(txtBase.Text); int exponente = int.Parse(txtExpo.Text);
                
                int resultado = recursivos.CalculoDeExponente(baseNum, exponente); 
                
                txtResultado.Text = $"{baseNum} elevado a {exponente} es {resultado}"; 
            } catch (FormatException) { txtResultado.Text = "Por favor, ingresa números válidos."; }
        }
    }
}
    

