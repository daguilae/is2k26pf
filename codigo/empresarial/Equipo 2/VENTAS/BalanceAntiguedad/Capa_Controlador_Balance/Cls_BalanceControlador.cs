using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Balance;

namespace Capa_Controlador_Balance
{
    public class Cls_BalanceControlador
    {
        private readonly Cls_BalanceDAO dao = new Cls_BalanceDAO();
        public DataTable ObtenerAntiguedadSaldos(DateTime inicio, DateTime fin)
        {
            return dao.ObtenerAntiguedadSaldos(inicio, fin);
        }
    }
}
