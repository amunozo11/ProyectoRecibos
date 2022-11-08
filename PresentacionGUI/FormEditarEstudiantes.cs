using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;
namespace PresentacionGUI
{
    public partial class FormEditarEstudiantes : Form
    {
        ServicioEscuela servicioEscuela = new ServicioEscuela();
        ServicioEstudiante servicioEstudiante = new ServicioEstudiante();
        public FormEditarEstudiantes()
        {
            InitializeComponent();
            Escuela();
        }

        public void Escuela()
        {
            foreach (var item in servicioEscuela.Mostrar())
            {
                cbEscuela.Items.Add(item.NombreEscuela);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        int Id;
        void Editar()
        {
            //var EscuelaNombre = servicioEscuela.Mostrar();
            //if (EscuelaNombre != null)
            //{
                var estudiante = new Estudiante();
                var estudianteOld = servicioEstudiante.Buscar(Id);
                estudiante.Id = int.Parse(txtId.Text);
                estudiante.Nombres = txtNombre.Text;
                estudiante.Apellidos = txtApellidos.Text;
                if (rdHombre.Checked)
                {
                    estudiante.Sexo = 'M';
                }
                else
                {
                    estudiante.Sexo = 'F';
                }
                estudiante.curso = txtCurso.Text;
                estudiante.Grado = txtGrado.Text;
                estudiante.PeriodoEstudio = cbPeriodo.SelectedItem.ToString();

                estudiante.EscuelaRegistrada = cbEscuela.SelectedItem.ToString();
                var mensaje = servicioEstudiante.Actualizar(estudianteOld, estudiante);
                var r = MessageBox.Show(mensaje, "Editar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (r == DialogResult.OK)
                {
                    this.Close();
                }
            //}
            //else
            //{
            //    MessageBox.Show("Necesita una escuela donde matricular al estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            //}
        }
        private void FormEditarEstudiantes_Load(object sender, EventArgs e)
        {
            Id = int.Parse(txtId.Text);
            txtId.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
