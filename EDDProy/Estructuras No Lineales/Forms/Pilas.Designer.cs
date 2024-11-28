namespace EDDemo.Estructuras_No_Lineales.Forms
{
    partial class Pilas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESA:";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(146, 151);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 26);
            this.txtDato.TabIndex = 1;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(269, 89);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(94, 44);
            this.btnPush.TabIndex = 2;
            this.btnPush.Text = "PUSH";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(269, 154);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(94, 44);
            this.btnPop.TabIndex = 3;
            this.btnPop.Text = "POP";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(269, 216);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 42);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(53, 214);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 43);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "RECORRER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 20;
            this.lstDatos.Location = new System.Drawing.Point(388, 89);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(84, 344);
            this.lstDatos.TabIndex = 7;
            // 
            // Pilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.label1);
            this.Name = "Pilas";
            this.Text = "Pilas";
            this.Load += new System.EventHandler(this.Pilas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstDatos;
    }
}