namespace CU
{
    partial class FModificarInf
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
            this.labelCodModifInf = new System.Windows.Forms.Label();
            this.textBoxModifInf = new System.Windows.Forms.TextBox();
            this.bottonBuscarModifInf = new System.Windows.Forms.Button();
            this.labelDescModifInf = new System.Windows.Forms.Label();
            this.textBoxDescModifInf = new System.Windows.Forms.TextBox();
            this.labelImporteModifInf = new System.Windows.Forms.Label();
            this.textBoxImporteModifInf = new System.Windows.Forms.TextBox();
            this.labelTipoModifInf = new System.Windows.Forms.Label();
            this.comboBoxModifInf = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelCodModifInf
            // 
            this.labelCodModifInf.AutoSize = true;
            this.labelCodModifInf.Location = new System.Drawing.Point(103, 60);
            this.labelCodModifInf.Name = "labelCodModifInf";
            this.labelCodModifInf.Size = new System.Drawing.Size(40, 13);
            this.labelCodModifInf.TabIndex = 0;
            this.labelCodModifInf.Text = "Codigo";
            // 
            // textBoxModifInf
            // 
            this.textBoxModifInf.Location = new System.Drawing.Point(228, 60);
            this.textBoxModifInf.Name = "textBoxModifInf";
            this.textBoxModifInf.Size = new System.Drawing.Size(100, 20);
            this.textBoxModifInf.TabIndex = 1;
            // 
            // bottonBuscarModifInf
            // 
            this.bottonBuscarModifInf.Location = new System.Drawing.Point(411, 58);
            this.bottonBuscarModifInf.Name = "bottonBuscarModifInf";
            this.bottonBuscarModifInf.Size = new System.Drawing.Size(75, 23);
            this.bottonBuscarModifInf.TabIndex = 2;
            this.bottonBuscarModifInf.Text = "Buscar";
            this.bottonBuscarModifInf.UseVisualStyleBackColor = true;
            this.bottonBuscarModifInf.Click += new System.EventHandler(this.bottonBuscarModifInf_Click);
            // 
            // labelDescModifInf
            // 
            this.labelDescModifInf.AutoSize = true;
            this.labelDescModifInf.Location = new System.Drawing.Point(103, 121);
            this.labelDescModifInf.Name = "labelDescModifInf";
            this.labelDescModifInf.Size = new System.Drawing.Size(63, 13);
            this.labelDescModifInf.TabIndex = 3;
            this.labelDescModifInf.Text = "Descripcion";
            // 
            // textBoxDescModifInf
            // 
            this.textBoxDescModifInf.Location = new System.Drawing.Point(228, 114);
            this.textBoxDescModifInf.Name = "textBoxDescModifInf";
            this.textBoxDescModifInf.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescModifInf.TabIndex = 4;
            // 
            // labelImporteModifInf
            // 
            this.labelImporteModifInf.AutoSize = true;
            this.labelImporteModifInf.Location = new System.Drawing.Point(103, 183);
            this.labelImporteModifInf.Name = "labelImporteModifInf";
            this.labelImporteModifInf.Size = new System.Drawing.Size(42, 13);
            this.labelImporteModifInf.TabIndex = 5;
            this.labelImporteModifInf.Text = "Importe";
            // 
            // textBoxImporteModifInf
            // 
            this.textBoxImporteModifInf.Location = new System.Drawing.Point(228, 183);
            this.textBoxImporteModifInf.Name = "textBoxImporteModifInf";
            this.textBoxImporteModifInf.Size = new System.Drawing.Size(100, 20);
            this.textBoxImporteModifInf.TabIndex = 6;
            // 
            // labelTipoModifInf
            // 
            this.labelTipoModifInf.AutoSize = true;
            this.labelTipoModifInf.Location = new System.Drawing.Point(103, 248);
            this.labelTipoModifInf.Name = "labelTipoModifInf";
            this.labelTipoModifInf.Size = new System.Drawing.Size(28, 13);
            this.labelTipoModifInf.TabIndex = 7;
            this.labelTipoModifInf.Text = "Tipo";
            // 
            // comboBoxModifInf
            // 
            this.comboBoxModifInf.AutoCompleteCustomSource.AddRange(new string[] {
            "Leve",
            "Grave"});
            this.comboBoxModifInf.FormattingEnabled = true;
            this.comboBoxModifInf.Location = new System.Drawing.Point(228, 248);
            this.comboBoxModifInf.Name = "comboBoxModifInf";
            this.comboBoxModifInf.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModifInf.TabIndex = 8;
            // 
            // FModificarInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxModifInf);
            this.Controls.Add(this.labelTipoModifInf);
            this.Controls.Add(this.textBoxImporteModifInf);
            this.Controls.Add(this.labelImporteModifInf);
            this.Controls.Add(this.textBoxDescModifInf);
            this.Controls.Add(this.labelDescModifInf);
            this.Controls.Add(this.bottonBuscarModifInf);
            this.Controls.Add(this.textBoxModifInf);
            this.Controls.Add(this.labelCodModifInf);
            this.Name = "FModificarInf";
            this.Text = "FModificarInf";
            this.Load += new System.EventHandler(this.FModificarInf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodModifInf;
        private System.Windows.Forms.TextBox textBoxModifInf;
        private System.Windows.Forms.Button bottonBuscarModifInf;
        private System.Windows.Forms.Label labelDescModifInf;
        private System.Windows.Forms.TextBox textBoxDescModifInf;
        private System.Windows.Forms.Label labelImporteModifInf;
        private System.Windows.Forms.TextBox textBoxImporteModifInf;
        private System.Windows.Forms.Label labelTipoModifInf;
        private System.Windows.Forms.ComboBox comboBoxModifInf;
    }
}