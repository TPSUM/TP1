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
    public partial class FormCrearSuceso : Form
    {
        private Administradora adm;
        private Vehiculo vehi;
        private Infraccion infrac;

        public FormCrearSuceso(Administradora a)
        {
            InitializeComponent();
            adm = a;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscarSuc_Click(object sender, EventArgs e)
        {
            int patente = int.Parse(this.textBoxPtente.Text);
            vehi = adm.buscarVehiculo(patente);
            if(vehi == null){ // Mostrar el otro formulario
                DialogResult result = MessageBox.Show("El vehículo ingresado no está registrado. ¿Desea registrarlo?", "Vehiculo inexistente", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    FormCrearVehi fVehi = new FormCrearVehi(patente, adm);
                    fVehi.ShowDialog();
                }                
            }
            else
                this.labelModelo.Text = vehi.Modelo.ToString();
                      
               
       
        }

        private void buttonAceptarSuc_Click(object sender, EventArgs e)
        {
            infrac = adm.buscarInfraccion(int.Parse(this.textBoxCodI.Text));
            // FALTA VALIDACION CAMPOS VACIOS
            if (infrac == null)
            {
                MessageBox.Show("ERROR - Código de infracción inválido");
            }
            else
            {
                // FALTA PONERLE VALOR A VEHICULO SI NO ESTABA REGISTRADO
                int codigo = adm.darCodigoDeSuceso();
                DateTime f = this.dateTimePicker.Value;
                Suceso suc = new Suceso(f, codigo, infrac, vehi);
                adm.agregarSuceso(suc);
                MessageBox.Show("El número de suceso es: "+ codigo);
                Close();
            }
        }


    }
}
