namespace CU
{
    partial class FormCrearVehi
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
            this.modelo = new System.Windows.Forms.Label();
            this.labelProp = new System.Windows.Forms.Label();
            this.Patente = new System.Windows.Forms.Label();
            this.textBoxMod = new System.Windows.Forms.TextBox();
            this.textBoxProp = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxPat = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modelo
            // 
            this.modelo.AutoSize = true;
            this.modelo.Location = new System.Drawing.Point(158, 122);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(42, 13);
            this.modelo.TabIndex = 0;
            this.modelo.Text = "Modelo";
            // 
            // labelProp
            // 
            this.labelProp.AutoSize = true;
            this.labelProp.Location = new System.Drawing.Point(71, 154);
            this.labelProp.Name = "labelProp";
            this.labelProp.Size = new System.Drawing.Size(129, 13);
            this.labelProp.TabIndex = 1;
            this.labelProp.Text = "DNI - CUIT del propietario";
            // 
            // Patente
            // 
            this.Patente.AutoSize = true;
            this.Patente.Location = new System.Drawing.Point(149, 87);
            this.Patente.Name = "Patente";
            this.Patente.Size = new System.Drawing.Size(44, 13);
            this.Patente.TabIndex = 1;
            this.Patente.Text = "Patente";
            // 
            // textBoxMod
            // 
            this.textBoxMod.Location = new System.Drawing.Point(236, 115);
            this.textBoxMod.Name = "textBoxMod";
            this.textBoxMod.Size = new System.Drawing.Size(100, 20);
            this.textBoxMod.TabIndex = 2;
            // 
            // textBoxProp
            // 
            this.textBoxProp.Location = new System.Drawing.Point(236, 147);
            this.textBoxProp.Name = "textBoxProp";
            this.textBoxProp.Size = new System.Drawing.Size(100, 20);
            this.textBoxProp.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(392, 145);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxPat
            // 
            this.textBoxPat.Location = new System.Drawing.Point(236, 87);
            this.textBoxPat.Name = "textBoxPat";
            this.textBoxPat.Size = new System.Drawing.Size(100, 20);
            this.textBoxPat.TabIndex = 5;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(246, 242);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // FormCrearVehi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 503);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxPat);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxProp);
            this.Controls.Add(this.textBoxMod);
            this.Controls.Add(this.Patente);
            this.Controls.Add(this.labelProp);
            this.Controls.Add(this.modelo);
            this.Name = "FormCrearVehi";
            this.Text = "FormCrearVehi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modelo;
        private System.Windows.Forms.Label labelProp;
        private System.Windows.Forms.Label Patente;
        private System.Windows.Forms.TextBox textBoxMod;
        private System.Windows.Forms.TextBox textBoxProp;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxPat;
        private System.Windows.Forms.Button buttonAceptar;
    }
}