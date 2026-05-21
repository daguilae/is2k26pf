using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Mov_Inv
{
    public class Cls_Dao_Inv
    {
        Cls_Conexion_MYSQL conexion = new Cls_Conexion_MYSQL();

        //Inventarios
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
                Console.WriteLine("Error al obtener los inventarios: " + ex.Message);
            }

            return dtResultado;
        }

        //Obtener linea
        public DataTable fun_ObtenerLinea()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    pk_id_linea,
                    CONCAT(pk_id_linea, ' - ', cmp_nombre_linea) AS LINEA
                    FROM tbl_linea_producto; ";

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
                Console.WriteLine("Error al obtener la linea: " + ex.Message);
            }

            return dtResultado;
        }

        //Obtener linea
        public DataTable fun_ObtenerMarca()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    ID_Marca,
                    CONCAT(ID_Marca, ' - ', Nombre_Marca) AS MARCA
                    FROM tbl_marca; ";

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
                Console.WriteLine("Error al obtener la marca: " + ex.Message);
            }

            return dtResultado;
        }


    }
}
