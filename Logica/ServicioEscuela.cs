using Entidades;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class ServicioEscuela: ICrud<Escuela>
    {
        readonly Datos.RepositorioEscuela RutaEscuela=new Datos.RepositorioEscuela();
        List<Escuela> ListEscuelas;
        readonly RepositorioEscuela repositorioEscuela = new RepositorioEscuela();
        public ServicioEscuela()
        {
            ListEscuelas=RutaEscuela.Leer();
        }


        public void ActualizarList()
        {
            ListEscuelas = RutaEscuela.Leer();
        }


        public string Guardar(Escuela escuela)
        {
            try
            {
                var estado= RutaEscuela.Guardar(escuela);
                return estado ? "ESCUELA REGISTRADA" : "ERROR AL REGISTRAR LA ESCUELA";
            }
            catch (Exception e)
            {

                return e.Message + e.StackTrace;
            }
        }


        public List<Escuela> Mostrar()
        {
            try
            {
                ActualizarList();
                return ListEscuelas;
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }


        public string Eliminar(Escuela escuela)
        {
            try
            {
                var Nit = Buscar(escuela.NiT);
                ListEscuelas.Remove(Nit);
                var estado = RutaEscuela.Eliminar(ListEscuelas);
                ActualizarList();
                return estado ? $"ESCUELA ELIMINADA: {escuela.NombreEscuela}" : $"ERROR AL ELIMINAR LA ESCUELA: {escuela.NombreEscuela}";
            }
            catch (Exception e)
            {

                return e.Message + e.StackTrace;
            }
        }


        public string Actualizar(Escuela Escuela,Escuela EscuelaActualizada)
        {
            try
            {
                Eliminar(Escuela);
                Guardar(EscuelaActualizada);
                ActualizarList();
                return "ESCUELA ACTUALIZADA";
            }
            catch (Exception e)
            {

                return e.Message + e.StackTrace;
            }
        }


        public Escuela Buscar(string Nombre)
        {
            try
            {
                _ = new Escuela();
                foreach (var item in ListEscuelas)
                {
                    if (item.NombreEscuela.Trim().Equals(Nombre.ToUpper()))
                    {
                        Escuela escuela = item;
                        return escuela;
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                return e.Message + e.StackTrace;
            }
        }


    }
}
