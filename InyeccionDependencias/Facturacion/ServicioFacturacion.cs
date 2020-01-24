using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDependencias.Facturacion
{
    public class ServicioFacturacion : IServicioFacturacion
    {
        public int ValorActualServicios()
        {
            //Aca realizo un proceso para obtener este valor
            //Se conecto a una base de datos
            // Calculo valores individuales ...
            return 100;
        }
    }

}
