using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Expl_Mat;

namespace Capa_Controlador_Expl_Mat
{
    public class Cls_Controlador_Expl
    {
        // Paula Daniela Leonardo Paredes - [tu carné] - [fecha]
        private readonly Cls_Sentencias_Expl_e_Impl sentencias
                       = new Cls_Sentencias_Expl_e_Impl();

        public DataTable ObtenerExplosiones()
        {
            return sentencias.ObtenerExplosiones();
        }

        public DataTable FiltrarPorId(string idExplosion)
        {
            return sentencias.FiltrarPorId(idExplosion);
        }

        public DataTable FiltrarPorFechas(string fechaInicio, string fechaFin)
        {
            return sentencias.FiltrarPorFechas(fechaInicio, fechaFin);
        }
    }
}