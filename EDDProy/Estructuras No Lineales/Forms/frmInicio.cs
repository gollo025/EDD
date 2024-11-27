using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Estructuras_No_Lineales.Forms;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void estructurasNoLibealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lISTASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sUMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suma miSuma = new Suma();

            miSuma.MdiParent = this;

            miSuma.Show();
        }

        private void eXPONENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exponente miExpo = new Exponente();

            miExpo.MdiParent = this;

            miExpo.Show();
        }

        private void tORRESDEHANOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Torres miTorre= new Torres();

            miTorre.MdiParent = this;   

            miTorre.Show();
        }

        private void bUSQUEDABUNARIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda miBus = new Busqueda();

            miBus.MdiParent = this;

            miBus.Show();
        }

        private void fACTORIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factorial miFactorial = new Factorial();    

            miFactorial.MdiParent = this;

            miFactorial.Show();
        }

        private void fIBONACCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci fibonacci = new Fibonacci();

            fibonacci.MdiParent = this;

            fibonacci.Show();
        }
    }
}
