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
    public partial class FAgregarInf : Form
    {

        private Administradora adm;
        private Infraccion infrac;
        public FAgregarInf(Administradora a)
        {
            InitializeComponent();
            adm = a;

        }

        private void buttonCrearInfracc_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(textBoxCodInfrac.Text);
            Infraccion inf = adm.buscarInfraccion(cod);
        
            if (inf != null)
            {
                MessageBox.Show("Infraccion ya existente");
            }
            else {
                //ver si  hay otra manera de trabajr esto con el combobox
                int seleccionada = comboBoxTipoInfrac.SelectedIndex;
                if (seleccionada == 0)//el primer item del combo es LEVE
                {
                    FDescLeves fdescL = new FDescLeves(adm);
                    fdescL.ShowDialog();
                    int porc10Dias = fdescL.porcDesc10Dias();
                    int porc20Dias = fdescL.porcDesc20Dias();
                    infrac = new Leve(porc20Dias, porc10Dias, cod, textBoxDescInfrac.Text, float.Parse(textBoxImporteInfrac.Text));

                    //MessageBox.Show(infrac.ToString());

                }
                else { //el segundo item del combo el GRAVE
                    FDescGraves fDescG = new FDescGraves(adm);
                    fDescG.ShowDialog();
                    int porDesc = fDescG.porcDescGraves();
                    infrac = new Grave(porDesc, cod, textBoxDescInfrac.Text, float.Parse(textBoxImporteInfrac.Text));
                    //MessageBox.Show(infrac.ToString());

                }
                adm.agregarInfraccion(infrac);
                MessageBox.Show("Infraccion creada con exito");

            } 
            
            
           /* foreach (Infraccion f in adm.darInfracciones()) {
                MessageBox.Show(f.ToString());
            }*/
            
        }

        private void buttonSalirAgregarInf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*  private void comboBoxTipoInfrac_SelectedIndexChanged(object sender, EventArgs e)
          {
              Object seleccionada = comboBoxTipoInfrac.SelectedItem;

          }*/
    }
}
