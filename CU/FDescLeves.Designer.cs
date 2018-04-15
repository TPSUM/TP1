namespace CU
{
    partial class FDescLeves
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
            this.label1PorcDescLeves = new System.Windows.Forms.Label();
            this.label2PorcDesc10Dias = new System.Windows.Forms.Label();
            this.textBox1PorcDesc20Dias = new System.Windows.Forms.TextBox();
            this.textBox2PorcDesc10Dias = new System.Windows.Forms.TextBox();
            this.button1PorcDescLeves = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1PorcDescLeves
            // 
            this.label1PorcDescLeves.AutoSize = true;
            this.label1PorcDescLeves.Location = new System.Drawing.Point(27, 59);
            this.label1PorcDescLeves.Name = "label1PorcDescLeves";
            this.label1PorcDescLeves.Size = new System.Drawing.Size(250, 13);
            this.label1PorcDescLeves.TabIndex = 0;
            this.label1PorcDescLeves.Text = "Ingrese % de descuento por pago antes de 20 dias ";
            // 
            // label2PorcDesc10Dias
            // 
            this.label2PorcDesc10Dias.AutoSize = true;
            this.label2PorcDesc10Dias.Location = new System.Drawing.Point(27, 118);
            this.label2PorcDesc10Dias.Name = "label2PorcDesc10Dias";
            this.label2PorcDesc10Dias.Size = new System.Drawing.Size(250, 13);
            this.label2PorcDesc10Dias.TabIndex = 1;
            this.label2PorcDesc10Dias.Text = "Ingrese % de descuento por pago antes de 10 dias ";
            // 
            // textBox1PorcDesc20Dias
            // 
            this.textBox1PorcDesc20Dias.Location = new System.Drawing.Point(338, 52);
            this.textBox1PorcDesc20Dias.Name = "textBox1PorcDesc20Dias";
            this.textBox1PorcDesc20Dias.Size = new System.Drawing.Size(100, 20);
            this.textBox1PorcDesc20Dias.TabIndex = 2;
            // 
            // textBox2PorcDesc10Dias
            // 
            this.textBox2PorcDesc10Dias.Location = new System.Drawing.Point(338, 115);
            this.textBox2PorcDesc10Dias.Name = "textBox2PorcDesc10Dias";
            this.textBox2PorcDesc10Dias.Size = new System.Drawing.Size(100, 20);
            this.textBox2PorcDesc10Dias.TabIndex = 3;
            // 
            // button1PorcDescLeves
            // 
            this.button1PorcDescLeves.Location = new System.Drawing.Point(335, 223);
            this.button1PorcDescLeves.Name = "button1PorcDescLeves";
            this.button1PorcDescLeves.Size = new System.Drawing.Size(75, 23);
            this.button1PorcDescLeves.TabIndex = 4;
            this.button1PorcDescLeves.Text = "Aceptar";
            this.button1PorcDescLeves.UseVisualStyleBackColor = true;
            this.button1PorcDescLeves.Click += new System.EventHandler(this.button1PorcDescLeves_Click);
            // 
            // FDescLeves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 334);
            this.Controls.Add(this.button1PorcDescLeves);
            this.Controls.Add(this.textBox2PorcDesc10Dias);
            this.Controls.Add(this.textBox1PorcDesc20Dias);
            this.Controls.Add(this.label2PorcDesc10Dias);
            this.Controls.Add(this.label1PorcDescLeves);
            this.Name = "FDescLeves";
            this.Text = "FDescLeves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1PorcDescLeves;
        private System.Windows.Forms.Label label2PorcDesc10Dias;
        private System.Windows.Forms.TextBox textBox1PorcDesc20Dias;
        private System.Windows.Forms.TextBox textBox2PorcDesc10Dias;
        private System.Windows.Forms.Button button1PorcDescLeves;
    }
}