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
    public partial class FormularioMenu : Form
    {
        Login login = new Login();
        public FormularioMenu()
        {
            InitializeComponent();
            PersonalizacionDesing();
            
        }

        private void PersonalizacionDesing()
        {
            panelEscuelaSubMenu.Visible = false;
            panelAlumnoSubMenu.Visible = false;
            panelMenuRecibo.Visible = false;

        }

        private void OcultarSubMenu()
        {
            if (panelEscuelaSubMenu.Visible == true)
                panelEscuelaSubMenu.Visible = false;
            if (panelAlumnoSubMenu.Visible == true)
                panelAlumnoSubMenu.Visible = false;
            if (panelMenuRecibo.Visible==true)
            {
                panelMenuRecibo.Visible=false;
            }
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }



        #region Familiar
        private void btnEscuelas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelEscuelaSubMenu);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormulariosFijo(new FormAgregarEscuela());
            OcultarSubMenu();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormulariosFijo(new FormTodasEscuelas());
            OcultarSubMenu();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //mi codigo
            OcultarSubMenu();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //mi codigo
            OcultarSubMenu();
        }
        #endregion

        #region Empresarial

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelAlumnoSubMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormulariosFijo(new FormAgregarEstudiante());
            OcultarSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormulariosFijo(new FormTodosEstudiantes());
            OcultarSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //mi codigo
            OcultarSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //mi codigo
            OcultarSubMenu();
        }
        #endregion

        #region Mostrar Todos
        private void btnRecibo_Click(object sender, EventArgs e)
        {
            //mi codigo
            MostrarSubMenu(panelMenuRecibo);
        }
        #endregion


        public Form formActivo = null;
        public void FormulariosFijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelFormularioFijo.Controls.Add(formHijo);
            panelFormularioFijo.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormulariosFijo(new DatosRecibos());
            OcultarSubMenu();
        }

        private void btnListRecibos_Click(object sender, EventArgs e)
        {
            FormulariosFijo(new RecibosGenerados());
            OcultarSubMenu();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            
        }


        private void FormularioMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormularioMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
