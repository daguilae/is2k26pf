using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Mov_Inv;

namespace Capa_Controlador_Mov_Inv
{
    public class Cls_Controlador_Encabezado
    {
        Cls_Encabezado_MovInv dao = new Cls_Encabezado_MovInv();

        public DataTable fun_CargarMovimientos()
        {
            try
            {
                DataTable dtMovimientos = dao.fun_ObtenerMovimientos();
                return dtMovimientos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en controlador al cargar movimientos: " + ex.Message);
            }
        }
    }
}
