using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

//Kenph Luna 29/04/2026
namespace Capa_Modelo_OrdenProduccion
{
    public class Cls_ProduccionDAO
    {
        private Cls_Conexion cConexion = new Cls_Conexion();
        private Cls_SentenciasSQL cSQL = new Cls_SentenciasSQL();

        public int InsertarOrdenProduccion(int iIdVendedor, DateTime dFechaEmision, DateTime dFechaEstimada, string sEstado, List<(int iIdProducto, int iCantidadSolicitada, int iCantidadRecibida)> lDetalles)
        {
            int iIdOrdenGenerada = 0;

            using (OdbcConnection cConn = cConexion.AbrirConexion())
            using (OdbcTransaction cTrans = cConn.BeginTransaction())
            {
                try
                {
                    // 1 Encabezado
                    using (OdbcCommand cCmdEnc = new OdbcCommand(Cls_SentenciasSQL.sInsertarEncabezadoProduccion, cConn, cTrans))
                    {
                        cCmdEnc.Parameters.Add("p1", OdbcType.Int).Value = iIdVendedor;
                        cCmdEnc.Parameters.Add("p2", OdbcType.Date).Value = dFechaEmision.Date;
                        cCmdEnc.Parameters.Add("p3", OdbcType.VarChar, 50).Value = sEstado;

                        cCmdEnc.Parameters.Add("p4", OdbcType.Date).Value = dFechaEstimada.Date;

                        cCmdEnc.ExecuteNonQuery();
                    }

                    // 2 trae el id asignado
                    using (OdbcCommand cCmdId = new OdbcCommand(Cls_SentenciasSQL.sObtenerUltimoId, cConn, cTrans))
                    {
                        iIdOrdenGenerada = Convert.ToInt32(cCmdId.ExecuteScalar());
                    }

                    // 3 Insertar detalles
                    foreach (var det in lDetalles)
                    {
                        using (OdbcCommand cCmdDet = new OdbcCommand(Cls_SentenciasSQL.sInsertarDetalleProduccion, cConn, cTrans))
                        {
                            cCmdDet.Parameters.Add("p1", OdbcType.Int).Value = iIdOrdenGenerada;
                            cCmdDet.Parameters.Add("p2", OdbcType.Int).Value = det.iIdProducto;
                            cCmdDet.Parameters.Add("p3", OdbcType.Int).Value = det.iCantidadSolicitada;
                            cCmdDet.Parameters.Add("p4", OdbcType.Int).Value = det.iCantidadRecibida;

                            cCmdDet.ExecuteNonQuery();
                        }
                    }

                    cTrans.Commit();
                    return iIdOrdenGenerada;
                }
                catch (Exception ex)
                {
                    cTrans.Rollback();
                    throw new Exception("Error al insertar la Orden de Producción: " + ex.Message);
                }
            }
        }

        //Actualizar
        public void ActualizarOrdenProduccion(int idOrden, int iIdVendedor, DateTime dFechaEmision, DateTime dFechaEstimada, string sEstado, List<(int iIdProducto, int iCantidadSolicitada, int iCantidadRecibida)> lDetalles)
        {
            using (OdbcConnection cConn = cConexion.AbrirConexion())
            using (OdbcTransaction cTrans = cConn.BeginTransaction())
            {
                try
                {
                    //Actualizar el Encabezado
                    using (OdbcCommand cCmdEnc = new OdbcCommand(Cls_SentenciasSQL.sActualizarEncabezadoProduccion, cConn, cTrans))
                    {
                        cCmdEnc.Parameters.Add("p1", OdbcType.Int).Value = iIdVendedor;
                        cCmdEnc.Parameters.Add("p2", OdbcType.Date).Value = dFechaEmision.Date;
                        cCmdEnc.Parameters.Add("p3", OdbcType.VarChar, 50).Value = sEstado;
                        cCmdEnc.Parameters.Add("p4", OdbcType.Date).Value = dFechaEstimada.Date;
                        cCmdEnc.Parameters.Add("p5", OdbcType.Int).Value = idOrden; 
                        cCmdEnc.ExecuteNonQuery();
                    }

                    // borrar todos los detalles anteriores de esta orden
                    using (OdbcCommand cCmdDel = new OdbcCommand(Cls_SentenciasSQL.sEliminarDetallesPorOrden, cConn, cTrans))
                    {
                        cCmdDel.Parameters.Add("p1", OdbcType.Int).Value = idOrden;
                        cCmdDel.ExecuteNonQuery();
                    }

                    // actualizar los nuevos detalles que quedaron en el dgv
                    foreach (var det in lDetalles)
                    {
                        using (OdbcCommand cCmdDet = new OdbcCommand(Cls_SentenciasSQL.sInsertarDetalleProduccion, cConn, cTrans))
                        {
                            cCmdDet.Parameters.Add("p1", OdbcType.Int).Value = idOrden;
                            cCmdDet.Parameters.Add("p2", OdbcType.Int).Value = det.iIdProducto;
                            cCmdDet.Parameters.Add("p3", OdbcType.Int).Value = det.iCantidadSolicitada;
                            cCmdDet.Parameters.Add("p4", OdbcType.Int).Value = det.iCantidadRecibida;
                            cCmdDet.ExecuteNonQuery();
                        }
                    }

                    cTrans.Commit();
                }
                catch (Exception ex)
                {
                    cTrans.Rollback();
                    throw new Exception("Error al actualizar la Orden: " + ex.Message);
                }
            }
        }

        public void EliminarOrdenProduccion(int idOrden)
        {
            using (OdbcConnection cConn = cConexion.AbrirConexion())
            using (OdbcTransaction cTrans = cConn.BeginTransaction())
            {
                try
                {
                    // se borrar detalles
                    using (OdbcCommand cCmdDelDet = new OdbcCommand(Cls_SentenciasSQL.sEliminarDetallesPorOrden, cConn, cTrans))
                    {
                        cCmdDelDet.Parameters.Add("p1", OdbcType.Int).Value = idOrden;
                        cCmdDelDet.ExecuteNonQuery();
                    }

                    //se borra el encabezado
                    using (OdbcCommand cCmdDelEnc = new OdbcCommand(Cls_SentenciasSQL.sEliminarEncabezadoProduccion, cConn, cTrans))
                    {
                        cCmdDelEnc.Parameters.Add("p1", OdbcType.Int).Value = idOrden;
                        cCmdDelEnc.ExecuteNonQuery();
                    }

                    cTrans.Commit();
                }
                catch (Exception ex)
                {
                    cTrans.Rollback();
                    throw new Exception("Error al eliminar la Orden: " + ex.Message);
                }
            }
        }


        //Obtener datos encabezado y detalle
        public DataTable ObtenerDatos(string consultaSql)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection cConn = cConexion.AbrirConexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(consultaSql, cConn))
                {
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable ObtenerDetalles(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection cConn = cConexion.AbrirConexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(Cls_SentenciasSQL.sObtenerDetallesPorOrden, cConn))
                {
                    cmd.Parameters.Add("p1", OdbcType.Int).Value = idOrden;
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable ObtenerReporteOrdenes()
        {
            DataTable dtReporte = new DataTable();
            using (OdbcConnection cConn = cConexion.AbrirConexion())
            {
                try
                {
                    using (OdbcDataAdapter adaptador = new OdbcDataAdapter(Cls_SentenciasSQL.sReporteOrdenes, cConn))
                    {
                        adaptador.Fill(dtReporte);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos para el reporte: " + ex.Message);
                }
            }

            return dtReporte;
        }



    }
}
