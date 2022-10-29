using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class PruebaEstudiante
    {
        readonly Logica.ServicioEstudiante Milogica = new Logica.ServicioEstudiante();
        readonly Logica.ServicioEscuela logicaEscuela = new Logica.ServicioEscuela();
        public void DatosEstudiantes()
        {
            var escuela = new Escuela();
            Console.WriteLine("NOMBRE ESCUELA: ");
            escuela.NombreEscuela = Console.ReadLine();
            Console.WriteLine("TELEFONO: ");
            escuela.Telefono = Console.ReadLine();
            Console.WriteLine("CORREO ESCUELA: ");
            escuela.Correo = Console.ReadLine();
            Console.WriteLine("DIRECION ESCUELA: ");
            escuela.Direccion=Console.ReadLine();
            Console.WriteLine("NIT ESCUELA: ");
            escuela.NiT = (Console.ReadLine());
            var estado=logicaEscuela.Guardar(escuela);
            Console.WriteLine(estado);
            
            //var estudiante = new Estudiante();
            //Console.WriteLine("NOMBRES: ");
            //estudiante.Nombres = Console.ReadLine();
            //Console.WriteLine("APELIDOS: ");
            //estudiante.Apellidos = Console.ReadLine();
            //Console.WriteLine("SEXO (m/f): ");
            //estudiante.Sexo = char.Parse(Console.ReadLine());
            //Console.WriteLine("ID: ");
            //estudiante.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("CURSO: ");
            //estudiante.curso = Console.ReadLine();
            //Console.WriteLine("GRADO: ");
            //estudiante.Grado = Console.ReadLine();
            //Console.WriteLine("PERIDO: ");
            //estudiante.PeriodoEstudio = Console.ReadLine();
            //Console.WriteLine("PROMEDIO: ");
            //estudiante.PromPonderado = double.Parse(Console.ReadLine());
            //string respuesta=Milogica.Guardar(estudiante);
            //Console.WriteLine(respuesta);
        }

        public void Eliminar()
        {
            Console.WriteLine("ID ESTUDIANTE A ELIMINAR:");
            int id=int.Parse(Console.ReadLine());
            string respuesta= Milogica.Eliminar(Milogica.Buscar(id));
            Console.WriteLine(respuesta);
        }
        public void EliminarEscuela()
        {
            Console.WriteLine("NIT ESCUELA A ELIMINAR:");
            string nit = Console.ReadLine();
            string respuesta = logicaEscuela.Eliminar(logicaEscuela.Buscar(nit));
            Console.WriteLine(respuesta);
        }
    }
}
