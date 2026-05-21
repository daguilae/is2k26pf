using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using Capa_Controlador_Mov_Inv;

namespace Capa_Modelo_Ventas
{
    public class Cls_Devolucion_VentasDAO
    {
        private Cls_ConexionBD conexion = new Cls_ConexionBD();

        //ID AUTOINCREMENTABLE
        private static readonly string SQL_SIGUIENTE_ID = @"
        SELECT IFNULL(MAX(Pk_Id_Devolucion_Ventas), 0) + 1 AS SiguienteID 
        FROM tbl_devolucion_ventas";

        //Id Venta y su fecha que se realizo la venta
        private static readonly string SQL_VENTAS = @"
        SELECT 
            Pk_Id_Ventas, CONCAT(Pk_Id_Ventas, ' - ', DATE_FORMAT(Cmp_Fecha_Venta, '%d/%m/%Y')) AS VentaFecha
        FROM tbl_ventas
        WHERE Cmp_Tipo_Operacion = 'Venta'
        ORDER BY Pk_Id_Ventas DESC";

        //NUEVO DE COMBOBOX DE ESTADO
        private static readonly string SQL_ESTADO =
        "SHOW COLUMNS FROM tbl_devolucion_ventas LIKE 'Cmp_Estado'";

        //Buscar el cliente con su respectiva fecha de venta
        private static readonly string SQL_CLIENTE_POR_VENTA = @"
        SELECT 
            c.Pk_Id_Cliente,
            CONCAT(c.Pk_Id_Cliente, ' - ', c.Cmp_Nombre, ' ', c.Cmp_Apellido) AS NombreCompleto
        FROM tbl_ventas v
        INNER JOIN tbl_clientes c 
            ON v.Fk_Id_Cliente = c.Pk_Id_Cliente
        WHERE v.Pk_Id_Ventas = ?";

        //Buscar la sucursal donde se realizo la venta
        private static readonly string SQL_SUCURSAL_POR_VENTA = @"
        SELECT 
            s.Pk_Id_Sucursal,
            CONCAT(s.Pk_Id_Sucursal, ' - ', s.Cmp_Direccion) AS NombreSucursal
        FROM tbl_ventas v
        INNER JOIN tbl_sucursales s
            ON v.Fk_Id_Sucursal = s.Pk_Id_Sucursal
        WHERE v.Pk_Id_Ventas = ?";
        //Productos vendidos el dia de la venta
        private static readonly string SQL_PRODUCTOS_POR_VENTA = @"
        SELECT 
            i.pk_inventario_id,
            i.nombre_prod,
            i.descripcion,
            i.precio_unitario,

            dv.Cmp_Cantidad_Producto AS CantidadVendida,

            CONCAT(i.pk_inventario_id, ' - ', i.nombre_prod, ' (Vendidos: ', dv.Cmp_Cantidad_Producto, ')') AS Producto
        FROM tbl_detalle_ventas dv
        INNER JOIN tbl_inventario i
            ON dv.Fk_Id_Inventario = i.pk_inventario_id
        WHERE dv.Fk_Id_Ventas = ?";

        //Bodega se encuentra el producto
        private static readonly string SQL_BODEGA_POR_PRODUCTO_VENTA = @"
        SELECT DISTINCT
            b.Pk_Id_Bodega,
            b.Cmp_Nombre_Bodega,

            CONCAT(b.Pk_Id_Bodega, ' - ',  b.Cmp_Nombre_Bodega ) AS NombreBodega
        FROM tbl_existencias e
        INNER JOIN tbl_bodega b
            ON e.fk_bodega_id = b.Pk_Id_Bodega
        WHERE e.fk_inventario_id = ?";

        // UNIDAD DE MEDIDA POR PRODUCTO
        private static readonly string SQL_UNIDAD_POR_PRODUCTO = @"
        SELECT DISTINCT
        u.ID_Unidad,
        u.Nombre_Unidad,
        u.Abreviacion_Medida,
        CONCAT(u.ID_Unidad, ' - ', u.Nombre_Unidad, ' (', u.Abreviacion_Medida,')') AS UnidadMedida
        FROM tbl_existencias e
        INNER JOIN tbl_unidad_de_medida u
        ON e.fk_id_unidad_medida = u.ID_Unidad
        WHERE e.fk_inventario_id = ?";

        //INSERTAR DEVOLUCION
        private static readonly string SQL_INSERT_DEVOLUCION = @"
        INSERT INTO tbl_devolucion_ventas
        (Fk_Id_Venta,Cmp_Fecha_Devolucion,Cmp_Motivo,Cmp_Saldo_Total, Cmp_Estado)  VALUES (?, ?, ?, ?, ?)";


        // SQL DETALLE DEVOLUCION
        private static readonly string SQL_INSERT_DETALLE_DEVOLUCION = @"
        INSERT INTO tbl_detalle_devolucion_ventas
        (Fk_Id_Devolucion_Ventas, Fk_Id_Inventario, Cmp_Cantidad_Producto, Cmp_Precio_Subtotal) VALUES (?, ?, ?, ?)";


        //Primer Formulario Ventas Generales
        //GRID PARA VENTAS GENERALES 
        private static readonly string SQL_DEVOLUCION_LISTADO = @"
        SELECT 
            dv.Pk_Id_Devolucion_Ventas AS Id_Devolucion,
            v.Cmp_Fecha_Venta AS Fecha_Venta,
            dv.Cmp_Fecha_Devolucion AS Fecha_Devolucion,
            CONCAT(c.Cmp_Nombre, ' ', c.Cmp_Apellido) AS Cliente,
            dv.Cmp_Motivo AS Motivo,
            i.nombre_prod AS Producto,
            dd.Cmp_Cantidad_Producto AS Cantidad,
            dd.Cmp_Precio_Subtotal AS Subtotal,
            dv.Cmp_Saldo_Total AS SaldoTotal
        FROM tbl_devolucion_ventas dv
        INNER JOIN tbl_ventas v 
            ON dv.Fk_Id_Venta = v.Pk_Id_Ventas
        INNER JOIN tbl_clientes c 
            ON v.Fk_Id_Cliente = c.Pk_Id_Cliente
        INNER JOIN tbl_detalle_devolucion_ventas dd 
            ON dv.Pk_Id_Devolucion_Ventas = dd.Fk_Id_Devolucion_Ventas
        INNER JOIN tbl_inventario i 
            ON dd.Fk_Id_Inventario = i.pk_inventario_id
        ORDER BY dv.Pk_Id_Devolucion_Ventas ASC";


        //VENTAS GENERALES
        public DataTable ObtenerListadoDevoluciones()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_DEVOLUCION_LISTADO, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conexion.desconexion(conn);
                    return dt;
                }
            }
        }








        public int ObtenerSiguienteIdDevolucionVenta()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_SIGUIENTE_ID, conn))
                {
                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    conexion.desconexion(conn);
                    return id;
                }
            }
        }

        public DataTable ObtenerVentas()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_VENTAS, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    conexion.desconexion(conn);

                    return dt;
                }
            }
        }

        public DataTable ObtenerEstado()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_ESTADO, conn))
                {
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();

                        dt.Columns.Add("Estado");

                        if (reader.Read())
                        {
                            string enumValues = reader["Type"].ToString();

                            // enum('Activo','Inactivo')
                            enumValues = enumValues
                                .Replace("enum(", "").Replace(")", "") .Replace("'", "");

                            string[] valores = enumValues.Split(',');

                            foreach (string val in valores)
                            {
                                dt.Rows.Add(val);
                            }
                        }

                        conexion.desconexion(conn);

                        return dt;
                    }
                }
            }
        }

        public DataTable ObtenerClientePorVenta(int iIdVenta)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_CLIENTE_POR_VENTA, conn))
                {
                    cmd.Parameters.AddWithValue("?", iIdVenta);

                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        conexion.desconexion(conn);

                        return dt;
                    }
                }
            }
        }

        public DataTable ObtenerSucursalPorVenta(int iIdVenta)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_SUCURSAL_POR_VENTA, conn))
                {
                    cmd.Parameters.AddWithValue("?", iIdVenta);

                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        conexion.desconexion(conn);

                        return dt;
                    }
                }
            }
        }

        public DataTable ObtenerProductosPorVenta(int iIdVenta)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_PRODUCTOS_POR_VENTA, conn))
                {
                    cmd.Parameters.AddWithValue("?", iIdVenta);

                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        conexion.desconexion(conn);

                        return dt;
                    }
                }
            }
        }
        public DataTable ObtenerBodegaPorProducto(int pk_inventario_id)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd =
                    new OdbcCommand(SQL_BODEGA_POR_PRODUCTO_VENTA, conn))
                {
                    cmd.Parameters.AddWithValue("?", pk_inventario_id);

                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        conexion.desconexion(conn);

                        return dt;
                    }
                }
            }
        }
        public DataTable ObtenerUnidadPorProducto(int iIdProducto)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd =
                    new OdbcCommand(SQL_UNIDAD_POR_PRODUCTO, conn))
                {
                    cmd.Parameters.AddWithValue("?", iIdProducto);

                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        conexion.desconexion(conn);

                        return dt;
                    }
                }
            }
        }

        public bool GuardarDevolucionCompleta(int iFk_Id_Venta, DateTime dCmp_Fecha_Devolucion, string sCmp_Motivo,  float fCmp_Saldo_Total, DataTable detalle)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcTransaction trans = conn.BeginTransaction();

                try
                {
                    int iPk_Id_Devolucion = 0;

                    // ================================
                    // INSERTAR ENCABEZADO DEVOLUCION
                    // ================================
                    using (OdbcCommand cmdDevolucion =
                        new OdbcCommand(SQL_INSERT_DEVOLUCION, conn, trans))
                    {
                        cmdDevolucion.Parameters.AddWithValue("?", iFk_Id_Venta);
                        cmdDevolucion.Parameters.AddWithValue("?", dCmp_Fecha_Devolucion);
                        cmdDevolucion.Parameters.AddWithValue("?", sCmp_Motivo);
                        cmdDevolucion.Parameters.AddWithValue("?", fCmp_Saldo_Total);
                        cmdDevolucion.Parameters.AddWithValue("?", "Activo");

                        cmdDevolucion.ExecuteNonQuery();
                    }

                    // ================================
                    // OBTENER ID GENERADO
                    // ================================
                    using (OdbcCommand cmdId =
                        new OdbcCommand("SELECT LAST_INSERT_ID()", conn, trans))
                    {
                        iPk_Id_Devolucion = Convert.ToInt32(cmdId.ExecuteScalar());
                    }

                    // ================================
                    // INSERTAR DETALLE
                    // ================================
                    foreach (DataRow row in detalle.Rows)
                    {
                        using (OdbcCommand cmdDetalle =
                            new OdbcCommand(SQL_INSERT_DETALLE_DEVOLUCION, conn, trans))
                        {
                            cmdDetalle.Parameters.AddWithValue("?", iPk_Id_Devolucion);
                            cmdDetalle.Parameters.AddWithValue("?", row["IdProducto"]);
                            cmdDetalle.Parameters.AddWithValue("?", row["Cantidad"]);
                            cmdDetalle.Parameters.AddWithValue("?", row["Subtotal"]);

                            cmdDetalle.ExecuteNonQuery();
                        }
                    }

                    // REGRESAR PRODUCTOS AL INVENTARIO (SUMAR)
                    var detalleInventario = detalle.AsEnumerable()
                    .Select(row => (
                        idInventario: row.Field<int>("IdProducto"),
                        idBodega: row.Field<int>("IdBodega"),
                        cantidad: row.Field<float>("Cantidad"),
                        idUnidad: row.Field<int>("IdUnidad")
                    ))
                    .ToList();
                    Cls_Mov_Inv_Controlador inventario = new Cls_Mov_Inv_Controlador();
                    bool actualizacionStock = inventario.fun_GuardarMovimiento(
                        4,
                        dCmp_Fecha_Devolucion,
                        "Devolucion Venta",
                        detalleInventario
                    );

                    // CONFIRMAR TRANSACCION
                    trans.Commit();

                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw new Exception("Error al guardar devolución: " + ex.Message);
                }
                finally
                {
                    conexion.desconexion(conn);
                }
            }
        }



    }
}
