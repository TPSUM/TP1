namespace CU
{
    partial class FormCrearSuceso
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
            this.labelPatente = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelCodInf = new System.Windows.Forms.Label();
            this.labelFechaSuc = new System.Windows.Forms.Label();
            this.textoModelo = new System.Windows.Forms.Label();
            this.textBoxPtente = new System.Windows.Forms.TextBox();
            this.textBoxCodI = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscarSuc = new System.Windows.Forms.Button();
            this.buttonAceptarSuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.Location = new System.Drawing.Point(46, 42);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(44, 13);
            this.labelPatente.TabIndex = 0;
            this.labelPatente.Text = "Patente";
            this.labelPatente.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(46, 85);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 1;
            this.labelModelo.Text = "Modelo";
            // 
            // labelCodInf
            // 
            this.labelCodInf.AutoSize = true;
            this.labelCodInf.Location = new System.Drawing.Point(46, 125);
            this.labelCodInf.Name = "labelCodInf";
            this.labelCodInf.Size = new System.Drawing.Size(99, 13);
            this.labelCodInf.TabIndex = 2;
            this.labelCodInf.Text = "Codigo de Infracion";
            // 
            // labelFechaSuc
            // 
            this.labelFechaSuc.AutoSize = true;
            this.labelFechaSuc.Location = new System.Drawing.Point(46, 165);
            this.labelFechaSuc.Name = "labelFechaSuc";
            this.labelFechaSuc.Size = new System.Drawing.Size(37, 13);
            this.labelFechaSuc.TabIndex = 3;
            this.labelFechaSuc.Text = "Fecha";
            // 
            // textoModelo
            // 
            this.textoModelo.AutoSize = true;
            this.textoModelo.Location = new System.Drawing.Point(132, 85);
            this.textoModelo.Name = "textoModelo";
            this.textoModelo.Size = new System.Drawing.Size(0, 13);
            this.textoModelo.TabIndex = 4;
            // 
            // textBoxPtente
            // 
            this.textBoxPtente.Location = new System.Drawing.Point(135, 35);
            this.textBoxPtente.Name = "textBoxPtente";
            this.textBoxPtente.Size = new System.Drawing.Size(100, 20);
            this.textBoxPtente.TabIndex = 5;
            // 
            // textBoxCodI
            // 
            this.textBoxCodI.Location = new System.Drawing.Point(181, 125);
            this.textBoxCodI.Name = "textBoxCodI";
            this.textBoxCodI.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodI.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(148, 165);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // buttonBuscarSuc
            // 
            this.buttonBuscarSuc.Location = new System.Drawing.Point(428, 35);
            this.buttonBuscarSuc.Name = "buttonBuscarSuc";
            this.buttonBuscarSuc.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarSuc.TabIndex = 8;
            this.buttonBuscarSuc.Text = "Buscar";
            this.buttonBuscarSuc.UseVisualStyleBackColor = true;
            this.buttonBuscarSuc.Click += new System.EventHandler(this.buttonBuscarSuc_Click);
            // 
            // buttonAceptarSuc
            // 
            this.buttonAceptarSuc.Location = new System.Drawing.Point(428, 233);
            this.buttonAceptarSuc.Name = "buttonAceptarSuc";
            this.buttonAceptarSuc.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptarSuc.TabIndex = 9;
            this.buttonAceptarSuc.Text = "Aceptar";
            this.buttonAceptarSuc.UseVisualStyleBackColor = true;
            this.buttonAceptarSuc.Click += new System.EventHandler(this.buttonAceptarSuc_Click);
            // 
            // FormCrearSuceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 305);
            this.Controls.Add(this.buttonAceptarSuc);
            this.Controls.Add(this.buttonBuscarSuc);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxCodI);
            this.Controls.Add(this.textBoxPtente);
            this.Controls.Add(this.textoModelo);
            this.Controls.Add(this.labelFechaSuc);
            this.Controls.Add(this.labelCodInf);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelPatente);
            this.Name = "FormCrearSuceso";
            this.Text = "FormCrearSuceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPatente;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelCodInf;
        private System.Windows.Forms.Label labelFechaSuc;
        private System.Windows.Forms.Label textoModelo;
        private System.Windows.Forms.TextBox textBoxPtente;
        private System.Windows.Forms.TextBox textBoxCodI;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonBuscarSuc;
        private System.Windows.Forms.Button buttonAceptarSuc;
    }
}