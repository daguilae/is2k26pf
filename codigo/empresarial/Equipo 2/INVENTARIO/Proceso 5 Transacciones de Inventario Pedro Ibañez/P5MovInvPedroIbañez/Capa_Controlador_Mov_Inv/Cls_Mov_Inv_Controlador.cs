using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Mov_Inv;

namespace Capa_Controlador_Mov_Inv
{
    public class Cls_Mov_Inv_Controlador
    {
        Cls_Dao_Mov_Inv Dao = new Cls_Dao_Mov_Inv();

        public DataTable fun_CargarIdsMovimiento()
        {
            DataTable dtIdMovInv = Dao.fun_ObtenerIDMOV();
            return dtIdMovInv;
        }


        public DataTable fun_CargarIdTypeMov()
        {
            DataTable dtIdTypeMov = Dao.fun_ObtenerTypeMov();
            return dtIdTypeMov;
        }

        public DataTable fun_CargarIdInventario()
        {
            DataTable dtIdInv = Dao.fun_ObtenerInventario();
            return dtIdInv;
        }
    }
}
