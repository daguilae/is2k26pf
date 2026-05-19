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
    public class Cls_VentasDAO
    {
        private Cls_ConexionBD conexion = new Cls_ConexionBD();

        private static readonly string SQL_CLIENTES = @"
        SELECT 
        Pk_Id_Cliente,
        CONCAT(Pk_Id_Cliente, ' - ', Cmp_Nombre, ' ', Cmp_Apellido) AS NombreCompleto
        FROM tbl_clientes";

        private static readonly string SQL_SUCURSALES = @"
        SELECT 
         Pk_Id_Sucursal,
         CONCAT(Pk_Id_Sucursal, ' - ', Cmp_Direccion) AS NombreSucursal
         FROM tbl_sucursales";

        private static readonly string SQL_INVENTARIO = @"
        SELECT
        i.pk_inventario_id,              
        i.nombre_prod,
        i.descripcion,
        i.precio_unitario,
        e.stock,
        e.fk_bodega_id,
        CONCAT(i.pk_inventario_id, ' - ', i.nombre_prod, ' (Stock: ', e.stock, ')') AS Producto
        FROM tbl_inventario i
        INNER JOIN tbl_existencias e ON i.pk_inventario_id = e.fk_inventario_id
        WHERE i.estado_producto = 'ACTIVO' AND e.stock > 0";

        private static readonly string SQL_BODEGAS = @"
        SELECT 
        Pk_Id_Bodega,
        Cmp_Nombre_Bodega,
        CONCAT(Pk_Id_Bodega, ' - ', Cmp_Nombre_Bodega) AS NombreBodega
        FROM tbl_bodega
        WHERE Cmp_Estado_Bodega = 'Activo'";


        //NUEVO UNIDAD DE MEDIDA PARA LLAMAR EN COMBOBOX
        private static readonly string SQL_UNIDADES = @"
        SELECT 
        ID_Unidad,
        Nombre_Unidad,
        Abreviacion_Medida,
        CONCAT(ID_Unidad, ' - ', Nombre_Unidad, ' (', Abreviacion_Medida, ')') AS UnidadMedida
        FROM tbl_unidad_de_medida
        WHERE Estado_Medida = 'Activo'";



        //NUEVO DE COMBOBOX DE ESTADO
        //private static readonly string SQL_ESTADOVENTA =
        //"SHOW COLUMNS FROM tbl_ventas LIKE 'Cmp_Estado_Venta'";

        //Nuevo agregado para Tipo operacion
        private static readonly string SQL_TIPO_OPERACION =
        "SHOW COLUMNS FROM tbl_ventas LIKE 'Cmp_Tipo_Operacion'";


        //ID AUTOINCREMENTABLE
        private static readonly string SQL_SIGUIENTE_ID = @"
        SELECT IFNULL(MAX(Pk_Id_Ventas), 0) + 1 AS SiguienteID FROM tbl_ventas";

        //PARA GRID
        private static readonly string SQL_INVENTARIO_GRID = @"
        SELECT 
        i.pk_inventario_id,
        i.nombre_prod,
        i.descripcion,
        i.precio_unitario
        FROM tbl_inventario i
        WHERE i.estado_producto = 'ACTIVO'";


        private static readonly string SQL_INSERT_VENTA = @"
        INSERT INTO tbl_ventas (Cmp_Fecha_Venta, Fk_Id_Cliente, Fk_Id_Sucursal, Cmp_Estado_Venta, Cmp_Tipo_Operacion, Cmp_Saldo_Total)
        VALUES (?, ?, ?, ?, ?, ?)";

        private static readonly string SQL_INSERT_DETALLE = @"
        INSERT INTO tbl_detalle_ventas (Fk_Id_Ventas, Fk_Id_Inventario, Cmp_Cantidad_Producto, Cmp_Precio_Subtotal, Cmp_Costo_Subtotal)
        VALUES (?, ?, ?, ?, ?)";

        private static readonly string SQL_INSERT_CUENTA_COBRAR = @"
    INSERT INTO tbl_cuentas_por_cobrar (Fk_Id_Venta, FK_Id_Cliente, Cmp_Fecha_De_Deuda, Cmp_Fecha_Vencimiento, Cmp_Monto_Total, Cmp_Estado)
    VALUES (?, ?, ?, ?, ?, ?)";
        //VALIDAR LA ASIGNACION DEL VENDEDOR A CLIENTE
        private static readonly string SQL_VALIDAR_CLIENTE_VENDEDOR = @"
        SELECT 
        v.Pk_Id_Vendedor,
        CONCAT(v.Cmp_Nombre, ' ', v.Cmp_Apellido) AS Vendedor
        FROM tbl_asignacion_clientes a
        INNER JOIN tbl_vendedor v ON a.Fk_Id_Vendedor = v.Pk_Id_Vendedor
        WHERE a.Fk_Id_Cliente = ?";

        //AGREGANDO DESCUENTO POR TIPO CLIENTE
        private static readonly string SQL_DESCUENTO = @"
        SELECT 
        tc.Cmp_Tipo,
        pd.Cmp_Descuento
        FROM tbl_clientes c
        INNER JOIN tbl_tipo_cliente tc 
        ON c.Fk_Id_Tipo_Cliente = tc.Pk_Id_Tipo_Cliente
        INNER JOIN tbl_politicas_descuento pd 
        ON tc.Pk_Id_Tipo_Cliente = pd.Fk_Id_Tipo_Cliente
        WHERE c.Pk_Id_Cliente = ?
        AND ? BETWEEN pd.Cmp_Cantidad_Min AND pd.Cmp_Cantidad_Max";

        //Primer Formulario Ventas Generales
        //GRID PARA VENTAS GENERALES //corregir tipoclientes
        private static readonly string SQL_VENTAS_LISTADO = @"
        SELECT 
        v.Pk_Id_Ventas AS IdVenta,
        v.Cmp_Fecha_Venta AS Fecha,
        CONCAT(c.Cmp_Nombre, ' ', c.Cmp_Apellido) AS Cliente,
        tc.Cmp_Tipo AS TipoCliente,
        v.Cmp_Tipo_Operacion AS TipoOperacion,
        v.Cmp_Saldo_Total AS Total
        FROM tbl_ventas v
        INNER JOIN tbl_clientes c ON v.Fk_Id_Cliente = c.Pk_Id_Cliente
        INNER JOIN tbl_tipo_cliente tc ON c.Fk_Id_Tipo_Cliente = tc.Pk_Id_Tipo_Cliente
        ORDER BY v.Pk_Id_Ventas ASC";


        //bodegas que contengan ciertos productos
        private static readonly string SQL_BODEGAS_POR_PRODUCTO = @"
        SELECT 
        b.Pk_Id_Bodega,
        b.Cmp_Nombre_Bodega,
        CONCAT(b.Pk_Id_Bodega, ' - ', b.Cmp_Nombre_Bodega) AS NombreBodega
        FROM tbl_existencias e
        INNER JOIN tbl_bodega b ON e.fk_bodega_id = b.Pk_Id_Bodega
        WHERE e.fk_inventario_id = ? AND e.stock > 0";


        //NUEVO DE UNIDAD DE MEDIDA Y PRODUCTO
        private static readonly string SQL_UNIDAD_POR_PRODUCTO = @"
        SELECT DISTINCT
        u.ID_Unidad,
        u.Nombre_Unidad,
        u.Abreviacion_Medida,
        CONCAT(u.ID_Unidad, ' - ', u.Nombre_Unidad, ' (', u.Abreviacion_Medida, ')') AS UnidadMedida
        FROM tbl_existencias e
        INNER JOIN tbl_unidad_de_medida u 
            ON e.fk_id_unidad_medida = u.ID_Unidad
        WHERE e.fk_inventario_id = ?";




        //hoy 18 de mayo
        private static readonly string SQL_OBTENER_VENTA = @"
SELECT
v.Pk_Id_Ventas,
v.Cmp_Fecha_Venta,
v.Fk_Id_Cliente,
v.Fk_Id_Sucursal,
v.Cmp_Estado_Venta,
v.Cmp_Tipo_Operacion,
v.Cmp_Saldo_Total
FROM tbl_ventas v
WHERE v.Pk_Id_Ventas = ?";

        public DataTable ObtenerVentaPorId(int idVenta)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd =
                    new OdbcCommand(SQL_OBTENER_VENTA, conn))
                {
                    cmd.Parameters.AddWithValue("?", idVenta);

                    using (OdbcDataAdapter da =
                        new OdbcDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        conexion.desconexion(conn);

                        return dt;
                    }
                }
            }
        }


        private static readonly string SQL_UPDATE_VENTA = @"
        UPDATE tbl_ventas
        SET
        Cmp_Fecha_Venta = ?,
        Fk_Id_Cliente = ?,
        Fk_Id_Sucursal = ?,
        Cmp_Estado_Venta = ?,
        Cmp_Tipo_Operacion = ?,
        Cmp_Saldo_Total = ?
        WHERE Pk_Id_Ventas = ?";

        public bool ActualizarVenta(int iPk_Id_Venta, DateTime dCmp_Fecha_Venta, int iFk_Id_Cliente, int iFk_Id_Sucursal,
        string sCmp_Estado_Venta, string sCmp_Tipo_Operacion, float fCmp_Saldo_Total,  bool convertirAVenta,   DataTable detalle)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcTransaction trans = conn.BeginTransaction();

                try
                {
                    // ACTUALIZAR ENCABEZADO
                    using (OdbcCommand cmd = new OdbcCommand(
                        SQL_UPDATE_VENTA,
                        conn,
                        trans))
                    {
                        cmd.Parameters.AddWithValue("?", dCmp_Fecha_Venta);
                        cmd.Parameters.AddWithValue("?", iFk_Id_Cliente);
                        cmd.Parameters.AddWithValue("?", iFk_Id_Sucursal);
                        cmd.Parameters.AddWithValue("?", sCmp_Estado_Venta);
                        cmd.Parameters.AddWithValue("?", sCmp_Tipo_Operacion);
                        cmd.Parameters.AddWithValue("?", fCmp_Saldo_Total);
                        cmd.Parameters.AddWithValue("?", iPk_Id_Venta);

                        cmd.ExecuteNonQuery();
                    }

                    // =========================================
                    // SOLO MODIFICAR DETALLE
                    // SI NO ES CONVERSIÓN A VENTA
                    // =========================================

                    if (!convertirAVenta)
                    {
                        // =====================================
                        // OBTENER DETALLE ORIGINAL
                        // =====================================

                        DataTable detalleOriginal =
                            ObtenerDetalleOriginal(iPk_Id_Venta);

                        // =====================================
                        // DEVOLVER STOCK
                        // =====================================

                        foreach (DataRow row in detalleOriginal.Rows)
                        {
                            int idProducto =
                                Convert.ToInt32(
                                    row["Fk_Id_Inventario"]);

                            float cantidad =
                                Convert.ToSingle(
                                    row["Cmp_Cantidad_Producto"]);

                            using (OdbcCommand cmdStock =
                                new OdbcCommand(
                                    @"UPDATE tbl_existencias
                              SET stock = stock + ?
                              WHERE fk_inventario_id = ?",
                                    conn,
                                    trans))
                            {
                                cmdStock.Parameters.AddWithValue(
                                    "?",
                                    cantidad);

                                cmdStock.Parameters.AddWithValue(
                                    "?",
                                    idProducto);

                                cmdStock.ExecuteNonQuery();
                            }
                        }

                        // =====================================
                        // ELIMINAR DETALLE ANTERIOR
                        // =====================================

                        using (OdbcCommand cmdDelete =
                            new OdbcCommand(
                                @"DELETE FROM tbl_detalle_ventas
                          WHERE Fk_Id_Ventas = ?",
                                conn,
                                trans))
                        {
                            cmdDelete.Parameters.AddWithValue(
                                "?",
                                iPk_Id_Venta);

                            cmdDelete.ExecuteNonQuery();
                        }

                        // =====================================
                        // INSERTAR NUEVO DETALLE
                        // =====================================

                        foreach (DataRow row in detalle.Rows)
                        {
                            using (OdbcCommand cmdDetalle =
                                new OdbcCommand(
                                    SQL_INSERT_DETALLE,
                                    conn,
                                    trans))
                            {
                                cmdDetalle.Parameters.AddWithValue(
                                    "?",
                                    iPk_Id_Venta);

                                cmdDetalle.Parameters.AddWithValue(
                                    "?",
                                    row["IdProducto"]);

                                cmdDetalle.Parameters.AddWithValue(
                                    "?",
                                    row["Cantidad"]);

                                cmdDetalle.Parameters.AddWithValue(
                                    "?",
                                    row["Subtotal"]);

                                cmdDetalle.Parameters.AddWithValue(
                                    "?",
                                    0);

                                cmdDetalle.ExecuteNonQuery();
                            }
                        }
                    }

                    // =========================================
                    // CONVERTIR A VENTA
                    // =========================================

                    if (convertirAVenta)
                    {
                        bool yaTieneCXC =
                            ExisteCuentaPorCobrar(iPk_Id_Venta);

                        // SOLO SI NO EXISTE
                        if (!yaTieneCXC)
                        {
                            // =================================
                            // MOVIMIENTO INVENTARIO
                            // =================================

                            var detalleInventario =
                                detalle.AsEnumerable()
                                .Select(row => (
                                    idInventario:
                                        row.Field<int>("IdProducto"),

                                    idBodega:
                                        row.Field<int>("IdBodega"),

                                    cantidad:
                                        row.Field<float>("Cantidad"),

                                    idUnidad:
                                        row.Field<int>("IdUnidad")
                                ))
                                .ToList();

                            Cls_Mov_Inv_Controlador inventario =
                                new Cls_Mov_Inv_Controlador();

                            bool movimiento =
                                inventario.fun_GuardarMovimiento(
                                    3,
                                    dCmp_Fecha_Venta,
                                    "Venta",
                                    detalleInventario
                                );

                            // =================================
                            // ACTUALIZAR SALDO CLIENTE
                            // =================================

                            using (OdbcCommand cmdCliente =
                                new OdbcCommand(
                                    @"UPDATE tbl_clientes
                              SET Cmp_Saldo_Total =
                              Cmp_Saldo_Total + ?
                              WHERE Pk_Id_Cliente = ?",
                                    conn,
                                    trans))
                            {
                                cmdCliente.Parameters.AddWithValue(
                                    "?",
                                    fCmp_Saldo_Total);

                                cmdCliente.Parameters.AddWithValue(
                                    "?",
                                    iFk_Id_Cliente);

                                cmdCliente.ExecuteNonQuery();
                            }

                            // =================================
                            // CREAR CUENTA POR COBRAR
                            // =================================

                            using (OdbcCommand cmdCXC =
                                new OdbcCommand(
                                    SQL_INSERT_CUENTA_COBRAR,
                                    conn,
                                    trans))
                            {
                                cmdCXC.Parameters.AddWithValue(
                                    "?",
                                    iPk_Id_Venta);

                                cmdCXC.Parameters.AddWithValue(
                                    "?",
                                    iFk_Id_Cliente);

                                cmdCXC.Parameters.AddWithValue(
                                    "?",
                                    dCmp_Fecha_Venta);

                                cmdCXC.Parameters.AddWithValue(
                                    "?",
                                    dCmp_Fecha_Venta.AddDays(30));

                                cmdCXC.Parameters.AddWithValue(
                                    "?",
                                    fCmp_Saldo_Total);

                                cmdCXC.Parameters.AddWithValue(
                                    "?",
                                    "Activo");

                                cmdCXC.ExecuteNonQuery();
                            }
                        }
                    }

                    // =========================================
                    // COMMIT
                    // =========================================

                    trans.Commit();

                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();

                    throw new Exception(
                        "Error actualizar venta: " +
                        ex.Message);
                }
                finally
                {
                    conexion.desconexion(conn);
                }
            }
        }

        private static readonly string SQL_DETALLE_VENTA = @"
        SELECT
        dv.Fk_Id_Inventario AS IdProducto,
        i.nombre_prod AS Producto,
        i.descripcion AS Descripcion,

        e.fk_bodega_id AS IdBodega,
        b.Cmp_Nombre_Bodega AS Bodega,

        e.fk_id_unidad_medida AS IdUnidad,
        u.Nombre_Unidad AS UnidadMedida,

        i.precio_unitario AS Precio,
        dv.Cmp_Cantidad_Producto AS Cantidad,

        0 AS Descuento,
        'Publico' AS TipoCliente,

        dv.Cmp_Precio_Subtotal AS Subtotal

        FROM tbl_detalle_ventas dv

        INNER JOIN tbl_inventario i
        ON dv.Fk_Id_Inventario = i.pk_inventario_id

        INNER JOIN tbl_existencias e
        ON i.pk_inventario_id = e.fk_inventario_id

        INNER JOIN tbl_bodega b
        ON e.fk_bodega_id = b.Pk_Id_Bodega

        INNER JOIN tbl_unidad_de_medida u
        ON e.fk_id_unidad_medida = u.ID_Unidad

        WHERE dv.Fk_Id_Ventas = ?";

        public DataTable ObtenerDetalleVenta(int idVenta)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd =
                    new OdbcCommand(SQL_DETALLE_VENTA, conn))
                {
                    cmd.Parameters.AddWithValue("?", idVenta);

                    using (OdbcDataAdapter da =
                        new OdbcDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        conexion.desconexion(conn);

                        return dt;
                    }
                }
            }
        }

        private static readonly string SQL_EXISTE_CXC = @"
        SELECT COUNT(*)
        FROM tbl_cuentas_por_cobrar
        WHERE Fk_Id_Venta = ?";

        public bool ExisteCuentaPorCobrar(int idVenta)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd =
                    new OdbcCommand(SQL_EXISTE_CXC, conn))
                {
                    cmd.Parameters.AddWithValue("?", idVenta);

                    int cantidad =
                        Convert.ToInt32(cmd.ExecuteScalar());

                    conexion.desconexion(conn);

                    return cantidad > 0;
                }
            }
        }



        private static readonly string SQL_DETALLE_ORIGINAL = @"
        SELECT
        Fk_Id_Inventario,
        Cmp_Cantidad_Producto
        FROM tbl_detalle_ventas
        WHERE Fk_Id_Ventas = ?";
        public DataTable ObtenerDetalleOriginal(int idVenta)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd =
                    new OdbcCommand(
                        SQL_DETALLE_ORIGINAL,
                        conn))
                {
                    cmd.Parameters.AddWithValue(
                        "?",
                        idVenta);

                    using (OdbcDataAdapter da =
                        new OdbcDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        conexion.desconexion(conn);

                        return dt;
                    }
                }
            }
        }


        public DataTable ObtenerClientes()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_CLIENTES, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conexion.desconexion(conn);
                    return dt;
                }
            }
        }

        public DataTable ObtenerSucursales()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_SUCURSALES, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conexion.desconexion(conn);
                    return dt;
                }
            }
        }
        public DataTable ObtenerInventario()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_INVENTARIO, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conexion.desconexion(conn);
                    return dt;
                }
            }
        }
        public DataTable ObtenerBodegas()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_BODEGAS, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conexion.desconexion(conn);
                    return dt;
                }
            }
        }

        public DataTable ObtenerUnidades()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_UNIDADES, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conexion.desconexion(conn);
                    return dt;
                }
            }
        }

        //Nuevo para obtener la Unidad segun del producto
        public DataTable ObtenerUnidadPorProducto(int iIdProducto)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_UNIDAD_POR_PRODUCTO, conn))
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

        public DataTable ObtenerInventarioGrid()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_INVENTARIO_GRID, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conexion.desconexion(conn);
                    return dt;
                }
            }
        }

        //Nuevo agregado para Estado venta
        /*public DataTable ObtenerEstadoVenta()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_ESTADOVENTA, conn))
                {
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("EstadoVenta");

                        if (reader.Read())
                        {
                            string enumValues = reader["Type"].ToString();
                            // enum('Activo','Inactivo')

                            enumValues = enumValues.Replace("enum(", "").Replace(")", "").Replace("'", "");

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
        }*/

        //Nuevo agregado para tipo operacion
        public DataTable ObtenerTipoOperacion()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_TIPO_OPERACION, conn))
                {
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("TipoOperacion");

                        if (reader.Read())
                        {
                            string enumValues = reader["Type"].ToString();
                            // enum('Venta','Cotizacion','Pedido')

                            enumValues = enumValues
                                .Replace("enum(", "")
                                .Replace(")", "")
                                .Replace("'", "");

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


        public int ObtenerSiguienteIdVenta()
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

        // OBTENER EL VENDEDOR-CLIENTE
        public DataTable ObtenerVendedorDeCliente(int iFk_Id_Cliente)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_VALIDAR_CLIENTE_VENDEDOR, conn))
                {
                    cmd.Parameters.AddWithValue("?", iFk_Id_Cliente);

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

        //VENTAS GENERALES
        public DataTable ObtenerListadoVentas()
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_VENTAS_LISTADO, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conexion.desconexion(conn);
                    return dt;
                }
            }
        }

        //OBTENER LOS DESCUENTOS DE LOS CLIENTES 
        public (string tipo, float descuento) ObtenerDescuentoCliente(int iFk_Id_Cliente, float fCantidad)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_DESCUENTO, conn))
                {
                    cmd.Parameters.AddWithValue("?", iFk_Id_Cliente);
                    cmd.Parameters.AddWithValue("?", fCantidad);

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string sTipo = reader["Cmp_Tipo"].ToString();
                            float fDescuento = Convert.ToSingle(reader["Cmp_Descuento"]);

                            return (sTipo, fDescuento);
                        }
                    }
                }

                conexion.desconexion(conn);
            }

            return ("Publico", 0); // fallback
        }

        //OBTENER BODEGAS CON PRODUCTOS HAY DISPONIBILIDAD STOCK
        public DataTable ObtenerBodegasPorProducto(int pk_inventario_id)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_BODEGAS_POR_PRODUCTO, conn))
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

        public bool GuardarVentaCompleta(DateTime dCmp_Fecha_Venta, int iFk_Id_Cliente, int iFk_Id_Sucursal,
    string sCmp_Estado_Venta, string sCmp_Tipo_Operacion, float fCmp_Saldo_Total,
    DataTable detalle, DateTime dFecha_Especial, DateTime dCmp_Fecha_Vencimiento, bool bEsVenta)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcTransaction trans = conn.BeginTransaction();

                try
                {
                    int iPk_Id_Ventas = 0;

                    // PREPARAR FECHAS SEGÚN TIPO
                    DateTime? dFecha_Entrega = null;

                    if (sCmp_Tipo_Operacion == "Cotizacion" || sCmp_Tipo_Operacion == "Pedido")
                    {
                        dFecha_Entrega = dFecha_Especial;

                        // Mapear DataTable a lista de tuplas para el movimiento de inventario
                        var detalleInventario = detalle.AsEnumerable()
                            .Select(row => (
                                idInventario: row.Field<int>("IdProducto"),
                                idBodega: row.Field<int>("IdBodega"),
                                cantidad: row.Field<float>("Cantidad"),
                                idUnidad: row.Field<int>("IdUnidad")
                            ))
                            .ToList();

                        Cls_Mov_Inv_Controlador inventario = new Cls_Mov_Inv_Controlador();
                        bool actualizacionStock = inventario.fun_ApartarStock(
                            3,
                            dCmp_Fecha_Venta,
                            "Venta",
                            detalleInventario
                        );


                    }


                    // INSERTAR ENCABEZADO CON FECHAS
                    using (OdbcCommand cmdVenta = new OdbcCommand(SQL_INSERT_VENTA, conn, trans))
                    {
                        cmdVenta.Parameters.AddWithValue("?", dCmp_Fecha_Venta);
                        cmdVenta.Parameters.AddWithValue("?", iFk_Id_Cliente);
                        cmdVenta.Parameters.AddWithValue("?", iFk_Id_Sucursal);
                        cmdVenta.Parameters.AddWithValue("?", sCmp_Estado_Venta);
                        cmdVenta.Parameters.AddWithValue("?", sCmp_Tipo_Operacion);
                        cmdVenta.Parameters.AddWithValue("?", fCmp_Saldo_Total);

                        cmdVenta.ExecuteNonQuery();
                    }

                    // OBTENER ID GENERADO
                    using (OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", conn, trans))
                    {
                        iPk_Id_Ventas = Convert.ToInt32(cmdId.ExecuteScalar());
                    }

                    if (dFecha_Especial != DateTime.MinValue)
                    {
                        string campoFecha = "";

                        if (sCmp_Tipo_Operacion == "Cotizacion")
                        {
                            campoFecha = "Cmp_Fecha_Vencimiento";
                        }
                        else if (sCmp_Tipo_Operacion == "Pedido")
                        {
                            campoFecha = "Cmp_Fecha_Entrega";
                        }

                        if (!string.IsNullOrEmpty(campoFecha))
                        {
                            using (OdbcCommand cmdUpdateFecha = new OdbcCommand(
                                "UPDATE tbl_ventas SET " + campoFecha + " = ? WHERE Pk_Id_Ventas = ?", conn, trans))
                            {
                                cmdUpdateFecha.Parameters.AddWithValue("?", dFecha_Especial);
                                cmdUpdateFecha.Parameters.AddWithValue("?", iPk_Id_Ventas);
                                cmdUpdateFecha.ExecuteNonQuery();
                            }
                        }
                    }

                    // INSERTAR DETALLE
                    foreach (DataRow row in detalle.Rows)
                    {
                        using (OdbcCommand cmdDetalle = new OdbcCommand(SQL_INSERT_DETALLE, conn, trans))
                        {
                            cmdDetalle.Parameters.AddWithValue("?", iPk_Id_Ventas);
                            cmdDetalle.Parameters.AddWithValue("?", row["IdProducto"]);
                            cmdDetalle.Parameters.AddWithValue("?", row["Cantidad"]);
                            cmdDetalle.Parameters.AddWithValue("?", row["Subtotal"]);
                            cmdDetalle.Parameters.AddWithValue("?", 0);

                            cmdDetalle.ExecuteNonQuery();
                        }
                    }

                    // CREAR CUENTA POR COBRAR SOLO SI ES VENTA
                    if (bEsVenta)
                    {
                        {
                            //nuevo
                            // Mapear DataTable a lista de tuplas para el movimiento de inventario
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
                                3,
                                dCmp_Fecha_Venta,
                                "Venta",
                                detalleInventario
                            );
                        }

                        // SUMAR SALDO AL CLIENTE
                        using (OdbcCommand cmdUpdateCliente = new OdbcCommand(
                        "UPDATE tbl_clientes SET Cmp_Saldo_Total = Cmp_Saldo_Total + ? WHERE Pk_Id_Cliente = ?", conn, trans))
                        {
                            cmdUpdateCliente.Parameters.AddWithValue("?", fCmp_Saldo_Total);
                            cmdUpdateCliente.Parameters.AddWithValue("?", iFk_Id_Cliente);
                            cmdUpdateCliente.ExecuteNonQuery();
                        }
                        using (OdbcCommand cmdCuenta = new OdbcCommand(SQL_INSERT_CUENTA_COBRAR, conn, trans))
                        {
                            cmdCuenta.Parameters.AddWithValue("?", iPk_Id_Ventas);
                            cmdCuenta.Parameters.AddWithValue("?", iFk_Id_Cliente);
                            cmdCuenta.Parameters.AddWithValue("?", dCmp_Fecha_Venta);
                            cmdCuenta.Parameters.AddWithValue("?", dCmp_Fecha_Vencimiento);  // ← Aquí va la de vencimiento
                            cmdCuenta.Parameters.AddWithValue("?", fCmp_Saldo_Total);
                            cmdCuenta.Parameters.AddWithValue("?", "Activo");
                            cmdCuenta.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw new Exception("Error en BD: " + ex.Message);
                }
                finally
                {
                    conexion.desconexion(conn);
                }
            }
        }


        public int ObtenerIdCXCPorVenta(int idVenta)
        {
            Cls_ConexionBD conexionBD = new Cls_ConexionBD();
            OdbcConnection conn = null;

            try
            {
                conn = conexionBD.AbrirConexion();

                string query = @"
                    SELECT Pk_Id_Cuenta_Por_Cobrar 
                    FROM tbl_cuentas_por_cobrar 
                    WHERE Fk_Id_Venta = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("@idVenta", OdbcType.Int).Value = idVenta;
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && int.TryParse(resultado.ToString(), out int idCXC))
                    {
                        return idCXC;
                    }
                }

                return 0; // Retorna 0 si no encuentra CXC
            }
            catch (Exception ex)
            {
                // Solo registrar en consola, NO mostrar MessageBox aquí
                Console.WriteLine("Error en ObtenerIdCXCPorVenta: " + ex.Message);
                throw; // Relanza la excepción para que la vista la maneje
            }
            finally
            {
                if (conn != null)
                {
                    conexionBD.desconexion(conn);
                }
            }
        }
    }

}

 
