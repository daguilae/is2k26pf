namespace API_Logistica.Models
{
    public class OrdenMaterialMRPDTO
    {
        public int idOrdenMaterial { get; set; }

        public DateTime fechaSolicitud { get; set; }

        public List<DetalleMaterialDTO> detalle { get; set; }
    }

    public class DetalleMaterialDTO
    {
        public string nombreMaterial { get; set; }

        public float cantidadSolicitada { get; set; }
    }
}