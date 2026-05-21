using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Mov_Inv;
using System.Data;

namespace Capa_Controlador_Mov_Inv
{
    public class Cls_Controlador_Inv
    {
        Cls_Dao_Inv Dao = new Cls_Dao_Inv();

        public DataTable fun_CargarInventarios()
        {
            DataTable dtIdInv = Dao.fun_ObtenerInventario();
            return dtIdInv;
        }

        public DataTable fun_CargarMarca()
        {
            DataTable dtIdMarcav = Dao.fun_ObtenerMarca();
            return dtIdMarcav;
        }

        public DataTable fun_CargarLinea()
        {
            DataTable dtIdLinea = Dao.fun_ObtenerLinea();
            return dtIdLinea;
        }

        public DataTable fun_CargarTipoProd()
        {
            DataTable typeprod = new DataTable("TypeProd");

            typeprod.Columns.Add("Tipo", typeof(string));
            typeprod.Columns.Add("TipoVis", typeof(string));
            // Agregar filas
            typeprod.Rows.Add("MP", "Materia Prima");
            typeprod.Rows.Add("PF", "Producto Final");

            return typeprod;
        }

        public DataTable fun_CargarEstado()
        {
            DataTable Estado = new DataTable("Estado");

            Estado.Columns.Add("STATE", typeof(string));
            // Agregar filas
            Estado.Rows.Add("ACTIVO");
            Estado.Rows.Add("INACTIVO");
            return Estado;
        }
    }
}
