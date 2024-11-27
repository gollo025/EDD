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
    public partial class Torres : Form
    {

         private Recursivos recursivos = new Recursivos();
        public Torres()
        {
            InitializeComponent();
        }

        private void Torres_Load(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try { int discos = int.Parse(txtNumero.Text); lstMovimientos.Items.Clear();
                
            ResolverHanoi(discos, 'A', 'B', 'C'); } 
            
            catch (FormatException) { lstMovimientos.Items.Add("Por favor, ingresa un número válido."); 
            
            }
        }

        private void ResolverHanoi(int discos, char origen, char auxiliar, char destino) { if (discos == 1) {
                lstMovimientos.Items.Add($"Mover disco de {origen} a {destino}"); }
            else { ResolverHanoi(discos - 1, origen, destino, auxiliar); 
                lstMovimientos.Items.Add($"Mover disco de {origen} a {destino}"); 
                ResolverHanoi(discos - 1, auxiliar, origen, destino); } }
    }
}

