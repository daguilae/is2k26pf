namespace Capa_Modelo_CXP
{
    public class Cls_Compras
    {
        public int Pk_Id_Cuenta_Por_Pagar { get; set; }
        public int Fk_Id_Compra { get; set; }
        public string Cmp_Numero_Factura { get; set; }
        public string Cmp_Proveedor { get; set; }
        public int Fk_Id_Orden_Compra { get; set; }
        public decimal Cmp_Total_Compra { get; set; }
        public decimal Cmp_Monto_Pagado { get; set; }
        public decimal Cmp_Saldo_Pendiente { get; set; }
        public string Cmp_Estado { get; set; }
        public string Cmp_No_Documento { get; set; }
        public string Cmp_Tipo_Operacion { get; set; }
    }
}