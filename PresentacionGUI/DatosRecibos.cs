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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
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
    }
}
