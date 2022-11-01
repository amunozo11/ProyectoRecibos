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
    public partial class FormAgregarEscuela : Form
    {
        ServicioEscuela servicioEscuela = new ServicioEscuela();
        public FormAgregarEscuela()
        {
            InitializeComponent();
            txtTelefono.MaxLength = 10;
        }


        void Guardar()
        {
            Escuela escuela = new Escuela();
            escuela.NiT = txtNit.Text;
            escuela.NombreEscuela = txtNombre.Text;
            escuela.Direccion = txtDireccion.Text;
            escuela.Telefono = txtTelefono.Text;
            escuela.Correo = txtCorreo.Text;
            var mensaje = servicioEscuela.Guardar(escuela);
            MessageBox.Show(mensaje, "Regristro escuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar(this, groupBox1);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void FormAgregarFamiliar_Load(object sender, EventArgs e)
        {
            OcultarAgregar();

        }

        public void OcultarAgregar()
        {
            if (txtNit.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SoloLetras(e.KeyChar) == false)
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        public bool SoloLetras(char e)
        {
            if (e >= 65 && e <= 90 || e == 8 || e >= 97 && e <= 122 || e == 32 || e == 165 && e == 164)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar(this, groupBox1);
        }

        private void Limpiar(Control control, GroupBox group2)
        {
            foreach (var txt in group2.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is DateTimePicker)
                {
                    ((DateTimePicker)txt).Value = DateTime.Now;
                }
            }
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}