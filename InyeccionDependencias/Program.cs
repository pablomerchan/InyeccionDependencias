using InyeccionDependencias.Clientes;
using InyeccionDependencias.Facturacion;
using InyeccionDependencias.Impuestos;
using System;

namespace InyeccionDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var ReporteFacturacion = new FacturaCliente
                            (
                                 new ServicioFacturacion(), 
                                 new CalculoImpuestos(),
                                 new InformacionCliente()
                            );


            var factura = ReporteFacturacion.FacturaIndividualCliente(1);
            Console.WriteLine("Identificacion cliente: " + factura.IdCliente);
            Console.WriteLine("Nombre cliente: " + factura.Nombre);
            Console.WriteLine("Total antes impuestos " + factura.TotalAntesImpuestos);
            Console.WriteLine("Valor impuestos: "+ factura.Iva);
            Console.WriteLine("Valor total con impuestos: " + factura.TotalConImpuestos);
            Console.ReadLine();

        }
    }
}
