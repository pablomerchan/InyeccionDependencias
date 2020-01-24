using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDependencias.Facturacion
{
    public interface IServicioFacturacion
    {
        /// <summary>
        /// Retorna el valor actual de los servicios prestados
        /// </summary>
        /// <returns></returns>
        int ValorActualServicios();
    }
}
