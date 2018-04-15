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
    public partial class FModificarInf : Form
    {
        private Administradora adm;
        public FModificarInf(Administradora a)
        {
            InitializeComponent();
            adm = a;

        }

        private void FModificarInf_Load(object sender, EventArgs e)
        {

        }

        private void bottonBuscarModifInf_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(textBoxModifInf.Text);
            Infraccion inf = adm.buscarInfraccion(cod);

            if (inf == null)
            {
                MessageBox.Show("Infaccion inexistente - Ingrese a la opcion Agregar Infraccion");
            }
            else
            {
                textBoxDescModifInf.Text = inf.dameDesc();
                textBoxImporteModifInf.Text = inf.dameImporte().ToString();
                comboBoxModifInf.Text = inf.dameTipo();

                //

            }
        }
    }
}
