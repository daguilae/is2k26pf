using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Mov_Inv
{
    public class Cls_Dao_Mov_Inv
    {

        Cls_Conexion_MYSQL conexion = new Cls_Conexion_MYSQL();
        // Obtener ID MOVIMIENTO
        public DataTable fun_ObtenerIDMOV()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    pk_movimiento_id
                    FROM tbl_movimiento_inventario_encabezado; ";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en al obtener tipo de movimiento existencias" + ex.Message);
            }

            return dtResultado;
        }

        //================================================
        // Obtener Tipo Movimiento
        public DataTable fun_ObtenerTypeMov()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    pk_tipo_movimiento_id,
                    CONCAT(pk_tipo_movimiento_id, ' - ',nombre_tipo_inv, ' - ',efecto) AS TipoMov
                    FROM tbl_tipo_movimiento_inventario; ";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los Tipo Movimiento: " + ex.Message);
            }

            return dtResultado;
        }

        public string fun_ObtenerTypeMovVerificacion(int idTipoMov)
        {
            string sResultado = "";
            string sQuery = @"SELECT efecto 
                      FROM tbl_tipo_movimiento_inventario 
                      WHERE pk_tipo_movimiento_id = ?";
            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    {
                        oCmd.Parameters.AddWithValue("?", idTipoMov);

                        object result = oCmd.ExecuteScalar();
                        sResultado = result != null ? result.ToString() : "";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en al obtener tipo de movimiento " + ex.Message);
            }
            return sResultado;
        }
        //================================================
        // Obtener Detalle por movimiento
        public DataTable fun_ObtenerDetallesPorMovimiento(int idMovimiento)
        {
            DataTable dtDetalles = new DataTable();
            try
            {
                string sQuery = @"SELECT 
                            d.fk_movimiento_id,
                            d.fk_inventario_id,
                            i.nombre_prod,
                            d.fk_bodega_id,                  -- ← viene del detalle, no de existencias
                            b.Cmp_Nombre_Bodega,
                            e.fk_id_unidad_medida,
                            u.Nombre_Unidad,
                            d.cantidad_transaccionada
                        FROM tbl_movimiento_inventario_detalle d
                        INNER JOIN tbl_inventario i 
                              ON d.fk_inventario_id = i.pk_inventario_id
                        INNER JOIN tbl_existencias e 
                              ON d.fk_inventario_id = e.fk_inventario_id
                              AND d.fk_bodega_id    = e.fk_bodega_id     --  Agrega esta condición
                        INNER JOIN tbl_bodega b 
                              ON d.fk_bodega_id = b.Pk_Id_Bodega         --  Une desde detalle, no existencias
                        INNER JOIN tbl_unidad_de_medida u 
                              ON e.fk_id_unidad_medida = u.ID_Unidad
                        WHERE d.fk_movimiento_id = ?";

                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    {
                        oCmd.Parameters.AddWithValue("?", idMovimiento);
                        OdbcDataAdapter oDA = new OdbcDataAdapter(oCmd);
                        oDA.Fill(dtDetalles);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalles: " + ex.Message);
            }
            return dtDetalles;
        }
        //================================================
        // Obtener Stock
        public float fun_ObtenerStockActual(int idInventario, int idBodega)
        {
            float stock = 0;
            string sQuery = @"SELECT COALESCE(stock, 0) 
                      FROM tbl_existencias 
                      WHERE fk_inventario_id = ? 
                        AND fk_bodega_id = ?";
            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    {
                        oCmd.Parameters.AddWithValue("?", idInventario);
                        oCmd.Parameters.AddWithValue("?", idBodega);

                        object result = oCmd.ExecuteScalar();

                        // Si no existe el registro retorna 0 (para luego hacer INSERT)
                        stock = (result != null && result != DBNull.Value)
                                ? Convert.ToSingle(result)
                                : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener stock actual " + ex.Message);
            }
            return stock;
        }

        //================================================
        // Obtener Inventario
        public DataTable fun_ObtenerInventario()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    pk_inventario_id,
                    CONCAT(pk_inventario_id, ' - ', nombre_prod) AS INVENTARIO
                    FROM tbl_inventario; ";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en al obtener tipo de movimiento " + ex.Message);
            }

            return dtResultado;
        }
        //================================================
        // Obtener UnidadMedida
        public DataTable fun_ObtenerUnidadMedida()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    ID_Unidad,
                    CONCAT(ID_Unidad, ' - ', Nombre_Unidad ,' - ', Abreviacion_Medida) AS UNIDAD
                    FROM tbl_unidad_de_medida; ";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en al obtener id unidad " + ex.Message);
            }

            return dtResultado;
        }
        //================================================
        // Obtener Bodegas
        public DataTable fun_ObtenerBodega()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    Pk_Id_Bodega,
                    CONCAT(Pk_Id_Bodega, ' - ', Cmp_Nombre_Bodega) AS BODEGA
                    FROM tbl_bodega; ";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener bodegas " + ex.Message);
            }

            return dtResultado;
        }


        public bool fun_InsertarMovimientoCompleto(int idTipoMov, DateTime fechaMov, string descripcion,
                                            List<(int idInventario, int idBodega, float cantidad, int idUnidad )> detalle)
        {
            bool resultado = false;

            string sQueryEncabezado = @"INSERT INTO tbl_movimiento_inventario_encabezado 
                                (fk_tipo_movimiento_id, fecha_transaccion, descripcion) 
                                VALUES (?, ?, ?)";

            string sQueryDetalle = @"INSERT INTO tbl_movimiento_inventario_detalle 
                (fk_movimiento_id, fk_inventario_id, fk_bodega_id, cantidad_transaccionada)
                VALUES (?, ?, ?, ?)";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();

                    // Iniciar transacción
                    OdbcTransaction transaccion = oConn.BeginTransaction();

                    try
                    {
                        //  Insertar encabezado
                        int idMovimientoGenerado = 0;
                        using (OdbcCommand oCmdEnc = new OdbcCommand(sQueryEncabezado, oConn, transaccion))
                        {
                            oCmdEnc.Parameters.AddWithValue("?", idTipoMov);
                            oCmdEnc.Parameters.AddWithValue("?", fechaMov.ToString("yyyy-MM-dd HH:mm:ss"));
                            oCmdEnc.Parameters.AddWithValue("?", descripcion);
                            oCmdEnc.ExecuteNonQuery();
                        }

                        //  Obtener ID generado del encabezado
                        using (OdbcCommand oCmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", oConn, transaccion))
                        {
                            idMovimientoGenerado = Convert.ToInt32(oCmdId.ExecuteScalar());
                        }

                        //  Insertar cada fila del detalle
                        foreach (var item in detalle)
                        {
                            using (OdbcCommand oCmdDet = new OdbcCommand(sQueryDetalle, oConn, transaccion))
                            {
                                oCmdDet.Parameters.AddWithValue("?", idMovimientoGenerado);
                                oCmdDet.Parameters.AddWithValue("?", item.idInventario);
                                oCmdDet.Parameters.AddWithValue("?", item.idBodega);
                                oCmdDet.Parameters.AddWithValue("?", item.cantidad);
                                oCmdDet.ExecuteNonQuery();
                            }
                        }

                        //  Si todo salió bien, confirmar transacción
                        transaccion.Commit();
                        resultado = true;
                        Console.WriteLine("Transacción completada. ID movimiento: " + idMovimientoGenerado);
                    }
                    catch (Exception ex)
                    {
                        //  Si algo falló, revertir TODO incluyendo el encabezado
                        transaccion.Rollback();
                        resultado = false;
                        throw new Exception("Error en insertar movimiento inventario " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión " + ex.Message);
            }

            return resultado;
        }
        //========================================================
        //Actualizar stock
        public bool fun_ActualizarStock(List<(int idInventario, int idBodega,float stockNuevo, int EstadoExistencia,int idUnidad)> listaStock)
        {
            bool resultado = false;

            string sQueryVerificar = @"SELECT COUNT(1) 
                                FROM tbl_existencias 
                                WHERE fk_inventario_id = ? 
                                  AND fk_bodega_id = ?";

            string sQueryUpdate = @"UPDATE tbl_existencias 
                        SET stock = ?,
                            estado_existencia = ?,
                            fk_id_unidad_medida = ?
                        WHERE fk_inventario_id = ? 
                          AND fk_bodega_id = ?";


            string sQueryInsert = @"INSERT INTO tbl_existencias 
                                (fk_inventario_id, fk_bodega_id, stock, estado_existencia, fk_id_unidad_medida) 
                            VALUES (?, ?, ?, ?, ?)";
            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    OdbcTransaction transaccion = oConn.BeginTransaction();

                    try
                    {
                        foreach (var item in listaStock)
                        {
                            // Verificar si existe el registro
                            int existe = 0;
                            using (OdbcCommand oCmdVerificar = new OdbcCommand(sQueryVerificar, oConn, transaccion))
                            {
                                oCmdVerificar.Parameters.AddWithValue("?", item.idInventario);
                                oCmdVerificar.Parameters.AddWithValue("?", item.idBodega);
                                existe = Convert.ToInt32(oCmdVerificar.ExecuteScalar());
                            }

                            // Insert o Update según resultado
                            if (existe > 0)
                            {
                                // UPDATE
                                using (OdbcCommand oCmdUpdate = new OdbcCommand(sQueryUpdate, oConn, transaccion))
                                {
                                    oCmdUpdate.Parameters.AddWithValue("?", item.stockNuevo);        
                                    oCmdUpdate.Parameters.AddWithValue("?", item.EstadoExistencia); 
                                    oCmdUpdate.Parameters.AddWithValue("?", item.idUnidad);          
                                    oCmdUpdate.Parameters.AddWithValue("?", item.idInventario);      
                                    oCmdUpdate.Parameters.AddWithValue("?", item.idBodega);          
                                    oCmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // INSERT
                                using (OdbcCommand oCmdInsert = new OdbcCommand(sQueryInsert, oConn, transaccion))
                                {
                                    oCmdInsert.Parameters.AddWithValue("?", item.idInventario);
                                    oCmdInsert.Parameters.AddWithValue("?", item.idBodega);
                                    oCmdInsert.Parameters.AddWithValue("?", item.stockNuevo);
                                    oCmdInsert.Parameters.AddWithValue("?", item.EstadoExistencia);
                                    oCmdInsert.Parameters.AddWithValue("?", item.idUnidad);
                                    oCmdInsert.ExecuteNonQuery();
                                }
                            }
                        }

                        transaccion.Commit(); //Todo bien, confirmar
                        resultado = true;
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback(); // Algo falló, revertir todo
                        throw new Exception("Error en al sentencias al actualizar existencias " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión " + ex.Message);
            }

            return resultado;
        }
        //==================================================================
        //APARTAR STOCK
        public bool fun_ApartarStockDao(List<(int idInventario, int idBodega, float stockNuevo,
                                      float CantidadApartada, int EstadoExistencia, int idUnidad)> listaStock)
        {
            string sQueryUpdate = @"UPDATE tbl_existencias 
                            SET stock = ?,
                                stock_Apartado = ?,
                                estado_existencia = ?,
                                fk_id_unidad_medida = ?
                            WHERE fk_inventario_id = ? 
                              AND fk_bodega_id = ?";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    OdbcTransaction transaccion = oConn.BeginTransaction();
                    try
                    {
                      
                        foreach (var item in listaStock)
                        {
                            // UPDATE del registro existente
                            using (OdbcCommand oCmdUpdate = new OdbcCommand(sQueryUpdate, oConn, transaccion))
                            {
                                oCmdUpdate.Parameters.AddWithValue("?", item.stockNuevo);
                                oCmdUpdate.Parameters.AddWithValue("?", item.CantidadApartada);
                                oCmdUpdate.Parameters.AddWithValue("?", item.EstadoExistencia);
                                oCmdUpdate.Parameters.AddWithValue("?", item.idUnidad);
                                oCmdUpdate.Parameters.AddWithValue("?", item.idInventario);
                                oCmdUpdate.Parameters.AddWithValue("?", item.idBodega);
                                oCmdUpdate.ExecuteNonQuery();
                            }

                        }

                        transaccion.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        Console.WriteLine("Error al apartar stock");
                        throw new Exception("Error al ejecutar Apartado Stock: " + ex.Message);            
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error conexión stock apartar");
                throw new Exception("Error de conexión: " + ex.Message);
            }
        }
    }
}
