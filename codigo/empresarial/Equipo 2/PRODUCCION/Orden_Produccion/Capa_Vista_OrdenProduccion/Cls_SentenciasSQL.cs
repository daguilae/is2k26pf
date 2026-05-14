using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_OrdenProduccion
{
    public class Cls_SentenciasSQL
    {
        //encabezado
        public static string sInsertarEncabezadoProduccion = @"
        INSERT INTO Tbl_Orden_Produccion_Encabezado 
        (Fk_ID_Vendedor, Cmp_Fecha_Emision, Cmp_Estado, Cmp_Fecha_Estimada_Entrega) 
        VALUES (?, ?, ?, ?);";

        public static string sObtenerUltimoId = "SELECT LAST_INSERT_ID();";

        //Detalles
        public static string sInsertarDetalleProduccion = @"
        INSERT INTO Tbl_Orden_Produccion_Detalle 
        (Fk_ID_OrdenProduccion, Fk_ID_Producto, Cmp_Cantidad_Solicitada, Cmp_Cantidad_Recibida) 
        VALUES (?, ?, ?, ?);";

        //Actualiza encabezados
        public static string sActualizarEncabezadoProduccion = @"
        UPDATE Tbl_Orden_Produccion_Encabezado 
        SET Fk_ID_Vendedor = ?, Cmp_Fecha_Emision = ?, Cmp_Estado = ?, Cmp_Fecha_Estimada_Entrega = ?
        WHERE Pk_ID_OrdenProduccion = ?;";

        //Elimina detalles por orden
        public static string sEliminarDetallesPorOrden = @"
        DELETE FROM Tbl_Orden_Produccion_Detalle WHERE Fk_ID_OrdenProduccion = ?;";

        //Eliminar Orden de Produccion
        public static string sEliminarEncabezadoProduccion = @"
        DELETE FROM Tbl_Orden_Produccion_Encabezado WHERE Pk_ID_OrdenProduccion = ?;";

        //consultas para ComboBox
        public static string sObtenerVendedores = "SELECT Pk_Id_Vendedor, CONCAT(Pk_Id_Vendedor, ' - ', Cmp_Nombre, ' ', Cmp_Apellido) AS NombreCompleto FROM tbl_vendedor;";
        public static string sObtenerProductos = "SELECT pk_inventario_id, CONCAT(pk_inventario_id, ' - ', nombre_prod) AS NombreProducto FROM tbl_inventario;";

        //consultas para cargar las tablas 
        public static string sObtenerEncabezados = "SELECT Pk_ID_OrdenProduccion, Fk_ID_Vendedor, Cmp_Fecha_Emision, Cmp_Estado, Cmp_Fecha_Estimada_Entrega FROM Tbl_Orden_Produccion_Encabezado;";
        public static string sObtenerDetallesPorOrden = @"
        SELECT d.Fk_ID_Producto, CONCAT(d.Fk_ID_Producto, ' - ', i.nombre_prod) AS NombreProducto, d.Cmp_Cantidad_Solicitada, d.Cmp_Cantidad_Recibida
        FROM Tbl_Orden_Produccion_Detalle d
        INNER JOIN tbl_inventario i ON d.Fk_ID_Producto = i.pk_inventario_id
        WHERE d.Fk_ID_OrdenProduccion = ?;";

        // Consulta para el reporte
        public static string sReporteOrdenes = @"
        SELECT 
            e.Pk_ID_OrdenProduccion, 
            e.Fk_ID_Vendedor, 
            e.Cmp_Fecha_Emision, 
            e.Cmp_Estado, 
            e.Cmp_Fecha_Estimada_Entrega,
            d.Fk_ID_Producto, 
            d.Cmp_Cantidad_Solicitada, 
            d.Cmp_Cantidad_Recibida
        FROM tbl_orden_produccion_encabezado e
        INNER JOIN tbl_orden_produccion_detalle d 
            ON e.Pk_ID_OrdenProduccion = d.Fk_ID_OrdenProduccion
        ORDER BY e.Pk_ID_OrdenProduccion ASC;";

    }
}
