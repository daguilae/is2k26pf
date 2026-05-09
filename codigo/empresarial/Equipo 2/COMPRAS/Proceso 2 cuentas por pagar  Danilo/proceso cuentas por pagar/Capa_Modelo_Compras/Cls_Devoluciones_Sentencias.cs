using Capa_Modelo_CXP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Compras
{
    public class Cls_Devoluciones_Sentencias
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        public DataTable Fun_MostrarComprasParaDevolucion()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT 
                        c.pk_id_compra AS IdCompra,
                        c.cmp_numero_factura AS NumeroFactura,
                        p.cmp_Nombre_Proveedor AS Proveedor,
                        c.cmp_fecha AS FechaCompra,
                        c.cmp_total AS TotalCompra,
                        c.cmp_estado AS EstadoCompra
                    FROM tbl_compra c
                    INNER JOIN tbl_proveedores p 
                        ON c.fk_id_proveedor = p.pk_id_proveedor
                    ORDER BY c.pk_id_compra DESC;
                ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_ObtenerIdsCompra()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT pk_id_compra 
                    FROM tbl_compra
                    ORDER BY pk_id_compra DESC;
                ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_ObtenerFacturas()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT cmp_numero_factura
                    FROM tbl_compra
                    ORDER BY cmp_numero_factura;
                ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_ObtenerProveedores()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT 
                        pk_id_proveedor,
                        cmp_Nombre_Proveedor
                    FROM tbl_proveedores
                    ORDER BY cmp_Nombre_Proveedor;
                ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_BuscarCompraPorId(int idCompra)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT 
                        c.pk_id_compra AS IdCompra,
                        c.cmp_numero_factura AS NumeroFactura,
                        c.cmp_fecha AS FechaCompra,
                        c.fk_id_proveedor AS IdProveedor,
                        p.cmp_Nombre_Proveedor AS Proveedor,
                        c.cmp_total AS TotalCompra,
                        c.cmp_estado AS EstadoCompra,
                        cxp.pk_id_cuenta_por_pagar AS IdCuentaPorPagar,
                        cxp.cmp_estado AS EstadoCXP
                    FROM tbl_compra c
                    INNER JOIN tbl_proveedores p 
                        ON c.fk_id_proveedor = p.pk_id_proveedor
                    LEFT JOIN tbl_cuentas_por_pagar cxp
                        ON c.pk_id_compra = cxp.fk_id_compra
                    WHERE c.pk_id_compra = ?;
                ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", idCompra);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_ObtenerDetalleCompra(int idCompra)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT 
                        dc.pk_id_detalle_compra AS IdDetalleCompra,
                        dc.fk_id_compra AS IdCompra,
                        dc.fk_inventario_id AS IdInventario,
                        i.nombre_prod AS Producto,
                        dc.cmp_cantidad AS CantidadComprada,
                        um.Nombre_Unidad AS Unidad,
                        dc.cmp_precio AS PrecioUnitario,
                        (dc.cmp_cantidad * dc.cmp_precio) AS Subtotal
                    FROM tbl_detalle_compra dc
                    INNER JOIN tbl_inventario i
                        ON dc.fk_inventario_id = i.pk_inventario_id
                    WHERE dc.fk_id_compra = ?;
                ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", idCompra);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Fun_MostrarDevoluciones()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = new OdbcConnection(conexion.ObtenerCadenaConexion()))
            {
                string sql = @"
                    SELECT
                        d.pk_id_devolucion AS IdDevolucion,
                        d.fk_id_compra AS IdCompra,
                        c.cmp_numero_factura AS NumeroFactura,
                        p.cmp_Nombre_Proveedor AS Proveedor,
                        d.cmp_fecha_devolucion AS FechaDevolucion,
                        d.cmp_motivo AS Motivo,
                        d.cmp_tipo_devolucion AS TipoDevolucion,
                        d.cmp_valor_monetario AS ValorMonetario,
                        d.cmp_estado AS Estado
                    FROM tbl_devoluciones d
                    INNER JOIN tbl_compra c
                        ON d.fk_id_compra = c.pk_id_compra
                    INNER JOIN tbl_proveedores p
                        ON d.fk_id_proveedor = p.pk_id_proveedor
                    ORDER BY d.pk_id_devolucion DESC;
                ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }
    }
}
