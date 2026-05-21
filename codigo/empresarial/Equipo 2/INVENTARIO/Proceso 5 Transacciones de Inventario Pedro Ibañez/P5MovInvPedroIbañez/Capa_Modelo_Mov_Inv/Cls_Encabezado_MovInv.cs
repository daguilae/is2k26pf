using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Mov_Inv
{
    public class Cls_Encabezado_MovInv
    {
        Cls_Conexion_MYSQL conexion = new Cls_Conexion_MYSQL();
        //Cargar DataGridViewEncabezado
        public DataTable fun_ObtenerMovimientos()
        {
            DataTable dtMovimientos = new DataTable();
            string sQuery = @"SELECT 
                        m.pk_movimiento_id       AS ID,
                        t.pk_tipo_movimiento_id  AS ID_Tipo,
                        t.nombre_tipo_inv        AS Tipo_Movimiento,
                        m.fecha_transaccion      AS Fecha,
                        m.descripcion            AS Descripcion
                    FROM tbl_movimiento_inventario_encabezado m
                    INNER JOIN tbl_tipo_movimiento_inventario t 
                        ON m.fk_tipo_movimiento_id = t.pk_tipo_movimiento_id";
            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtMovimientos);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener movimientos: " + ex.Message);
            }
            return dtMovimientos;
        }
    }
}
