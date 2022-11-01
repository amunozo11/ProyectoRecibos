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
    }
}
