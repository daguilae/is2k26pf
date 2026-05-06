using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Ventas
{
    public class Cls_CuentaPorCobrar
    {
        public int Pk_Id_Cuenta_Por_Cobrar { get; set; }
        public int Fk_Id_Venta { get; set; }
        public int FK_Id_Cliente { get; set; }
        public DateTime Cmp_Fecha_De_Deuda { get; set; }
        public DateTime Cmp_Fecha_Vencimiento { get; set; }
        public float Cmp_Monto_Total { get; set; }
        public string Cmp_Estado { get; set; }

        public Cls_CuentaPorCobrar() { }

        public Cls_CuentaPorCobrar(
            int iPk_Id_Cuenta_Por_Cobrar,
            int iFk_Id_Venta,
            int iFk_Id_Cliente,
            DateTime dCmp_Fecha_De_Deuda,
            DateTime dCmp_Fecha_Vencimiento,
            float fCmp_Monto_Total,
            string sCmp_Estado)
        {
            Pk_Id_Cuenta_Por_Cobrar = iPk_Id_Cuenta_Por_Cobrar;
            Fk_Id_Venta = iFk_Id_Venta;
            FK_Id_Cliente = iFk_Id_Cliente;
            Cmp_Fecha_De_Deuda = dCmp_Fecha_De_Deuda;
            Cmp_Fecha_Vencimiento = dCmp_Fecha_Vencimiento;
            Cmp_Monto_Total = fCmp_Monto_Total;
            Cmp_Estado = sCmp_Estado;
        }
    }
    public class Cls_CXC_Detalle
    {
        public int Pk_Id_Cuenta_Por_Cobrar_Detalle { get; set; }
        public int Fk_Id_Cuenta_Por_Cobrar { get; set; }
        public int Fk_Id_Tipo_Operacion { get; set; }
        public string Cmp_No_Documento { get; set; }
        public DateTime Cmp_Fecha_Pago { get; set; }
        public string Cmp_Tipo_Pago { get; set; }
        public float Cmp_Monto_Pagado { get; set; }
        public float Cmp_Saldo_Pendiente { get; set; }

        public Cls_CXC_Detalle() { }  

        public Cls_CXC_Detalle(
                int iPk_Id_Cuenta_Por_Cobrar_Detalle,
            int iFk_Id_Cuenta_Por_Cobrar,
            int iFk_Id_Tipo_Operacion,
            string sCmp_No_Documento,
            DateTime dCmp_Fecha_Pago,
            string sCmp_Tipo_Pago,
            float fCmp_Monto_Pagado,
            float fCmp_Saldo_Pendiente)
        {
            Pk_Id_Cuenta_Por_Cobrar_Detalle = iPk_Id_Cuenta_Por_Cobrar_Detalle;
            Fk_Id_Cuenta_Por_Cobrar = iFk_Id_Cuenta_Por_Cobrar;
            Fk_Id_Tipo_Operacion = iFk_Id_Tipo_Operacion;
            Cmp_No_Documento = sCmp_No_Documento;
            Cmp_Fecha_Pago = dCmp_Fecha_Pago;
            Cmp_Tipo_Pago = sCmp_Tipo_Pago;
            Cmp_Monto_Pagado = fCmp_Monto_Pagado;
            Cmp_Saldo_Pendiente = fCmp_Saldo_Pendiente;
        }
    }
}
