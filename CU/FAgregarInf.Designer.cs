namespace CU
{
    partial class FAgregarInf
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
            this.cv = new System.Windows.Forms.Label();
            this.labelDescInfrac = new System.Windows.Forms.Label();
            this.labelImporteInfrac = new System.Windows.Forms.Label();
            this.labelTipoInfrac = new System.Windows.Forms.Label();
            this.textBoxCodInfrac = new System.Windows.Forms.TextBox();
            this.textBoxDescInfrac = new System.Windows.Forms.TextBox();
            this.textBoxImporteInfrac = new System.Windows.Forms.TextBox();
            this.comboBoxTipoInfrac = new System.Windows.Forms.ComboBox();
            this.buttonCrearInfracc = new System.Windows.Forms.Button();
            this.buttonSalirAgregarInf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cv
            // 
            this.cv.AutoSize = true;
            this.cv.Location = new System.Drawing.Point(89, 66);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(49, 13);
            this.cv.TabIndex = 0;
            this.cv.Text = "CODIGO";
            // 
            // labelDescInfrac
            // 
            this.labelDescInfrac.AutoSize = true;
            this.labelDescInfrac.Location = new System.Drawing.Point(89, 117);
            this.labelDescInfrac.Name = "labelDescInfrac";
            this.labelDescInfrac.Size = new System.Drawing.Size(80, 13);
            this.labelDescInfrac.TabIndex = 1;
            this.labelDescInfrac.Text = "DESCRIPCION";
            // 
            // labelImporteInfrac
            // 
            this.labelImporteInfrac.AutoSize = true;
            this.labelImporteInfrac.Location = new System.Drawing.Point(89, 170);
            this.labelImporteInfrac.Name = "labelImporteInfrac";
            this.labelImporteInfrac.Size = new System.Drawing.Size(56, 13);
            this.labelImporteInfrac.TabIndex = 2;
            this.labelImporteInfrac.Text = "IMPORTE";
            // 
            // labelTipoInfrac
            // 
            this.labelTipoInfrac.AutoSize = true;
            this.labelTipoInfrac.Location = new System.Drawing.Point(89, 220);
            this.labelTipoInfrac.Name = "labelTipoInfrac";
            this.labelTipoInfrac.Size = new System.Drawing.Size(32, 13);
            this.labelTipoInfrac.TabIndex = 3;
            this.labelTipoInfrac.Text = "TIPO";
            // 
            // textBoxCodInfrac
            // 
            this.textBoxCodInfrac.Location = new System.Drawing.Point(248, 58);
            this.textBoxCodInfrac.Name = "textBoxCodInfrac";
            this.textBoxCodInfrac.Size = new System.Drawing.Size(143, 20);
            this.textBoxCodInfrac.TabIndex = 4;
            // 
            // textBoxDescInfrac
            // 
            this.textBoxDescInfrac.Location = new System.Drawing.Point(248, 117);
            this.textBoxDescInfrac.Name = "textBoxDescInfrac";
            this.textBoxDescInfrac.Size = new System.Drawing.Size(143, 20);
            this.textBoxDescInfrac.TabIndex = 5;
            // 
            // textBoxImporteInfrac
            // 
            this.textBoxImporteInfrac.Location = new System.Drawing.Point(248, 163);
            this.textBoxImporteInfrac.Name = "textBoxImporteInfrac";
            this.textBoxImporteInfrac.Size = new System.Drawing.Size(143, 20);
            this.textBoxImporteInfrac.TabIndex = 6;
            // 
            // comboBoxTipoInfrac
            // 
            this.comboBoxTipoInfrac.AutoCompleteCustomSource.AddRange(new string[] {
            "LEVE",
            "GRAVE"});
            this.comboBoxTipoInfrac.FormattingEnabled = true;
            this.comboBoxTipoInfrac.Items.AddRange(new object[] {
            "Leve",
            "Grave"});
            this.comboBoxTipoInfrac.Location = new System.Drawing.Point(248, 220);
            this.comboBoxTipoInfrac.Name = "comboBoxTipoInfrac";
            this.comboBoxTipoInfrac.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoInfrac.TabIndex = 7;
            // 
            // buttonCrearInfracc
            // 
            this.buttonCrearInfracc.Location = new System.Drawing.Point(426, 327);
            this.buttonCrearInfracc.Name = "buttonCrearInfracc";
            this.buttonCrearInfracc.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearInfracc.TabIndex = 8;
            this.buttonCrearInfracc.Text = "&Crear Infraccion";
            this.buttonCrearInfracc.UseVisualStyleBackColor = true;
            this.buttonCrearInfracc.Click += new System.EventHandler(this.buttonCrearInfracc_Click);
            // 
            // buttonSalirAgregarInf
            // 
            this.buttonSalirAgregarInf.Location = new System.Drawing.Point(577, 327);
            this.buttonSalirAgregarInf.Name = "buttonSalirAgregarInf";
            this.buttonSalirAgregarInf.Size = new System.Drawing.Size(75, 23);
            this.buttonSalirAgregarInf.TabIndex = 9;
            this.buttonSalirAgregarInf.Text = "&Salir";
            this.buttonSalirAgregarInf.UseVisualStyleBackColor = true;
            this.buttonSalirAgregarInf.Click += new System.EventHandler(this.buttonSalirAgregarInf_Click);
            // 
            // FAgregarInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalirAgregarInf);
            this.Controls.Add(this.buttonCrearInfracc);
            this.Controls.Add(this.comboBoxTipoInfrac);
            this.Controls.Add(this.textBoxImporteInfrac);
            this.Controls.Add(this.textBoxDescInfrac);
            this.Controls.Add(this.textBoxCodInfrac);
            this.Controls.Add(this.labelTipoInfrac);
            this.Controls.Add(this.labelImporteInfrac);
            this.Controls.Add(this.labelDescInfrac);
            this.Controls.Add(this.cv);
            this.Name = "FAgregarInf";
            this.Text = "FAgregarInf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cv;
        private System.Windows.Forms.Label labelDescInfrac;
        private System.Windows.Forms.Label labelImporteInfrac;
        private System.Windows.Forms.Label labelTipoInfrac;
        private System.Windows.Forms.TextBox textBoxCodInfrac;
        private System.Windows.Forms.TextBox textBoxDescInfrac;
        private System.Windows.Forms.TextBox textBoxImporteInfrac;
        private System.Windows.Forms.ComboBox comboBoxTipoInfrac;
        private System.Windows.Forms.Button buttonCrearInfracc;
        private System.Windows.Forms.Button buttonSalirAgregarInf;
    }
}