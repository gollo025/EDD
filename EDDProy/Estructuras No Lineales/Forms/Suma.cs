using EDDemo.Estructuras_No_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDDemo.Estructuras_No_Lineales.Forms
{
    public partial class Suma : Form
    {
        private Recursivos recursivos = new Recursivos();




        public Suma()
        {
            InitializeComponent();

         
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
           
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            { try { int n = int.Parse(txtNumero.Text); int resultado = recursivos.SumaDeNumeros(n); 
                   
                 txtResultado.Text = $"La suma de 1 a {n} es {resultado}"; } catch (FormatException)

                { txtResultado.Text = "Por favor, ingresa un número válido."; } }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Suma_Load(object sender, EventArgs e)
        {

        }
    }

}
    
    

    
    

