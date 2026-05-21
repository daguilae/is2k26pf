using System;
using Capa_Modelo;

namespace Capa_Controlador
{
    public class Cls_Controlador
    {
        private Cls_Sentencias Obj_Sentencias = new Cls_Sentencias();

        public bool Fun_Insertar_Comprobante_Venta(
            int I_Id_Venta,
            int I_Id_Entrega_Venta,
            int I_Id_Cliente,
            string S_Nombre_Receptor,
            DateTime Dt_Fecha_Venta,
            string S_Observaciones,
            string S_Estado
        )
        {
            return Obj_Sentencias.Fun_Insertar_Comprobante_Venta(
                I_Id_Venta,
                I_Id_Entrega_Venta,
                I_Id_Cliente,
                S_Nombre_Receptor,
                Dt_Fecha_Venta,
                S_Observaciones,
                S_Estado
            );
        }

        public bool Fun_Modificar_Comprobante_Venta(
            int I_Id_Comprobante_Venta,
            int I_Id_Venta,
            int I_Id_Entrega_Venta,
            int I_Id_Cliente,
            string S_Nombre_Receptor,
            DateTime Dt_Fecha_Venta,
            string S_Observaciones,
            string S_Estado
        )
        {
            return Obj_Sentencias.Fun_Modificar_Comprobante_Venta(
                I_Id_Comprobante_Venta,
                I_Id_Venta,
                I_Id_Entrega_Venta,
                I_Id_Cliente,
                S_Nombre_Receptor,
                Dt_Fecha_Venta,
                S_Observaciones,
                S_Estado
            );
        }
    }
}