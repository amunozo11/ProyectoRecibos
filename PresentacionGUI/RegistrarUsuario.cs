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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }
        Logica.ServicioLogin ServicioLogin = new Logica.ServicioLogin();
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            salir();
        }
        void salir()
        {
            this.Close();
            Login login = new Login();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            guardarUsuario();
        }
        void guardarUsuario()
        {
            var usuario = new Entidades.Login();
            usuario.Usuario=txtUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.CorreoElectronico = txtCorreoL.Text;
            var mensage=ServicioLogin.Guardar(usuario);
            MessageBox.Show(mensage, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
