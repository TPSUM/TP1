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
    public partial class FDescLeves : Form
    {
        private Administradora adm;
        private int porcDesc20D;
        private int porcDesc10D;

        public FDescLeves(Administradora a)
        {
            InitializeComponent();
            adm = a;

        }

        private void button1PorcDescLeves_Click(object sender, EventArgs e)
        {
            porcDesc20D = int.Parse(this.textBox1PorcDesc20Dias.Text);
            porcDesc10D = int.Parse(this.textBox2PorcDesc10Dias.Text);
            this.Close();
          
        }
        //faltan poner las ecepciones por sin nocompletan los campos
        public int porcDesc20Dias() {

            return porcDesc20D;
        }
        public int porcDesc10Dias() {

            return porcDesc10D;
        }
    }
}
