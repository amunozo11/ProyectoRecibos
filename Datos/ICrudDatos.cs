using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICrudDatos<Tipo>
    {
        bool Guardar(Tipo tipo);
        List<Tipo> Leer();
        Tipo Mapear(string linea);
        bool Eliminar(List<Tipo> List);
    }
}
