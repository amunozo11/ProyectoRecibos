using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EstadoRecibo:IEstado<Recibo>
    {
        RepositorioRecibos repositorio=new RepositorioRecibos();
        bool estadoDeuda;
        public bool Estado(string Referencia)
        {
            
            foreach (var item in repositorio.Leer())
            {
                if (item.CodigoReferencia.Equals(Referencia)&&item.EstadoPago.Equals("PAGADO"))
                {
                    estadoDeuda = true; 
                }
            }
            
            return estadoDeuda;
        }
    }
}
