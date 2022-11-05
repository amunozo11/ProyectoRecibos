using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escuela
    {
        public string NombreEscuela { get; set; }
        public string Direccion { get; set; }
        public string NiT { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Persona EscuelaPersona
        {
            get => default;
            set
            {
            }
        }
        public override string ToString()
        {
            return $"{NombreEscuela};{Direccion};{NiT};{Telefono};{Correo}";
        }

        public static implicit operator Escuela(string v)
        {
            throw new NotImplementedException();
        }
    }
}
