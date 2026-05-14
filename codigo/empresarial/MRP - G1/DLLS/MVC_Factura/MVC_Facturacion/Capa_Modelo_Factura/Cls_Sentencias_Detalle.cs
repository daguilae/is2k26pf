using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_Factura
{
    public class Cls_Sentencias_Detalle
    {
        Cls_Conexion conexion = new Cls_Conexion();
        public DataTable fun_ObtenerDatosFactura(int iCodigoFactura)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaFactura = @"SELECT f.Pk_Id_Detalle_Factura AS CodigoDetalle, f.Fk_Id_Factura AS CodigoEncabezado,
                                            f.Fk_Id_Orden_Produccion AS CodigoOrden, f.Total_Materiales AS TotalMateriales,
                                            f.Total_Mano_Obra AS TotalManoObra, f.Total_Costos_Indirectos AS TotalCostos,
                                            f.Total_Mermas AS TotalMermas, f.Total_Fases AS TotalFases, f.Subtotal AS Subtotal
                                            FROM Tbl_Factura_Produccion_Detalle f
                                            WHERE f.Fk_Id_Factura = ?";
                    OdbcCommand cmd = new OdbcCommand(sConsultaFactura, con);
                    cmd.Parameters.AddWithValue("", iCodigoFactura);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de factura " + ex.Message, ex);
            }
            return tabla;
        }
    }
}
