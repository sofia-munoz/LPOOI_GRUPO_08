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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean bUserFound = false;

            Usuario oUsuario1 = new Usuario("Sofia", "1234");
            Usuario oUsuario2 = new Usuario("Juan", "5678");
            Usuario oUsuario3 = new Usuario("admin", "admin");
            
            if (oUsuario1.Usu_NombreUsuario == txtUsuario.Text && oUsuario1.Usu_Contrasenia == txtContrasenia.Text)
            {
                bUserFound = true;
            }
            else if (oUsuario2.Usu_NombreUsuario == txtUsuario.Text && oUsuario2.Usu_Contrasenia == txtContrasenia.Text)
            {
                bUserFound = true;
            }
            else if (oUsuario3.Usu_NombreUsuario == txtUsuario.Text && oUsuario3.Usu_Contrasenia == txtContrasenia.Text)
            {
                bUserFound = true;
            }

            if (bUserFound)
            {
                MessageBox.Show("Bienvenido " + txtUsuario.Text);
                Form FrmMain = new FrmPrincipal();
                this.Hide();
                FrmMain.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos de acceso incorrectos");
            }
        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            btnAceptar.Height = 30;
            btnAceptar.Width = 90;
            btnAceptar.ForeColor = Color.Red;
            btnAceptar.Font = new Font(btnAceptar.Font.Name, 10, FontStyle.Bold); 

        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.Height = 26;
            btnAceptar.Width = 87;
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Font = new Font(btnAceptar.Font.Name, 9, FontStyle.Regular);
            
        }
    }
}
