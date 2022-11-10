using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioLogin
    {
        readonly Datos.RepositorioLogin Rutalogin = new Datos.RepositorioLogin();
        List<Login> ListUsuarios;
        readonly RepositorioEscuela repositorioEscuela = new RepositorioEscuela();
        public ServicioLogin()
        {
            ListUsuarios = Rutalogin.Leer();
        }


        public void ActualizarList()
        {
            ListUsuarios = Rutalogin.Leer();
        }


        public string Guardar(Login usuario)
        {
            try
            {
                var estado = Rutalogin.Guardar(usuario);
                if (ListUsuarios != null)
                {
                    VerificarUsuario(usuario);
                }
                return estado ? "USUARIO REGISTRADO" : "ERROR AL REGISTRAR EL USUARIO";
            }
            catch (Exception e)
            {

                return e.Message + e.StackTrace;
            }
        }
        public string VerificarUsuario(Login usuario)
        {
            string estado = "No";
            try
            {

                foreach (var item in ListUsuarios)
                {
                    if (usuario.Usuario.Equals(item.Usuario))
                    {
                        estado = "Si";

                    }
                }

            }
            catch (Exception e)
            {

                return e.Message;
            }
            return estado;
        }
        public List<Login> Mostrar()
        {
            try
            {
                ActualizarList();
                return ListUsuarios;
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
        public bool InicioSession(string usurario,string contraseña)
        {
            bool estado=false;
            foreach (var item in Rutalogin.Leer())
            {
                if (item.Usuario.Equals(usurario) && item.Contraseña.Equals(contraseña))
                {
                    return estado=true;
                }

            }
            return estado;
        }
    }
}
