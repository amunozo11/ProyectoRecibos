using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioRecibo
    {
        List<Recibo> ListaRecibos;
        readonly Datos.RepositorioRecibos RutaRecibos = new Datos.RepositorioRecibos();
        public ServicioRecibo()
        {
            ListaRecibos = RutaRecibos.Leer();
        }
        public void ActualizarLit()
        {
            ListaRecibos = RutaRecibos.Leer();
        }
        public string Guardar(Recibo estudiante)
        {
            try
            {
                var estado = RutaRecibos.Guardar(estudiante);
                return estado ? $"INFORMACION DE RECIBO GUARDADA" :
                $"ERROR AL GUARDAR LA INFORMACION DEL RECIBO";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public List<Recibo> Mostrar()
        {
            return ListaRecibos;
        }
        public string Eliminar(Recibo recibo)
        {
            ListaRecibos.Remove(recibo);
            var estado = RutaRecibos.Eliminar(ListaRecibos);
            ActualizarLit();
            return estado ? "INFORMACION DE RECIBO ELIMINADA" : "ERROR AL ELIMINAR LA INFORMACION DEL RECIBO";
        }
        public Recibo Buscar(string Referencia)
        {
            _ = new Recibo();
            foreach (var item in ListaRecibos)
            {
                if (item.CodigoReferencia.Equals(Referencia))
                {
                    Recibo Reciboestudiante = item;
                    return Reciboestudiante;
                }
            }
            return null;
        }
        public bool EstadoDeuda()
        {
            //aqui agregar odigo para validar si el recibo fue pagado
            // 
            bool estadoDeuda=true;
            return estadoDeuda;
        }
        public bool GenerarRecibo()
        {
            /* aqui agregar codigo para generar recibo: si el estado del estudiante es inactivo
             no se genera el recibo, de lo contrario si*/
            bool estadoReibo=false;
            return estadoReibo;
        }
    }
}
