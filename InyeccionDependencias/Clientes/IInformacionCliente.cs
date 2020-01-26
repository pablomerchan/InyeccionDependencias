using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDependencias.Clientes
{
    public interface IInformacionCliente
    {
        string ObtenerNombrePorId(int idCliente);
    }
}
