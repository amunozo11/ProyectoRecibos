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
    public partial class Recibo : Form
    {
        ServicioEscuela ServicioEscuela = new ServicioEscuela();
        ServicioRecibo Mirecibo=new ServicioRecibo();
        public Recibo()
        {
            InitializeComponent();
            
        }
        
        public void mostrarEscuela()
        {
            var lista=ServicioEscuela.Mostrar();
            foreach (var item in lista)
            {
                labelNameEscuela.Text = item.NombreEscuela;
                lblName2.Text = item.NombreEscuela;
            }
        }
        public void GenerarRecibo(Entidades.Estudiante ReciboEstudiante,Escuela escuela,Entidades.Recibo recibo)
        {
            labelNameEscuela.Text = escuela.NombreEscuela;
            lblName2.Text = escuela.NombreEscuela;
            labeApellido.Text = ReciboEstudiante.Apellidos;
            labelNombre.Text = ReciboEstudiante.Nombres;
            labeEscuela.Text = ReciboEstudiante.EscuelaRegistrada;
            labelPeriodo.Text = ReciboEstudiante.PeriodoEstudio;
            labelObserva.Text = recibo.Observaciones;
            labelRefe.Text = recibo.CodigoReferencia;
            labelLimite.Text = recibo.FechaLimite.ToShortDateString().ToString();
            labelConcepto.Text = recibo.Concepto;
            labelCorreo.Text = escuela.Correo;
            labelDireccion.Text = escuela.Direccion;
            labelValor.Text = recibo.Cantidad.ToString();
            labelId.Text = ReciboEstudiante.Id.ToString();
            labelNitEsc.Text = escuela.NiT;
            labeLtelefono.Text=escuela.NiT.ToString();
            labelImpresion.Text = DateTime.UtcNow.ToShortDateString().ToString();
            labelnit2.Text = escuela.NiT;
            labelcedula2.Text = ReciboEstudiante.Id.ToString();
            labelBanco.Text = recibo.Banco.ToString();
            labelFechaLimite2.Text = recibo.FechaLimite.ToShortDateString().ToString();
            labelValor2.Text = recibo.Cantidad.ToString();
            labelNombre2.Text = ReciboEstudiante.Nombres.ToString();
            labelRefe2.Text = recibo.CodigoReferencia.ToString();
            labelPer2.Text = ReciboEstudiante.PeriodoEstudio.ToString();
            labelfecha3.Text = recibo.FechaLimite.ToShortDateString().ToString();

        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            mostrarEscuela();
        }
    }
}
