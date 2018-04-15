using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CN;

namespace CU
{
    public partial class FDescGraves : Form
    {
        private Administradora adm;
        private int porcGrave;

        public FDescGraves(Administradora a)
        {

            InitializeComponent();
            adm = a;
        }

        private void buttonPorcDescGraves_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int porcDescGraves() {
            return porcGrave;

        }

        private void textBox1PorcDescGraves_TextChanged(object sender, EventArgs e)
        {
            porcGrave = int.Parse(this.textBox1PorcDescGraves.Text);
        }
    }
}
