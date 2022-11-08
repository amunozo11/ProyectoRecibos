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


        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            mostrarEscuela();
        }
    }
}
