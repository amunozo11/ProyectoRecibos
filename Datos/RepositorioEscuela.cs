using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioEscuela:Archivos
    {
        public RepositorioEscuela()
        {
            ruta = "Escuela.txt";
        }
        public bool Guardar(Escuela escuela)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta,true);
                sw.WriteLine(escuela.ToString().ToUpper());
                sw.Close();
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
        }
        public List<Escuela> Leer()
        {
            try
            {
                List<Escuela> ListEscuela = new List<Escuela>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    ListEscuela.Add(Mapear(sr.ReadLine()));
                }
                sr.Close();
                return ListEscuela;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }
        public Escuela Mapear(string linea)
        {
            var escuela = new Escuela
            {
                NombreEscuela = linea.Trim().Split(';')[0],
                Direccion = linea.Trim().Split(';')[1],
                NiT = linea.Trim().Split(';')[2],
                Telefono = linea.Trim().Split(';')[3],
                Correo = linea.Trim().Split(';')[4]
            };
            return escuela;
        }
        public bool Eliminar(List<Escuela> ListEscuela)
        {
            bool estado;
            try
            {
                StreamWriter sw = new StreamWriter(ruta, false);
                foreach (var item in ListEscuela)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
                return estado = true;
            }
            catch (Exception e)
            {
                estado = false;
                Console.WriteLine(e.Message);
            }
            return estado;
        }
    }
}
