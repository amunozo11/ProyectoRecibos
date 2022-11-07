using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICrud<Tipo>
    {
        string Guardar(Tipo tipo);
        List<Tipo> Mostrar();
        string Eliminar(Tipo tipo);
        string Actualizar(Tipo tipo, Tipo tipoDos);
    }
}
