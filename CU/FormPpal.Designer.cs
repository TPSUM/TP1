namespace CU
{
    partial class FormPpal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infraccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarInfraccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarInfraccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearSucesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarDeudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infraccionToolStripMenuItem,
            this.sucesosToolStripMenuItem,
            this.pagarToolStripMenuItem,
            this.listarDeudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infraccionToolStripMenuItem
            // 
            this.infraccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarInfraccionToolStripMenuItem,
            this.modificarInfraccionToolStripMenuItem});
            this.infraccionToolStripMenuItem.Name = "infraccionToolStripMenuItem";
            this.infraccionToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.infraccionToolStripMenuItem.Text = "Infraccion";
            // 
            // agregarInfraccionToolStripMenuItem
            // 
            this.agregarInfraccionToolStripMenuItem.Name = "agregarInfraccionToolStripMenuItem";
            this.agregarInfraccionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.agregarInfraccionToolStripMenuItem.Text = "Agregar infraccion";
            this.agregarInfraccionToolStripMenuItem.Click += new System.EventHandler(this.agregarInfraccionToolStripMenuItem_Click);
            // 
            // modificarInfraccionToolStripMenuItem
            // 
            this.modificarInfraccionToolStripMenuItem.Name = "modificarInfraccionToolStripMenuItem";
            this.modificarInfraccionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modificarInfraccionToolStripMenuItem.Text = "Modificar Infraccion";
            this.modificarInfraccionToolStripMenuItem.Click += new System.EventHandler(this.modificarInfraccionToolStripMenuItem_Click);
            // 
            // sucesosToolStripMenuItem
            // 
            this.sucesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearSucesoToolStripMenuItem});
            this.sucesosToolStripMenuItem.Name = "sucesosToolStripMenuItem";
            this.sucesosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sucesosToolStripMenuItem.Text = "Sucesos";
            // 
            // crearSucesoToolStripMenuItem
            // 
            this.crearSucesoToolStripMenuItem.Name = "crearSucesoToolStripMenuItem";
            this.crearSucesoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.crearSucesoToolStripMenuItem.Text = "Crear Suceso";
            this.crearSucesoToolStripMenuItem.Click += new System.EventHandler(this.crearSucesoToolStripMenuItem_Click);
            // 
            // pagarToolStripMenuItem
            // 
            this.pagarToolStripMenuItem.Name = "pagarToolStripMenuItem";
            this.pagarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.pagarToolStripMenuItem.Text = "Pagar";
            // 
            // listarDeudaToolStripMenuItem
            // 
            this.listarDeudaToolStripMenuItem.Name = "listarDeudaToolStripMenuItem";
            this.listarDeudaToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.listarDeudaToolStripMenuItem.Text = "Listar Deuda";
            // 
            // FormPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 374);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPpal";
            this.Text = "Formulario principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infraccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarInfraccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarInfraccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearSucesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarDeudaToolStripMenuItem;
    }
}

