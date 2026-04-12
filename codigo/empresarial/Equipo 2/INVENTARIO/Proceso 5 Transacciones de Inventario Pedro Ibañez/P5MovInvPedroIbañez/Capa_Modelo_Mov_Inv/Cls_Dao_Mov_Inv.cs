using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Console.WriteLine("Error al obtener los movimientos: " + ex.Message);
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

        //================================================
        // Obtener Tipo Movimiento
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
                Console.WriteLine("Error al obtener los Tipo Movimiento: " + ex.Message);
            }

            return dtResultado;
        }

    }
}
