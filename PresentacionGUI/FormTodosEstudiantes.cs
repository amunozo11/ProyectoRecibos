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
    public partial class FormTodosEstudiantes : Form
    {
        ServicioEstudiante servicioEstudiante = new ServicioEstudiante();
        public FormTodosEstudiantes()
        {
            InitializeComponent();
            CargarGrilla();
        }

        void CargarGrilla()
        {
            if (servicioEstudiante.Mostrar() == null)
            {
                MessageBox.Show("NO HAY ESTUDIANTES REGISTRADOS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var item in servicioEstudiante.Mostrar())
                {
                    GrillaEstudiantes.Rows.Add(item.Id, item.Nombres, item.Apellidos, item.Sexo,
                    item.curso, item.PeriodoEstudio, item.PromPonderado, item.EscuelaRegistrada);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        FormEditarEstudiantes formEditarEstudiante = new FormEditarEstudiantes();

        public void Editar()
        {
            formEditarEstudiante.txtId.Text = GrillaEstudiantes.CurrentRow.Cells[0].Value.ToString();
            formEditarEstudiante.txtNombre.Text = GrillaEstudiantes.CurrentRow.Cells[1].Value.ToString();
            formEditarEstudiante.txtApellidos.Text = GrillaEstudiantes.CurrentRow.Cells[2].Value.ToString();
            string hombre = GrillaEstudiantes.CurrentRow.Cells[3].Value.ToString();
            if (hombre == "M")
            {
                formEditarEstudiante.rdHombre.Checked = true;
            }
            else
            {
                formEditarEstudiante.rdMujer.Checked = true;
            }
            
            formEditarEstudiante.txtCurso.Text = GrillaEstudiantes.CurrentRow.Cells[4].Value.ToString();
            formEditarEstudiante.cbPeriodo.Text = GrillaEstudiantes.CurrentRow.Cells[5].Value.ToString();
            formEditarEstudiante.txtPromedio.Text = GrillaEstudiantes.CurrentRow.Cells[6].Value.ToString();
            formEditarEstudiante.cbEscuela.Text = GrillaEstudiantes.CurrentRow.Cells[7].Value.ToString();
            formEditarEstudiante.ShowDialog();
            RefrescarGrilla();
        }

        public void RefrescarGrilla()
        {
            GrillaEstudiantes.Rows.Clear();
            GrillaEstudiantes.Refresh();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarGeneral();
        }

        int fila;
        public void EliminarGeneral()
        {
            var pregunta = MessageBox.Show("¿Esta seguro de eliminar: " + GrillaEstudiantes.CurrentRow.Cells[1].Value.ToString() + "?", "Eliminar Escuela", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            var estudiante = new Estudiante();
            estudiante.Id = int.Parse(GrillaEstudiantes.Rows[fila].Cells[0].Value.ToString());
            if (pregunta == DialogResult.Yes)
            {
                Eliminar(estudiante);
                RefrescarGrilla();
                fila = 0;
            }
        }
        void Eliminar(Estudiante estudiante)
        {
            var mensaje = servicioEstudiante.Eliminar(estudiante);
            MessageBox.Show(mensaje);
        }
        private void GrillaEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "editarToolStripMenuItem1":
                    Editar();
                    break;
                case "borrarToolStripMenuItem":
                    contextMenuStrip1.Hide();
                    EliminarGeneral();
                    break;
            }
        }
    }
}
