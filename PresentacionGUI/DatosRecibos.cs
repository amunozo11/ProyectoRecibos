using Entidades;
using Logica;
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
    public partial class DatosRecibos : Form
    {
        public DatosRecibos()
        {
            InitializeComponent();
        }
        Logica.ServicioRecibo logicaRecibo=new Logica.ServicioRecibo();
        Logica.ServicioEstudiante estudiantes = new ServicioEstudiante();
        PresentacionGUI.Recibo recibo = new Recibo();
        ServicioEscuela serviceEscuela = new ServicioEscuela();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
            GenerarRecibo();
        }
        void Guardar()
        {
            Entidades.Recibo recibo = new Entidades.Recibo();
            recibo.CodigoReferencia = txtReferencia.Text;
            recibo.Concepto=CbConcepto.SelectedItem.ToString();
            recibo.Cantidad = double.Parse(txtValor.Text);
            recibo.Banco = CbBanco.SelectedItem.ToString();
            recibo.FechaLimite = DateTime.Parse(DateLimete.Value.ToString());
            recibo.FechaExtraordinaria = DateTime.Parse(DateExtra.Value.ToString());
            recibo.Observaciones = txtObservacion.Text;
            recibo.Id = int.Parse(GrillaSelect.Rows[indice].Cells[0].Value.ToString());
            var mensage=logicaRecibo.Guardar(recibo);
            MessageBox.Show(mensage,"INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        void Limpiar()
        {
            txtObservacion.Clear();
            txtReferencia.Clear();
            txtReferencia.Clear();
            txtValor.Clear();
            CbBanco.SelectedIndex = -1;
            CbConcepto.SelectedIndex = -1;
            DateLimete.Text = DateTime.UtcNow.ToString();
            DateExtra.Text = DateTime.UtcNow.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        void CargarGrilla()
        {
            if (estudiantes.Mostrar() == null)
            {
                MessageBox.Show("NO HAY ESTUDIANTES  REGISTRADOS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var item in estudiantes.Mostrar())
                {
                    GrillaSelect.Rows.Add(item.Id,item.EscuelaRegistrada,item.Grado);
                }
            }
        }
        private void DatosRecibos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            labelindice.Text = indice.ToString();
            labelcolumn.Text = columna.ToString();
        }
        int indice;
        int columna;
        private void GrillaSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice=e.RowIndex;
            columna=e.ColumnIndex;
            labelcolumn.Text = GrillaSelect.Rows[indice].Cells[0].Value.ToString();
            labelindice.Text = indice.ToString();
        }
        void GenerarRecibo()
        {
            recibo.GenerarRecibo(BuscarEstudiante(),BuscarEscuela(),ReciboInfo());
            recibo.Show();
        }
        public Estudiante BuscarEstudiante()
        {
            int id;
            id = int.Parse(GrillaSelect.Rows[indice].Cells[0].Value.ToString());
            var estudianteEncontado = estudiantes.Buscar(id);
            return estudianteEncontado;
        }
        public Entidades.Escuela BuscarEscuela()
        {
            string NombreEscuela= GrillaSelect.Rows[indice].Cells[1].Value.ToString();
            var escuela = serviceEscuela.Buscar(NombreEscuela);
            return escuela;
        }
        public Entidades.Recibo ReciboInfo()
        {
            var InfoRecibo = new Entidades.Recibo();
            InfoRecibo.Cantidad = double.Parse(txtValor.Text);
            InfoRecibo.Observaciones=txtObservacion.Text;
            InfoRecibo.Banco = CbBanco.SelectedItem.ToString();
            InfoRecibo.CodigoReferencia = txtReferencia.Text;
            InfoRecibo.Concepto = CbConcepto.SelectedItem.ToString();
            InfoRecibo.FechaLimite = DateTime.Parse(DateLimete.Value.ToString());
            InfoRecibo.FechaExtraordinaria = DateTime.Parse(DateExtra.Value.ToString());
            return InfoRecibo;
        }
    }
}
