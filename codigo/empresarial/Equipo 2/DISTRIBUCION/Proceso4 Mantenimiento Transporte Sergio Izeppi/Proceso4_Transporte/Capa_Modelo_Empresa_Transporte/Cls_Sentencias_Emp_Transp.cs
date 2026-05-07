using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Empresa_Transporte
{
    public class Cls_Sentencias_Emp_Transp
    {
        public DataTable fun_ObtenerEmpresa()
        {
            Cls_Conexion_Emp_Transp conexion = new Cls_Conexion_Emp_Transp();
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaEmpresa = "SELECT e.pk_id_empresa AS codigoEmpresa, e.cmp_nombre_empresa as Nombre FROM tbl_empresa_transporte e";
                    OdbcCommand cmd = new OdbcCommand(sConsultaEmpresa, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las empresas: " + ex.Message, ex);
            }
            return tabla;
        }

        public DataTable fun_ObtenerTransporte()
        {
            Cls_Conexion_Emp_Transp conexion = new Cls_Conexion_Emp_Transp();
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaTransporte = @"SELECT 
                                                    t.Pk_Id_Transporte AS codigo, 
                                                    e.cmp_nombre_empresa AS empresa, 
                                                    t.Cmp_Tipo_Transporte AS tipo, 
                                                    t.Cmp_Placa AS placa, 
                                                    t.Cmp_Nombre_Piloto AS piloto, 
                                                    t.Cmp_Capacidad AS capacidad, 
                                                    t.Cmp_Estado_Transporte AS estado
                                                FROM 
                                                    tbl_tipo_transporte t
                                                LEFT JOIN 
                                                    tbl_empresa_transporte e ON t.Fk_Id_Empresa = e.pk_id_empresa;";
                    OdbcCommand cmd = new OdbcCommand(sConsultaTransporte, con);

                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los tipos de transporte: " + ex.Message, ex);
            }
            return tabla;
        }

        public void pro_GuardarTransporte( int iCodigoEmpresa, string sTipoTransp, string sPlaca, string sNombreP, int iCapacidad, string sEstado)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sql = "INSERT INTO tbl_tipo_transporte (Fk_Id_Empresa, Cmp_Tipo_Transporte, Cmp_Placa, Cmp_Nombre_Piloto, Cmp_Capacidad, Cmp_Estado_Transporte) "
                        +"VALUES ( ?, ?, ?, ?, ?, ?)";

                    OdbcCommand cmd = new OdbcCommand(sql, con);

                    cmd.Parameters.AddWithValue("", iCodigoEmpresa);
                    cmd.Parameters.AddWithValue("", sTipoTransp);
                    cmd.Parameters.AddWithValue("", sPlaca);
                    cmd.Parameters.AddWithValue("", sNombreP);
                    cmd.Parameters.AddWithValue("", iCapacidad);
                    cmd.Parameters.AddWithValue("", sEstado);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void pro_ModificarTransporte(int iCodigoTransporte, int iCodigoEmpresa, string sTipoTransp, string sPlaca, string sNombreP, int iCapacidad, string sEstado)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sql = @"UPDATE tbl_tipo_transporte
                           SET Fk_Id_Empresa = ?,
                               Cmp_Tipo_Transporte = ?,
                               Cmp_Placa = ?,
                               Cmp_Nombre_Piloto = ?,
                               Cmp_Capacidad = ?,
                               Cmp_Estado_Transporte = ?
                           WHERE Pk_Id_Transporte = ?";

                    OdbcCommand cmd = new OdbcCommand(sql, con);

                    cmd.Parameters.AddWithValue("", iCodigoEmpresa);
                    cmd.Parameters.AddWithValue("", sTipoTransp);
                    cmd.Parameters.AddWithValue("", sPlaca);
                    cmd.Parameters.AddWithValue("", sNombreP);
                    cmd.Parameters.AddWithValue("", iCapacidad);
                    cmd.Parameters.AddWithValue("", sEstado);

                    // ESTE VA AL FINAL POR EL WHERE
                    cmd.Parameters.AddWithValue("", iCodigoTransporte);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar transporte: " + ex.Message);
            }
        }

        public void pro_EliminarTransporte(int iCodigoTransporte)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sEliminar = @"DELETE FROM tbl_tipo_transporte
                                           WHERE Pk_Id_Transporte = ?";
                    OdbcCommand cmd = new OdbcCommand(sEliminar, con);
                    cmd.Parameters.AddWithValue("", iCodigoTransporte);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar: " + ex.Message, ex);
            }
        }

        //Compra
        public DataTable fun_ObtenerCompra()
        {
            Cls_Conexion_Emp_Transp conexion = new Cls_Conexion_Emp_Transp();
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaTransporte = @"SELECT 
                                                e.Pk_Id_Entrega_Compra AS codigo, 
                                                e.Fk_Id_Compra AS compra, 
                                                i.nombre_prod AS producto,
                                                dc.cmp_cantidad AS cantidad,
                                                e.Fk_Id_Transporte AS transporte, 
                                                e.Cmp_Direccion AS direccion, 
                                                e.Cmp_Fecha AS fecha, 
                                                e.Cmp_Estado_Entrega AS estado
                                            FROM tbl_entrega_compra e
                                            INNER JOIN tbl_detalle_compra dc ON e.Fk_Id_Compra = dc.fk_id_compra
                                            INNER JOIN tbl_inventario i ON dc.fk_inventario_id = i.pk_inventario_id;";
                    OdbcCommand cmd = new OdbcCommand(sConsultaTransporte, con);

                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las entregas de compras: " + ex.Message, ex);
            }
            return tabla;
        }

        public void pro_GuardarCompra(int iCodigoCompra, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sql = "INSERT INTO tbl_entrega_compra (Fk_Id_Compra, Fk_Id_Transporte, Cmp_Direccion, Cmp_Fecha, Cmp_Estado_Entrega) "
                        + "VALUES ( ?, ?, ?, ?, ?)";

                    OdbcCommand cmd = new OdbcCommand(sql, con);

                    cmd.Parameters.AddWithValue("", iCodigoCompra);
                    cmd.Parameters.AddWithValue("", iCodigoTransporte);
                    cmd.Parameters.AddWithValue("", sDireccion);
                    cmd.Parameters.AddWithValue("", sFecha);
                    cmd.Parameters.AddWithValue("", sEstado);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void pro_ModificarCompra(int iCodigoEntrega, int iCodigoCompra, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sql = @"UPDATE tbl_entrega_compra
                           SET Fk_Id_Compra = ?,
                               Fk_Id_Transporte = ?,
                               Cmp_Direccion = ?,
                               Cmp_Fecha = ?,
                               Cmp_Estado_Entrega = ?
                           WHERE Pk_Id_Entrega_Compra = ?;";

                    OdbcCommand cmd = new OdbcCommand(sql, con);

                    // Respetamos el orden de los '?'
                    cmd.Parameters.AddWithValue("", iCodigoCompra);      // ? 1
                    cmd.Parameters.AddWithValue("", iCodigoTransporte);  // ? 2
                    cmd.Parameters.AddWithValue("", sDireccion);         // ? 3
                    cmd.Parameters.AddWithValue("", sFecha);             // ? 4
                    cmd.Parameters.AddWithValue("", sEstado);            // ? 5

                    // CORRECCIÓN: Ahora usamos el ID de la entrega para el WHERE (el 6to ?)
                    cmd.Parameters.AddWithValue("", iCodigoEntrega);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la Entrega de Compra: " + ex.Message);
            }
        }

        public bool fun_ExisteEntregaCompra(int iCodigoCompra)
            {
                bool existe = false;
                try
                {
                    using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                    {
                        string sql = @"SELECT COUNT(*) 
                           FROM tbl_entrega_compra
                           WHERE Fk_Id_Compra = ?";

                        OdbcCommand cmd = new OdbcCommand(sql, con);
                        cmd.Parameters.AddWithValue("", iCodigoCompra);
                        int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                        existe = cantidad > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al verificar entrega: " + ex.Message);
                }
                return existe;
            }

        public void pro_EliminarCompra(int iCodigoEntrega)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sEliminar = @"DELETE FROM tbl_entrega_compra
                                           WHERE Pk_Id_Entrega_Compra = ?";
                    OdbcCommand cmd = new OdbcCommand(sEliminar, con);
                    cmd.Parameters.AddWithValue("", iCodigoEntrega);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar: " + ex.Message, ex);
            }
        }

        //Venta
        public DataTable fun_ObtenerVenta()
        {
            Cls_Conexion_Emp_Transp conexion = new Cls_Conexion_Emp_Transp();
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaVenta = @"SELECT 
                                        v.Pk_Id_Entrega_Venta AS codigo, 
                                        v.Fk_Id_Venta AS venta, 
										i.nombre_prod AS Producto, 
										dv.Cmp_Cantidad_Producto AS Cantidad,
                                        v.Fk_Id_Transporte AS transporte, 
                                        v.Cmp_Direccion AS direccion, 
                                        DATE_FORMAT(v.Cmp_Fecha, '%d/%m/%Y') AS fecha, 
                                        v.Cmp_Estado_Entrega AS estado
                                    FROM tbl_entrega_venta v  
                                    INNER JOIN tbl_detalle_ventas dv ON v.Fk_Id_Venta = dv.Fk_Id_Ventas
									INNER JOIN tbl_inventario i ON dv.Fk_Id_Inventario = i.pk_inventario_id";

                    OdbcCommand cmd = new OdbcCommand(sConsultaVenta, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las entregas de ventas: " + ex.Message, ex);
            }
            return tabla;
        }

        public void pro_GuardarVenta(int iCodigoVenta, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sql = "INSERT INTO tbl_entrega_venta (Fk_Id_Venta, Fk_Id_Transporte, Cmp_Direccion, Cmp_Fecha, Cmp_Estado_Entrega) "
                               + "VALUES (?, ?, ?, ?, ?)";

                    OdbcCommand cmd = new OdbcCommand(sql, con);

                    cmd.Parameters.AddWithValue("", iCodigoVenta);
                    cmd.Parameters.AddWithValue("", iCodigoTransporte);
                    cmd.Parameters.AddWithValue("", sDireccion);
                    cmd.Parameters.AddWithValue("", sFecha);
                    cmd.Parameters.AddWithValue("", sEstado);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la entrega de venta: " + ex.Message);
            }
        }

        public bool fun_ExisteEntregaVenta(int iCodigoVenta)
        {
            bool existe = false;
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sql = @"SELECT COUNT(*) 
                           FROM tbl_entrega_venta
                           WHERE Fk_Id_Venta = ?";

                    OdbcCommand cmd = new OdbcCommand(sql, con);
                    cmd.Parameters.AddWithValue("", iCodigoVenta);
                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                    existe = cantidad > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar entrega: " + ex.Message);
            }
            return existe;
        }

        public void pro_ModificarVenta(int iCodigoEntrega, int iCodigoVenta, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    // El WHERE usa Pk_Id_Entrega_Venta, que es el 6to '?'
                    string sql = @"UPDATE tbl_entrega_venta
                           SET Fk_Id_Venta = ?,
                               Fk_Id_Transporte = ?,
                               Cmp_Direccion = ?,
                               Cmp_Fecha = ?,
                               Cmp_Estado_Entrega = ?
                           WHERE Pk_Id_Entrega_Venta = ?;";

                    OdbcCommand cmd = new OdbcCommand(sql, con);

                    // Los parámetros deben seguir el orden exacto de los '?'
                    cmd.Parameters.AddWithValue("", iCodigoVenta);        // ? 1
                    cmd.Parameters.AddWithValue("", iCodigoTransporte);   // ? 2
                    cmd.Parameters.AddWithValue("", sDireccion);          // ? 3
                    cmd.Parameters.AddWithValue("", sFecha);              // ? 4
                    cmd.Parameters.AddWithValue("", sEstado);             // ? 5

                    // CORRECCIÓN: Aquí debe ir el ID de la entrega para el WHERE
                    cmd.Parameters.AddWithValue("", iCodigoEntrega);      // ? 6

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la Entrega de Venta: " + ex.Message);
            }
        }

        public void pro_EliminarVenta(int iCodigoEntrega)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sEliminar = @"DELETE FROM tbl_entrega_venta
                                           WHERE Pk_Id_Entrega_Venta = ?";
                    OdbcCommand cmd = new OdbcCommand(sEliminar, con);
                    cmd.Parameters.AddWithValue("", iCodigoEntrega);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar: " + ex.Message, ex);
            }
        }

        //Produccion
        public DataTable fun_ObtenerProduccion()
        {
            Cls_Conexion_Emp_Transp conexion = new Cls_Conexion_Emp_Transp();
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaProduccion = @"SELECT 
                                                p.Pk_Id_Entrega_Produccion AS codigo, 
                                                p.Fk_Id_OrdenP AS produccion, 
                                                i.nombre_prod AS Producto,
                                                dp.Cmp_Cantidad_Solicitada AS Cantidad,
                                                p.Fk_Id_Transporte AS transporte, 
                                                p.Cmp_Direccion AS direccion, 
                                                p.Cmp_Fecha AS fecha, 
                                                p.Cmp_Estado_Entrega AS estado
                                            FROM tbl_entrega_produccion p
                                            INNER JOIN tbl_orden_produccion_detalle dp ON p.Fk_Id_OrdenP = dp.Fk_ID_OrdenProduccion
                                            INNER JOIN tbl_inventario i ON dp.Fk_ID_Producto = i.pk_inventario_id";

                    OdbcCommand cmd = new OdbcCommand(sConsultaProduccion, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la producción: " + ex.Message);
            }

            return tabla;
        }

        public void pro_GuardarProduccion(int iCodigoOrdenP, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    // Consulta adaptada a tbl_entrega_produccion
                    string sql = "INSERT INTO tbl_entrega_produccion (Fk_Id_OrdenP, Fk_Id_Transporte, Cmp_Direccion, Cmp_Fecha, Cmp_Estado_Entrega) "
                               + "VALUES (?, ?, ?, ?, ?)";

                    OdbcCommand cmd = new OdbcCommand(sql, con);

                    // Los parámetros se agregan en el mismo orden que los '?' en el SQL
                    cmd.Parameters.AddWithValue("", iCodigoOrdenP);
                    cmd.Parameters.AddWithValue("", iCodigoTransporte);
                    cmd.Parameters.AddWithValue("", sDireccion);
                    cmd.Parameters.AddWithValue("", sFecha);
                    cmd.Parameters.AddWithValue("", sEstado);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la entrega de producción: " + ex.Message);
            }
        }

        public bool fun_ExisteEntregaProduccion(int iCodigoOrdenP)
        {
            bool existe = false;
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sql = @"SELECT COUNT(*) 
                           FROM tbl_entrega_produccion
                           WHERE Fk_Id_OrdenP = ?";

                    OdbcCommand cmd = new OdbcCommand(sql, con);
                    cmd.Parameters.AddWithValue("", iCodigoOrdenP);
                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                    existe = cantidad > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar entrega: " + ex.Message);
            }
            return existe;
        }

        public void pro_ModificarProduccion(int iCodigoEntrega, int iCodigoOrdenP, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sql = @"UPDATE tbl_entrega_produccion
                           SET Fk_Id_OrdenP = ?,
                               Fk_Id_Transporte = ?,
                               Cmp_Direccion = ?,
                               Cmp_Fecha = ?,
                               Cmp_Estado_Entrega = ?
                           WHERE Pk_Id_Entrega_Produccion = ?;";

                    OdbcCommand cmd = new OdbcCommand(sql, con);

                    cmd.Parameters.AddWithValue("", iCodigoOrdenP);       
                    cmd.Parameters.AddWithValue("", iCodigoTransporte);  
                    cmd.Parameters.AddWithValue("", sDireccion);         
                    cmd.Parameters.AddWithValue("", sFecha);             
                    cmd.Parameters.AddWithValue("", sEstado);            

                    cmd.Parameters.AddWithValue("", iCodigoEntrega);     

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la Entrega de Producción: " + ex.Message);
            }
        }

        public void pro_EliminarProduccion(int iCodigoEntrega)
        {
            try
            {
                using (OdbcConnection con = new Cls_Conexion_Emp_Transp().conexion())
                {
                    string sEliminar = @"DELETE FROM tbl_entrega_produccion
                                           WHERE Pk_Id_Entrega_Produccion = ?";
                    OdbcCommand cmd = new OdbcCommand(sEliminar, con);
                    cmd.Parameters.AddWithValue("", iCodigoEntrega);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar: " + ex.Message, ex);
            }
        }
    }
}
