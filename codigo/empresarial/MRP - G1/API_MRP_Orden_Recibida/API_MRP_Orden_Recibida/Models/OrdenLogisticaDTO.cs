namespace API_MRP.Models
{
    public class OrdenLogisticaDTO
    {
        public int idOrdenProduccion { get; set; }
        public DateTime fechaEmision { get; set; }
        public string estado { get; set; }
        public List<DetalleDTO> detalle { get; set; }
    }

    public class DetalleDTO
    {
        public string nombreProducto { get; set; }
        public decimal cantidadSolicitada { get; set; }
    }
}