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
    public partial class FormCrearVehi : Form
    {
        Administradora adm;
        Propietario prop;
        public FormCrearVehi(int patente, Administradora a)
        {
            InitializeComponent();
            this.textBoxPat.Text = patente.ToString();
            adm = a;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(this.textBoxPat.Text);
            prop = adm.buscarPropietario(id);
            if (prop == null)
            {  // Propietario inexistente

            }
            else
                MessageBox.Show("Propiestario registrado");
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            // FALTAN VALIDACIONES DE CAMPOS VACÍOS
            Vehiculo vehi = new Vehiculo(int.Parse(this.textBoxPat.Text), this.textBoxMod.Text.ToString(), prop);
            MessageBox.Show("Vehiculo creado");
            adm.agregarVehiculo(vehi);
            Close();
        }

        



        
    }
}
