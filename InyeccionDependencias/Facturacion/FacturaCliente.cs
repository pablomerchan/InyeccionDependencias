using InyeccionDependencias.Clientes;
using InyeccionDependencias.Impuestos;
using InyeccionDependencias1.Facturacion;

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
        private readonly IServicioFacturacion _Serviciofacturacion;
        private readonly ICalculoImpuestos _calculoImpuestos;
        private readonly IInformacionCliente _informacionCliente;

        public FacturaCliente
            (
                  IServicioFacturacion servicioFacturacion, 
                  ICalculoImpuestos calculoImpuestos,
                  IInformacionCliente informacionCliente
            )
        {
            _informacionCliente = informacionCliente;
            _Serviciofacturacion = servicioFacturacion;
            _calculoImpuestos = calculoImpuestos;
        }


        public Factura FacturaIndividualCliente(int IdCliente)
        {
            var facturaIndividual = new Factura();

            string NombreCliente = _informacionCliente.ObtenerNombrePorId(IdCliente);
            double ValorSinImpuestos=_Serviciofacturacion.ValorActualServicios(IdCliente);
            double ValorImpuestos = _calculoImpuestos.ValorIva(ValorSinImpuestos);
            double ValorConImpuestos = (ValorSinImpuestos + ValorImpuestos);

            facturaIndividual.IdCliente = IdCliente;
            facturaIndividual.Nombre = NombreCliente;
            facturaIndividual.TotalAntesImpuestos = ValorSinImpuestos;
            facturaIndividual.Iva = ValorImpuestos;
            facturaIndividual.TotalConImpuestos = ValorConImpuestos;
            
;
            return facturaIndividual;
        }

    }
}
