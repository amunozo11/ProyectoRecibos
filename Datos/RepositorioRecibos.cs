using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
namespace Datos
{
    public class RepositorioRecibos:Archivos,ICrudDatos<Recibo>
    {
        bool Estado;
        public RepositorioRecibos()
        {
            ruta = "Recibos.txt";
        }


        public bool Guardar(Recibo recibo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(recibo.ToString());
                sw.Close();
                Estado = true;
            }
            catch (Exception e)
            {
                Estado = false;
                Console.WriteLine(e.Message);
            }
            return Estado;
        }


        public List<Recibo> Leer()
        {
            try
            {
                List<Recibo> ListRecibos = new List<Recibo>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    ListRecibos.Add(Mapear(sr.ReadLine()));
                }
                sr.Close();
                return ListRecibos;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }

        public Recibo Mapear(string Linea)
        {
            var recibo = new Recibo
            {
                Concepto = Linea.Trim().Split(';')[0],
                Cantidad = double.Parse(Linea.Trim().Split(';')[1]),
                CodigoReferencia = Linea.Trim().Split(';')[2],
                FechaLimite = DateTime.Parse(Linea.Trim().Split(';')[3]),
                FechaExtraordinaria = DateTime.Parse(Linea.Trim().Split(';')[4]),
                Banco = Linea.Trim().Split(';')[5],
                EstadoPago = bool.Parse(Linea.Trim().Split(';')[6]),
                Observaciones = Linea.Trim().Split(';')[7],
                Id = int.Parse(Linea.Trim().Split(';')[8]),
            };

            return recibo;
        }

        public bool Eliminar(List<Recibo> listaRecibos)
        {
            bool estado;
            try
            {
                StreamWriter streamWriter = new StreamWriter(ruta, false);
                foreach (var item in listaRecibos)
                {
                    streamWriter.WriteLine(item.ToString() .ToUpper());
                }
                streamWriter.Close();
                estado = true;
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
