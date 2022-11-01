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
    public partial class FormAgregarEstudiante : Form
    {
        FormAgregarEscuela formAgregar = new FormAgregarEscuela();
        ServicioEstudiante servicioEstudiante = new ServicioEstudiante();
        public FormAgregarEstudiante()
        {
            InitializeComponent();
            IdCreciente();
            Escuela();
        }
        public void IdCreciente()
        {
            List<Estudiante> estudiantes;

            estudiantes = servicioEstudiante.Mostrar();
            if (servicioEstudiante.Mostrar() == null)
            {
                txtId.Text = "1";
                txtId.Enabled = false;
            }
            else
            {
                int size = estudiantes.Count;
                size += 1;
                txtId.Text = size.ToString();
                txtId.Enabled = false;
            }
        }

        private void FormAgregarEstudiante_Load(object sender, EventArgs e)
        {
            formAgregar.OcultarAgregar();
            
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        void Guardar()
        {
            Estudiante estudiante = new Estudiante();
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
            estudiante.PeriodoEstudio = cbPeriodo.SelectedItem.ToString();
            estudiante.PromPonderado = double.Parse(txtPromedio.Text);
            estudiante.EscuelaRegistrada = cbEscuela.SelectedItem.ToString();
            var mensaje = servicioEstudiante.Guardar(estudiante);
            MessageBox.Show(mensaje, "Regristro Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar(this, groupBox1);
            cbEscuela.SelectedIndex = -1;
            cbPeriodo.SelectedIndex = -1;
            IdCreciente();
        }
        ServicioEscuela servicioEscuela = new ServicioEscuela();
        public void Escuela()
        {
            foreach (var item in servicioEscuela.Mostrar())
            {
                cbEscuela.Items.Add(item.NombreEscuela);
            }
            
        }
        private void Limpiar(Control control, GroupBox group2)
        {
            foreach (var txt in group2.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            formAgregar.SoloLetras(e.KeyChar);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            formAgregar.SoloLetras(e.KeyChar);
        }

        private void txtPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
