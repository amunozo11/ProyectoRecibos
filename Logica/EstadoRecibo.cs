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
        public bool Estado(Recibo recibo)
        {
            //aqui agregar odigo para validar si el recibo fue pagado
            // 
            bool estadoDeuda = true;
            return estadoDeuda;
        }
    }
}
