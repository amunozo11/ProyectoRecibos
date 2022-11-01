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
    public partial class FormTodasEscuelas : Form
    {
        ServicioEscuela servicioEscuela = new ServicioEscuela();
        FormEditarEscuela formEditarEscuela = new FormEditarEscuela();
        
        public FormTodasEscuelas()
        {
            InitializeComponent();
            CargarGrilla();
        }

        void CargarGrilla()
        {
            foreach(var item in servicioEscuela.GrillaCarga())
            {
                GrillaEscuela.Rows.Add(item.NiT, item.NombreEscuela, item.Direccion, item.Telefono, item.Correo);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        public void Editar()
        {
            formEditarEscuela.txtNit.Text = GrillaEscuela.CurrentRow.Cells[0].Value.ToString();
            formEditarEscuela.txtNombre.Text = GrillaEscuela.CurrentRow.Cells[1].Value.ToString();
            formEditarEscuela.txtDireccion.Text = GrillaEscuela.CurrentRow.Cells[2].Value.ToString();
            formEditarEscuela.txtTelefono.Text = GrillaEscuela.CurrentRow.Cells[3].Value.ToString();
            formEditarEscuela.txtCorreo.Text = GrillaEscuela.CurrentRow.Cells[4].Value.ToString();
            formEditarEscuela.ShowDialog();
            RefrescarGrilla();
        }

        public void RefrescarGrilla()
        {
            GrillaEscuela.Rows.Clear();
            GrillaEscuela.Refresh();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarGeneral();
        }
        int fila;
        public void EliminarGeneral()
        {
            var pregunta = MessageBox.Show("¿Esta seguro de eliminar: " + GrillaEscuela.CurrentRow.Cells[1].Value.ToString() + "?", "Eliminar Escuela", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            var escuela = new Escuela();
            escuela.NiT = GrillaEscuela.Rows[fila].Cells[0].Value.ToString();
            if(pregunta == DialogResult.Yes)
            {
                Eliminar(escuela);
                RefrescarGrilla();
                fila = 0;
            }
        }

        void Eliminar(Escuela escuela)
        {
            //var nit = servicioEscuela.Buscar(escuela.NiT);
            var mensaje = servicioEscuela.Eliminar(escuela);
            MessageBox.Show(mensaje);
        }

        private void GrillaEscuela_CellClick(object sender, DataGridViewCellEventArgs e)
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
