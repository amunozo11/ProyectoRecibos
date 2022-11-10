using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioLogin:Archivos
    {
        public RepositorioLogin()
        {
            ruta = "Usuarios.txt";
        }
        public bool Guardar(Login usuario)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(usuario.ToString().ToUpper());
                sw.Close();
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
        }


        public List<Login> Leer()
        {
            try
            {
                List<Login> ListUsuario = new List<Login>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    ListUsuario.Add(Mapear(sr.ReadLine()));
                }
                sr.Close();
                return ListUsuario;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }


        public Login Mapear(string linea)
        {
            var usuario=new Login();
            usuario.Usuario = linea.Trim().Split(';')[0];
            usuario.Contraseña = linea.Trim().Split(';')[1];
            usuario.CorreoElectronico = linea.Trim().Split(';')[2];
            return usuario;
        }
    }
}
