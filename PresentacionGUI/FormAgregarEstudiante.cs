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
            //IdCreciente();
            Escuela();
        }
        //public void IdCreciente()
        //{
        //    List<Estudiante> estudiantes;

        //    estudiantes = servicioEstudiante.Mostrar();
        //    if (servicioEstudiante.Mostrar() == null)
        //    {
        //        txtId.Text = "1";
        //        txtId.Enabled = false;
        //    }
        //    else
        //    {
        //        int size = estudiantes.Count;
        //        size += 1;
        //        txtId.Text = size.ToString();
        //        txtId.Enabled = false;
        //    }
        //}

        private void FormAgregarEstudiante_Load(object sender, EventArgs e)
        {
            //formAgregar.OcultarAgregar();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        void Guardar()
        {
            if (txtId.Text==""||txtNombre.Text==""||txtApellidos.Text==""||txtCurso.Text==""||cbPeriodo.Text==""||cbEscuela.Text=="")
            {
                MessageBox.Show("FALTAN DATOS POR COMPLETAR", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
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
                    estudiante.Grado = txtGrado.Text;
                    estudiante.PeriodoEstudio = cbPeriodo.SelectedItem.ToString();
                    estudiante.EscuelaRegistrada = cbEscuela.SelectedItem.ToString();
                    estudiante.TieneRecibo = false;
                    var mensaje = servicioEstudiante.Guardar(estudiante);
                    MessageBox.Show(mensaje.ToUpper(), "Regristro Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar(this, panelEstudiantes);
                    //IdCreciente();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }


        ServicioEscuela servicioEscuela = new ServicioEscuela();
        public void Escuela()
        {
            var EscuelaNombre = servicioEscuela.Mostrar();
            if (EscuelaNombre != null)
            {
                foreach (var item in EscuelaNombre)
                {
                    cbEscuela.Items.Add(item.NombreEscuela);
                }
            }
        }
        private void Limpiar(Control control, Panel group2)
        {
            foreach (var txt in group2.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                    rdMujer.Checked = false;
                    rdHombre.Checked = false;
                    cbEscuela.SelectedIndex = -1;
                    cbPeriodo.SelectedIndex = -1;
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(this, panelEstudiantes);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
