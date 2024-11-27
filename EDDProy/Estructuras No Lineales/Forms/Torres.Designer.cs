namespace EDDemo.Estructuras_No_Lineales.Forms
{
    partial class Torres
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lstMovimientos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(220, 123);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 26);
            this.txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "NUMERO DE DISCOS:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(350, 128);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(53, 20);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "labelB";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(350, 84);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(53, 20);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "labelA";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(350, 165);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(53, 20);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "labelC";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(41, 187);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(279, 51);
            this.btnEjecutar.TabIndex = 5;
            this.btnEjecutar.Text = "EJECUTAR";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // lstMovimientos
            // 
            this.lstMovimientos.FormattingEnabled = true;
            this.lstMovimientos.ItemHeight = 20;
            this.lstMovimientos.Location = new System.Drawing.Point(460, 84);
            this.lstMovimientos.Name = "lstMovimientos";
            this.lstMovimientos.Size = new System.Drawing.Size(328, 284);
            this.lstMovimientos.TabIndex = 6;
            // 
            // Torres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMovimientos);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Name = "Torres";
            this.Text = "Torres";
            this.Load += new System.EventHandler(this.Torres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.ListBox lstMovimientos;
    }
}