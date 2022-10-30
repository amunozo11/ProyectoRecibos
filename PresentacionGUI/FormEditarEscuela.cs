using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace PresentacionGUI
{
    public partial class FormEditarEscuela : Form
    {
        ServicioEscuela servicioEscuela = new ServicioEscuela();
        FormAgregarEscuela formAgregarEscuela = new FormAgregarEscuela();

        public FormEditarEscuela()
        {
            InitializeComponent();
            txtTelefono.MaxLength = 10;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        string Nit;
        void Editar()
        {
            var escuela = new Escuela();
            var escuelaOld = servicioEscuela.Buscar(Nit);
            escuela.NiT = txtNit.Text;
            escuela.NombreEscuela = txtNombre.Text;
            escuela.Direccion = txtDireccion.Text;
            escuela.Telefono = txtTelefono.Text;
            escuela.Correo = txtCorreo.Text;

            var mensaje = servicioEscuela.Actualizar(escuelaOld, escuela);
            var r = MessageBox.Show(mensaje, "Editar Escuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(r == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void FormEditarEscuela_Load(object sender, EventArgs e)
        {
            Nit = txtNit.Text;
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            formAgregarEscuela.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (formAgregarEscuela.SoloLetras(e.KeyChar) == false)
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            formAgregarEscuela.SoloNumeros(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
