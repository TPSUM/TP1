namespace CU
{
    partial class FDescGraves
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
            this.label1PorcDescGraves = new System.Windows.Forms.Label();
            this.textBox1PorcDescGraves = new System.Windows.Forms.TextBox();
            this.buttonPorcDescGraves = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1PorcDescGraves
            // 
            this.label1PorcDescGraves.AutoSize = true;
            this.label1PorcDescGraves.Location = new System.Drawing.Point(145, 113);
            this.label1PorcDescGraves.Name = "label1PorcDescGraves";
            this.label1PorcDescGraves.Size = new System.Drawing.Size(121, 13);
            this.label1PorcDescGraves.TabIndex = 0;
            this.label1PorcDescGraves.Text = "Ingrese % de descuento";
            // 
            // textBox1PorcDescGraves
            // 
            this.textBox1PorcDescGraves.Location = new System.Drawing.Point(344, 113);
            this.textBox1PorcDescGraves.Name = "textBox1PorcDescGraves";
            this.textBox1PorcDescGraves.Size = new System.Drawing.Size(100, 20);
            this.textBox1PorcDescGraves.TabIndex = 1;
            this.textBox1PorcDescGraves.TextChanged += new System.EventHandler(this.textBox1PorcDescGraves_TextChanged);
            // 
            // buttonPorcDescGraves
            // 
            this.buttonPorcDescGraves.Location = new System.Drawing.Point(454, 278);
            this.buttonPorcDescGraves.Name = "buttonPorcDescGraves";
            this.buttonPorcDescGraves.Size = new System.Drawing.Size(75, 23);
            this.buttonPorcDescGraves.TabIndex = 2;
            this.buttonPorcDescGraves.Text = "Aceptar";
            this.buttonPorcDescGraves.UseVisualStyleBackColor = true;
            this.buttonPorcDescGraves.Click += new System.EventHandler(this.buttonPorcDescGraves_Click);
            // 
            // FDescGraves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPorcDescGraves);
            this.Controls.Add(this.textBox1PorcDescGraves);
            this.Controls.Add(this.label1PorcDescGraves);
            this.Name = "FDescGraves";
            this.Text = "FDescGraves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1PorcDescGraves;
        private System.Windows.Forms.TextBox textBox1PorcDescGraves;
        private System.Windows.Forms.Button buttonPorcDescGraves;
    }
}