using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Ventas
{
    public class Cls_Devolucion_Ventas
    {
        public int Pk_Id_Devolucion_Ventas { get; set; }
        public DateTime Cmp_Fecha_Devolucion { get; set; }
        public int Fk_Id_Venta { get; set; }
        public string Cmp_Motivo { get; set; }
        public string Cmp_Estado { get; set; }
        public float Cmp_Saldo_Total { get; set; }
       
        public Cls_Devolucion_Ventas() { }
        public Cls_Devolucion_Ventas(int iPk_Id_Devolucion_Ventas, DateTime dCmp_Fecha_Devolucion, int iFk_Id_Venta, string sCmp_Motivo , string sCmp_Estado, float fCmp_Saldo_Total)
        {
            Pk_Id_Devolucion_Ventas = iPk_Id_Devolucion_Ventas;
            Cmp_Fecha_Devolucion = dCmp_Fecha_Devolucion;
            Fk_Id_Venta = iFk_Id_Venta;
            Cmp_Motivo = sCmp_Motivo;
            Cmp_Estado = sCmp_Estado;
            Cmp_Saldo_Total = fCmp_Saldo_Total;
        }
    }
    public class Cls_Detalle_Devolucion_Ventas
    {
        public int Fk_Id_Devolucion_Ventas { get; set; }
        public int Fk_Id_Inventario { get; set; }
        public float Cmp_Cantidad_Producto { get; set; }
        public float Cmp_Precio_Subtotal { get; set; }
        public Cls_Detalle_Devolucion_Ventas() { }
        public Cls_Detalle_Devolucion_Ventas(int iFk_Id_Devolucion_Ventas, int iFk_Id_Inventario, float fCmp_Cantidad_Producto, float fCmp_Precio_Subtotal)
        {
            Fk_Id_Devolucion_Ventas = iFk_Id_Devolucion_Ventas;
            Fk_Id_Inventario = iFk_Id_Inventario;
            Cmp_Cantidad_Producto = fCmp_Cantidad_Producto;
            Cmp_Precio_Subtotal = fCmp_Precio_Subtotal;
        }
    }
}
