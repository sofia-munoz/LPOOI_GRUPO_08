using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase;

namespace Vistas
{
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            HideErrorLabels();
            bool bErrorFound = false;
            ValidateTextBoxs(ref bErrorFound);

            if (!bErrorFound)
            {
                if (MessageBox.Show("Está seguro que quiere agregar el cliente?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cliente oCliente = new Cliente(txtDni.Text, txtApellido.Text, txtNombre.Text,
                                                txtDireccion.Text, txtOSCUIT.Text, txtNroCarnet.Text);
                    MessageBox.Show("Datos del cliente: " +
                                     "\n\n DNI : " + oCliente.Cli_DNI +
                                     "\n Apellido : " + oCliente.Cli_Apellido +
                                     "\n Nombre : " + oCliente.Cli_Nombre +
                                     "\n Dirección : " + oCliente.Cli_Direccion +
                                     "\n CUIT OS: " + oCliente.OS_CUIT +
                                     "\n Nro. de Carnet : " + oCliente.Cli_NroCarnet);
                    ClearTextBoxs();
                }
                
            }
            }

        private void HideErrorLabels() 
        {
            lblValidDni.Hide();
            lblValidApellido.Hide();
            lblValidNombre.Hide();
            lblValidDireccion.Hide();
            lblValidCUIT.Hide();
            lblValidNroCarnet.Hide();
        }

        private void ClearTextBoxs()
        {
            txtDni.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtOSCUIT.Clear();
            txtNroCarnet.Clear();
        }

        private void ValidateTextBoxs(ref bool bErrorFound)
        {
            if (txtDni.Text.Length != 8)
            {
                lblValidDni.Show();
                bErrorFound = true;
            }
            if (txtApellido.Text.Length < 3)
            {
                lblValidApellido.Show();
                bErrorFound = true;
            }
            if (txtNombre.Text.Length < 3)
            {
                lblValidNombre.Show();
                bErrorFound = true;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                lblValidDireccion.Show();
                bErrorFound = true;
            }
            if (!txtOSCUIT.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtOSCUIT.Text))
            {
                lblValidCUIT.Show();
                bErrorFound = true;
            }
            if (!txtNroCarnet.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtNroCarnet.Text))
            {
                lblValidNroCarnet.Show();
                bErrorFound = true;
            }
        }
    }
}
