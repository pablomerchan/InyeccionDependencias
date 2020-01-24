using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDependencias.Clientes
{
    public interface ICliente
    {
        string ObtenerNombreClientePorId(int idCliente);
    }
}
