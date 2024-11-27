
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.lblBuscado = new System.Windows.Forms.Label();
            this.btnPodar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSucesor = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAltura = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHojas = new System.Windows.Forms.Label();
            this.btnHojas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CantidadNodos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNodos = new System.Windows.Forms.Label();
            this.btnArbolCompleto = new System.Windows.Forms.Button();
            this.btnArbolLleno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(64, 24);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(76, 38);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(155, 24);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 37);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtArbol.Location = new System.Drawing.Point(11, 248);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtArbol.Size = new System.Drawing.Size(1269, 271);
            this.txtArbol.TabIndex = 2;
            this.txtArbol.TextChanged += new System.EventHandler(this.txtArbol_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(155, 65);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 37);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(253, 24);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(93, 38);
            this.btnRecorrer.TabIndex = 3;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(253, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 38);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(114, 171);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(0, 20);
            this.lblPreOrden.TabIndex = 6;
            this.lblPreOrden.Click += new System.EventHandler(this.lblPreOrden_Click);
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(114, 197);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(0, 20);
            this.lblInOrden.TabIndex = 7;
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(114, 226);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(0, 20);
            this.lblPostOrden.TabIndex = 8;
            this.lblPostOrden.Click += new System.EventHandler(this.lblPostOrden_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Location = new System.Drawing.Point(64, 75);
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(76, 26);
            this.txtNodos.TabIndex = 9;
            this.txtNodos.ValueChanged += new System.EventHandler(this.txtNodos_ValueChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(155, 108);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(93, 35);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "PreOrden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "InOrden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "PostOrden:";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(255, 107);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(91, 35);
            this.btnGraficar.TabIndex = 14;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            // 
            // lblBuscado
            // 
            this.lblBuscado.AutoSize = true;
            this.lblBuscado.Location = new System.Drawing.Point(595, 171);
            this.lblBuscado.Name = "lblBuscado";
            this.lblBuscado.Size = new System.Drawing.Size(0, 20);
            this.lblBuscado.TabIndex = 16;
            // 
            // btnPodar
            // 
            this.btnPodar.Location = new System.Drawing.Point(352, 24);
            this.btnPodar.Name = "btnPodar";
            this.btnPodar.Size = new System.Drawing.Size(175, 38);
            this.btnPodar.TabIndex = 17;
            this.btnPodar.Text = "Podar";
            this.btnPodar.UseVisualStyleBackColor = true;
            this.btnPodar.Click += new System.EventHandler(this.btnPodar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "E.N PREDECESOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSucesor
            // 
            this.btnSucesor.Location = new System.Drawing.Point(352, 108);
            this.btnSucesor.Name = "btnSucesor";
            this.btnSucesor.Size = new System.Drawing.Size(175, 34);
            this.btnSucesor.TabIndex = 19;
            this.btnSucesor.Text = "E.N SUCESOR";
            this.btnSucesor.UseVisualStyleBackColor = true;
            this.btnSucesor.Click += new System.EventHandler(this.btnSucesor_Click);
            // 
            // btnRec
            // 
            this.btnRec.Location = new System.Drawing.Point(626, 69);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(87, 33);
            this.btnRec.TabIndex = 20;
            this.btnRec.Text = "Recorrer";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(722, 76);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(435, 26);
            this.txtRecorrido.TabIndex = 21;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 539);
            this.splitter1.TabIndex = 22;
            this.splitter1.TabStop = false;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(579, 197);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(0, 20);
            this.lblAltura.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Altura:";
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(533, 67);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(87, 34);
            this.btnAltura.TabIndex = 25;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Hojas:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblHojas
            // 
            this.lblHojas.AutoSize = true;
            this.lblHojas.Location = new System.Drawing.Point(583, 226);
            this.lblHojas.Name = "lblHojas";
            this.lblHojas.Size = new System.Drawing.Size(0, 20);
            this.lblHojas.TabIndex = 27;
            // 
            // btnHojas
            // 
            this.btnHojas.Location = new System.Drawing.Point(534, 24);
            this.btnHojas.Name = "btnHojas";
            this.btnHojas.Size = new System.Drawing.Size(86, 37);
            this.btnHojas.TabIndex = 28;
            this.btnHojas.Text = "Hojas";
            this.btnHojas.UseVisualStyleBackColor = true;
            this.btnHojas.Click += new System.EventHandler(this.btnHojas_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 29;
            this.button2.Text = "Nodos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // CantidadNodos
            // 
            this.CantidadNodos.AutoSize = true;
            this.CantidadNodos.Location = new System.Drawing.Point(689, 171);
            this.CantidadNodos.Name = "CantidadNodos";
            this.CantidadNodos.Size = new System.Drawing.Size(118, 20);
            this.CantidadNodos.TabIndex = 30;
            this.CantidadNodos.Text = "Nodo Buscado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nodos:";
            // 
            // lblNodos
            // 
            this.lblNodos.AutoSize = true;
            this.lblNodos.Location = new System.Drawing.Point(585, 171);
            this.lblNodos.Name = "lblNodos";
            this.lblNodos.Size = new System.Drawing.Size(70, 20);
            this.lblNodos.TabIndex = 32;
            this.lblNodos.Text = "buscado";
            // 
            // btnArbolCompleto
            // 
            this.btnArbolCompleto.Location = new System.Drawing.Point(626, 107);
            this.btnArbolCompleto.Name = "btnArbolCompleto";
            this.btnArbolCompleto.Size = new System.Drawing.Size(87, 35);
            this.btnArbolCompleto.TabIndex = 33;
            this.btnArbolCompleto.Text = "A.Comp";
            this.btnArbolCompleto.UseVisualStyleBackColor = true;
            this.btnArbolCompleto.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnArbolLleno
            // 
            this.btnArbolLleno.Location = new System.Drawing.Point(626, 24);
            this.btnArbolLleno.Name = "btnArbolLleno";
            this.btnArbolLleno.Size = new System.Drawing.Size(87, 37);
            this.btnArbolLleno.TabIndex = 34;
            this.btnArbolLleno.Text = "A.Lleno";
            this.btnArbolLleno.UseVisualStyleBackColor = true;
            this.btnArbolLleno.Click += new System.EventHandler(this.btnArbolLleno_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1286, 539);
            this.Controls.Add(this.btnArbolLleno);
            this.Controls.Add(this.btnArbolCompleto);
            this.Controls.Add(this.lblNodos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CantidadNodos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHojas);
            this.Controls.Add(this.lblHojas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtRecorrido);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.btnSucesor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPodar);
            this.Controls.Add(this.lblBuscado);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Label lblBuscado;
        private System.Windows.Forms.Button btnPodar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSucesor;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHojas;
        private System.Windows.Forms.Button btnHojas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label CantidadNodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNodos;
        private System.Windows.Forms.Button btnArbolCompleto;
        private System.Windows.Forms.Button btnArbolLleno;
    }
}