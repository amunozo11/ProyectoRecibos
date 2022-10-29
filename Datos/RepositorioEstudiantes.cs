using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
namespace Datos
{
    public class RepositorioEstudiantes: Archivos
    {
        public RepositorioEstudiantes()
        {
            ruta = "Estudiantes.txt";

        }
        public bool Guardar(Estudiante estudiante)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta,true);
                sw.WriteLine(estudiante.ToString().ToUpper());
                sw.Close();
                return true;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return true;
            }
        }
        public List<Estudiante> Leer()
        {
            try
            {
                List<Estudiante> listaEstudent = new List<Estudiante>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {

                    listaEstudent.Add(Mapear(sr.ReadLine()));
                }
                sr.Close();
                return listaEstudent;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public Estudiante Mapear(string linea)
        {
            var estudiante = new Estudiante
            {
                Nombres = linea.Trim().Split(';')[0],
                Apellidos = linea.Trim().Split(';')[1],
                Sexo = char.Parse(linea.Trim().Split(';')[2]),
                Id = int.Parse(linea.Trim().Split(';')[3]),
                curso = linea.Trim().Split(';')[4],
                Grado = linea.Trim().Split(';')[5],
                PeriodoEstudio = linea.Trim().Split(';')[6],
                PromPonderado = double.Parse(linea.Trim().Split(';')[7])
            };
            return estudiante;
        }
        public bool Eliminar(List<Estudiante>estudiantes)
        {
            bool estado;
            try
            {
                StreamWriter sw = new StreamWriter(ruta, false);
                foreach (var item in estudiantes)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
                return estado=true;
            }
            catch (Exception e)
            {
                estado=false;
                Console.WriteLine(e.Message);
            }
            return estado;
        }
    }
}
