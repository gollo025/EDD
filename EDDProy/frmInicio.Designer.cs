
namespace EDDemo
{
    partial class frmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTRUCTURASLINEALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECURSIVIDADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pILASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructurasNoLibealesToolStripMenuItem,
            this.eSTRUCTURASLINEALESToolStripMenuItem,
            this.rECURSIVIDADToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1025, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(255, 29);
            this.estructurasNoLibealesToolStripMenuItem.Text = "ESTRUCTURAS NO LINEALES";
            this.estructurasNoLibealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasNoLibealesToolStripMenuItem_Click);
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.arbolesToolStripMenuItem.Text = "ARBOLES";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // eSTRUCTURASLINEALESToolStripMenuItem
            // 
            this.eSTRUCTURASLINEALESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pILASToolStripMenuItem,
            this.cOLASToolStripMenuItem,
            this.lISTASToolStripMenuItem});
            this.eSTRUCTURASLINEALESToolStripMenuItem.Name = "eSTRUCTURASLINEALESToolStripMenuItem";
            this.eSTRUCTURASLINEALESToolStripMenuItem.Size = new System.Drawing.Size(223, 29);
            this.eSTRUCTURASLINEALESToolStripMenuItem.Text = "ESTRUCTURAS LINEALES";
            // 
            // rECURSIVIDADToolStripMenuItem
            // 
            this.rECURSIVIDADToolStripMenuItem.Name = "rECURSIVIDADToolStripMenuItem";
            this.rECURSIVIDADToolStripMenuItem.Size = new System.Drawing.Size(151, 29);
            this.rECURSIVIDADToolStripMenuItem.Text = "RECURSIVIDAD";
            // 
            // pILASToolStripMenuItem
            // 
            this.pILASToolStripMenuItem.Name = "pILASToolStripMenuItem";
            this.pILASToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pILASToolStripMenuItem.Text = "PILAS";
            // 
            // cOLASToolStripMenuItem
            // 
            this.cOLASToolStripMenuItem.Name = "cOLASToolStripMenuItem";
            this.cOLASToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cOLASToolStripMenuItem.Text = "COLAS";
            // 
            // lISTASToolStripMenuItem
            // 
            this.lISTASToolStripMenuItem.Name = "lISTASToolStripMenuItem";
            this.lISTASToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.lISTASToolStripMenuItem.Text = "LISTAS";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 654);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "ESTRUCTURA DE DATOS";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTRUCTURASLINEALESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pILASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rECURSIVIDADToolStripMenuItem;
    }
}

