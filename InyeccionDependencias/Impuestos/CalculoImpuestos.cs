using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDependencias.Impuestos
{
    public class CalculoImpuestos : ICalculoImpuestos
    {
        public double ValorIva(double precioBase)
        {
            return precioBase * 0.19;
        }
    }
}
