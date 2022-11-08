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
    public partial class RecibosGenerados : Form
    {
        public RecibosGenerados()
        {
            InitializeComponent();
        }
        ServicioRecibo ServicioRecibo=new ServicioRecibo();
        Logica.ServicioRecibo logicaRecibo = new Logica.ServicioRecibo();
        Logica.ServicioEstudiante estudiantes = new ServicioEstudiante();

        ServicioEscuela serviceEscuela = new ServicioEscuela();
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

                    GrillaRecibosGenerados.Rows.Add(item.CodigoReferencia,item.Id,item.EscuelaRegistrada, item.Concepto, item.Cantidad, item.FechaLimite.ToShortDateString(), item.EstadoPago);
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
        public Estudiante BuscarEstudiante()
        {
            int id;
            id = int.Parse(GrillaRecibosGenerados.Rows[indice].Cells[1].Value.ToString());
            var estudianteEncontado = estudiantes.Buscar(id);
            return estudianteEncontado;
        }
        public Entidades.Escuela BuscarEscuela()
        {
            string NombreEscuela = GrillaRecibosGenerados.Rows[indice].Cells[2].Value.ToString();
            var escuela = serviceEscuela.BuscarNombre(NombreEscuela);
            return escuela;
        }
        
        int indice;
        private void GrillaRecibosGenerados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice=e.RowIndex;
        }
        void Eliminar()
        {
            ServicioRecibo.Eliminar(BuscarRecibo());
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            cargarGrilla();
        }

        private void EliminarReciboMenu_Click(object sender, EventArgs e)
        {
            Eliminar();
            cargarGrilla();
        }
        void Generate()
        {
            PresentacionGUI.Recibo recibo = new Recibo();
            try
            {
                var recibos = BuscarRecibo();
                recibo.GenerarRecibo(BuscarEstudiante(), BuscarEscuela(),recibos);
                recibo.Show();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void verRecibo_Click(object sender, EventArgs e)
        {
            Generate();
        }
    }
}
