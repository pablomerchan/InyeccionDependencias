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
        /// Si es privado y de solo lectura, el beneficio es que no puede cambiarlo 
        /// inadvertidamente desde otra parte de esa clase después de que se haya inicializado. 
        /// El modificador de solo lectura asegura que al campo solo se le puede dar un valor 
        /// durante su inicialización o en su constructor de clase.
        /// Si algo no debería cambiar funcionalmente después de la inicialización, 
        /// siempre es una buena práctica usar construcciones de lenguaje disponibles 
        /// para hacer cumplir
        /// </summary>
        private readonly IServicioFacturacion _facturacion;
        private readonly ICalculoImpuestos _calculoImpuestos;

        public FacturaCliente(IServicioFacturacion servicioFacturacion, ICalculoImpuestos calculoImpuestos)
        {
            _facturacion = servicioFacturacion;
            _calculoImpuestos = calculoImpuestos;
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
