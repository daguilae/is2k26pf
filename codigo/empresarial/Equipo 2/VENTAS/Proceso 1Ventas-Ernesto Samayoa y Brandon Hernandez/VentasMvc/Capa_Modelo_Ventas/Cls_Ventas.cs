using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Ventas
{
    public class Cls_Ventas
    {
        public int Pk_Id_Ventas { get; set; }
        public DateTime Cmp_Fecha_Venta { get; set; }
        public int Fk_Id_Sucursal { get; set; }
        public int Fk_Id_Cliente { get; set; }
        public string Cmp_Estado_Venta { get; set; }
        public string Cmp_Tipo_Operacion { get; set; }
        public float Cmp_Saldo_Total { get; set; }
        public DateTime Cmp_Fecha_Vencimiento { get; set; }
        public DateTime Cmp_Fecha_Entrega { get; set; }
        public Cls_Ventas() { }
        public Cls_Ventas(int iPk_Id_Ventas, DateTime dCmp_Fecha_Venta, int iFk_Id_Cliente,  int iFk_Id_Sucursal, string sCmp_Estado_Venta, string sCmp_Tipo_Operacion, float fCmp_Saldo_Total,  DateTime fCmp_Fecha_Vencimiento, DateTime fCmp_Fecha_Entrega)
        {
            Pk_Id_Ventas = iPk_Id_Ventas;
            Cmp_Fecha_Venta = dCmp_Fecha_Venta;
           Fk_Id_Cliente = iFk_Id_Cliente;
            Fk_Id_Sucursal = iFk_Id_Sucursal;
            Cmp_Estado_Venta = sCmp_Estado_Venta;
            Cmp_Tipo_Operacion = sCmp_Tipo_Operacion;
            Cmp_Saldo_Total = fCmp_Saldo_Total;
            Cmp_Fecha_Vencimiento = fCmp_Fecha_Vencimiento;
            Cmp_Fecha_Entrega = fCmp_Fecha_Entrega;
        }
    }
    public class Cls_Detalle_Ventas
    {
        public int Fk_Id_Ventas { get; set; }
        public int Fk_Id_Inventario { get; set; }
        public float Cmp_Cantidad_Producto { get; set; }
        public float Cmp_Precio_Subtotal { get; set; }
        public float Cmp_Costo_Subtotal { get; set; }
        public Cls_Detalle_Ventas() { }
        public Cls_Detalle_Ventas(int iFk_Id_Ventas, int iFk_Id_Inventario, float fCmp_Cantidad_Producto, float fCmp_Precio_Subtotal, float fCmp_Costo_Subtotal)
        {
            Fk_Id_Ventas = iFk_Id_Ventas;
            Fk_Id_Inventario = iFk_Id_Inventario;
            Cmp_Cantidad_Producto = fCmp_Cantidad_Producto;
            Cmp_Precio_Subtotal = fCmp_Precio_Subtotal;
            Cmp_Costo_Subtotal = fCmp_Costo_Subtotal;

        }
    }
}
