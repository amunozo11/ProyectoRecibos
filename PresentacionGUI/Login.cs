using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Logica.ServicioLogin ServicioLogin=new Logica.ServicioLogin();

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro();
            
        }
        void Registro()
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            registrarUsuario.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            VerificarSession();
        }
        void VerificarSession()
        {
            var estado = ServicioLogin.InicioSession(txtUsuario.Text.ToUpper(),txtContraseña.Text.ToUpper());
            if (estado==true)
            {
                FormularioMenu formularioMenu = new FormularioMenu();
                formularioMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("DATOS INCORRECTOS","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
