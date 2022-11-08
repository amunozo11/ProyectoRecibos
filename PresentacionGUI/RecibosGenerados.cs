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
    public partial class RecibosGenerados : Form
    {
        public RecibosGenerados()
        {
            InitializeComponent();
        }
        ServicioRecibo ServicioRecibo=new ServicioRecibo();
        void cargarGrilla()
        {
            if (ServicioRecibo.Mostrar()==null)
            {
                MessageBox.Show("NO HAY RECIBOS  REGISTRADOS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GrillaRecibosGenerados.Rows.Clear();
                foreach (var item in ServicioRecibo.Mostrar())
                {

                    GrillaRecibosGenerados.Rows.Add(item.CodigoReferencia, item.Concepto, item.Cantidad, item.FechaLimite.ToShortDateString(), item.EstadoPago);
                }
            }
        }

        private void RecibosGenerados_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Cobrar();
            cargarGrilla();
        }
        void Cobrar()
        {
            var recibo2 = BuscarRecibo();
            EstadoRecibo estadoRecibo = new EstadoRecibo();
            var estado=estadoRecibo.Estado(recibo2.CodigoReferencia);
            if (estado !=true)
            {
                recibo2.EstadoPago = "PAGADO";
                ServicioRecibo.Actualizar(BuscarRecibo(), recibo2);
            }
            else
            {
                MessageBox.Show("EL RECIBO YA FUE PAGADO","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
              
        }
        Entidades.Recibo BuscarRecibo()
        {
            var referencia = GrillaRecibosGenerados.Rows[indice].Cells[0].Value.ToString();
            var recibo=ServicioRecibo.Buscar(referencia);
            return recibo;
        }
        int indice;
        private void GrillaRecibosGenerados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice=e.RowIndex;
        }
    }
}
