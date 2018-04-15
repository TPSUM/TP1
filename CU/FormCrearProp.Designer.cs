namespace CU
{
    partial class FormCrearProp
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
            this.textBoxProp = new System.Windows.Forms.TextBox();
            this.labelProp = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxProp
            // 
            this.textBoxProp.Location = new System.Drawing.Point(266, 80);
            this.textBoxProp.Name = "textBoxProp";
            this.textBoxProp.Size = new System.Drawing.Size(100, 20);
            this.textBoxProp.TabIndex = 5;
            // 
            // labelProp
            // 
            this.labelProp.AutoSize = true;
            this.labelProp.Location = new System.Drawing.Point(106, 87);
            this.labelProp.Name = "labelProp";
            this.labelProp.Size = new System.Drawing.Size(129, 13);
            this.labelProp.TabIndex = 4;
            this.labelProp.Text = "DNI - CUIT del propietario";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(191, 127);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // FormCrearProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 405);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxProp);
            this.Controls.Add(this.labelProp);
            this.Name = "FormCrearProp";
            this.Text = "FormCrearProp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProp;
        private System.Windows.Forms.Label labelProp;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBox1;

    }
}