using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recibo
    {

        public string Concepto { get; set; }
        public double Cantidad { get; set; }
        public string CodigoReferencia { get; set; }
        public DateTime FechaLimite { get; set; }
        public DateTime FechaExtraordinaria { get; set; }

        public string Banco { get; set; }
        public bool EstadoPago { get; set; }
        public string Observaciones { get; set; }

        public Escuela EscuelaRecibo
        {
            get => default;
            set
            {
            }
        }
        public override string ToString()
        {
            return $"{Concepto};{Cantidad};{CodigoReferencia};{FechaLimite}" +
                $";{FechaExtraordinaria};{Banco};{EstadoPago};{Observaciones}"; 
        }

    }
}
