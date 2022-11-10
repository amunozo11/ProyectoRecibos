using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string CorreoElectronico { get; set; }
        public override string ToString()
        {
            return $"{Usuario};{Contraseña};{CorreoElectronico}"; 
        }

    }
}
