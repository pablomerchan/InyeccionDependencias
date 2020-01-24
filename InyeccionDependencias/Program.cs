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

            Console.WriteLine(ReporteFacturacion.TotalFacturacion());
            Console.ReadLine();

        }
    }
}
