using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDependencias.Impuestos
{
    public interface ICalculoImpuestos
    {
        double ValorIva(double precioBase);
    }
}
