using Entidades;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioEscuela
    {
        readonly Datos.RepositorioEscuela RutaEscuela=new Datos.RepositorioEscuela();
        List<Escuela> ListEscuelas;
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

                return e.Message;
            }
        }
        public List<Escuela> Mostrar()
        {
            return ListEscuelas;
        }
        public string Eliminar(Escuela escuela)
        {
            ListEscuelas.Remove(escuela);
            var estado= RutaEscuela.Eliminar(ListEscuelas);
            ActualizarList();
            return estado? $"ESCUELA ELIMINADA: {escuela.NombreEscuela}" :$"ERROR AL ELIMINAR LA ESCUELA: {escuela.NombreEscuela}";
        }
        public string Actualizar(Escuela Escuela,Escuela EscuelaActualizada)
        {
            Eliminar(Escuela);
            Guardar(EscuelaActualizada);
            ActualizarList();
            return "ESCUELA ACTUALIZADA";
        }
        public Escuela Buscar(string Nit)
        {
            _ = new Escuela();
            foreach (var item in ListEscuelas)
            {
                if (item.NiT.Equals(Nit))
                {
                    Escuela escuela = item;
                    return escuela;
                }
            }
            return null;
        }
    }
}
