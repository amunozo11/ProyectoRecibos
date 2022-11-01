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
        public Recibo()
        {
            InitializeComponent();
            
        }
        void mostrarEscuela()
        {
            var lista=ServicioEscuela.Mostrar();
            foreach (var item in lista)
            {
                labelNameEscuela.Text=item.NombreEscuela;
                lblName2.Text=item.NombreEscuela;
            }
        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            mostrarEscuela();
        }
    }
}
