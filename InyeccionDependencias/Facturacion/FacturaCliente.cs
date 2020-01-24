using InyeccionDependencias.Clientes;
using InyeccionDependencias.Impuestos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDependencias.Facturacion
{
    public class FacturaCliente
    {
        //Campo de clase del tipo Facturacion
        /// <summary>
        /// Es privado y de solo lectura, para que no sea cambiado 
        /// inadvertidamente desde otra parte de esa clase después de que se haya inicializado. 
        /// El modificador de solo lectura asegura que al campo solo se le puede dar un valor 
        /// durante su inicialización o en su constructor de clase.
        /// </summary>
        private readonly IServicioFacturacion _facturacion;
        private readonly ICalculoImpuestos _calculoImpuestos;
        private readonly IInformacionCliente _informacionCliente;

        public FacturaCliente
            (
                  IServicioFacturacion servicioFacturacion, 
                  ICalculoImpuestos calculoImpuestos,
                  IInformacionCliente informacionCliente
            )
        {
            _facturacion = servicioFacturacion;
            _calculoImpuestos = calculoImpuestos;
            _informacionCliente = informacionCliente;
        }


        public double TotalFacturacion()
        {
            double response;
            var TotalAntesImpuestos= _facturacion.ValorActualServicios();
            double ivaServicios = _calculoImpuestos.ValorIva(TotalAntesImpuestos);

            response = TotalAntesImpuestos + ivaServicios;
            return response;

        }

    }
}
