using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Recetas;

namespace Capa_Controlador_Recetas
{
    public class Controlador_Fases
    {
        Sentencia_detalle_Materiales sentencias = new Sentencia_detalle_Materiales();
        public DataTable fun_DatosFase(int iCodigoBOM)
        {
            return sentencias.fun_ObtenerFasesProducción(iCodigoBOM);
        }
    }
}
