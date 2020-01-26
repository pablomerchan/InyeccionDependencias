using InyeccionDependencias.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InyeccionDependencias1.Facturacion
{
    public class Factura : Cliente
    {
        public int IdCliente { get; set; }

        public double Iva { get; set; }
        public double TotalAntesImpuestos { get; set; }
        public double TotalConImpuestos { get; set; }

    }
}
