using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class ServicioEstudiante
    {
        List<Estudiante> ListaEstudiantes ;
        readonly Datos.RepositorioEstudiantes RutaEstudiantes = new Datos.RepositorioEstudiantes();
        RepositorioEstudiantes repositorioEstudiantes = new RepositorioEstudiantes();
        public ServicioEstudiante()
        {
            ListaEstudiantes = RutaEstudiantes.Leer();
        }
        public void ActualizarLit()
        {
            ListaEstudiantes = RutaEstudiantes.Leer();
        }
        public string Guardar(Estudiante estudiante)
        {
            try
            {
                var estado = RutaEstudiantes.Guardar(estudiante);
                return estado ? $"ESTUDIANTE GUARDADO CON NOMBRE: {estudiante.Nombres}" :
                $"ERROR AL GUARDAR EL ESTDIANTE :{estudiante.Nombres}";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Estudiante> Mostrar()
        {
            /*ListaEstudiantes = RutaEstudiantes.Leer();*/
            return repositorioEstudiantes.Leer();
        }
        public string Eliminar(Estudiante estudiante)
        {
            ListaEstudiantes.Remove(estudiante);
            var estado = RutaEstudiantes.Eliminar(ListaEstudiantes);
            ActualizarLit();
            return estado ?"ESTUDIANTE ELIMINADO":"ERROR AL ELIMINAR EL ETUDIANTE";
        }
        public Estudiante Buscar(int id)
        {
            _ = new Estudiante();
            foreach (var item in ListaEstudiantes)
            {
                if (item.Id.Equals(id))
                {
                    Estudiante estudiante = item;
                    return estudiante;
                }
            }
            return null;
        }
        public  string RetirarEstudiante()
        {
            //codigo retirar
            return "";
        }
        public bool EstadoEstudiante()
        {
            //aqui codigo para verificar estado activo o  inactivo estudiante
            bool estadoEstudiante=true;
            return estadoEstudiante;
        }
    }
}
