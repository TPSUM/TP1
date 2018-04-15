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
    public partial class FormPpal : Form
    {
        private Administradora adm;
        public FormPpal()
        {
            InitializeComponent();
            adm = new Administradora();


        }

        private void crearSucesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearSuceso f = new FormCrearSuceso(adm);
            f.Show();

        }

        private void agregarInfraccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAgregarInf f = new FAgregarInf(adm);
            f.Show();
        }

        private void modificarInfraccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FModificarInf f = new FModificarInf(adm);
            f.Show();
        }
    }
}
