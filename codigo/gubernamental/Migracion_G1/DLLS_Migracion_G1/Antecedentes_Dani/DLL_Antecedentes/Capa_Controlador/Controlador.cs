using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Antecedentes;
using System.Data.Odbc;
using System.Data;

namespace Capa_Controlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public void ingresoAntecedentes(string fecha, string tipo, string estado, string desc, string idCiudadano)
        {
            int idCiu = int.Parse(idCiudadano);

            int estadoInt = (estado == "Activo") ? 1 : 0;

            sn.insertarAntecedente(fecha, tipo, estadoInt, desc, idCiu);
        }

        public void borrarPorCiudadano(string idCiudadano)
        {
            try
            {
                int idCiu = int.Parse(idCiudadano);
                sn.eliminarAntecedentePorCiudadano(idCiu);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Controlador: " + ex.Message);
            }
        }

        public DataTable llenarComboCiudadanos()
        {
            return sn.obtenerCiudadanos();
        }

        public OdbcDataReader obtenerAntecedente(string idCiudadano)
        {
            int idCiu = int.Parse(idCiudadano);
            return sn.buscarAntecedente(idCiu);
        }

        public DataTable obtenerCiudadanos()
        {
            return sn.obtenerCiudadanos();
        }

        public void actualizarAntecedente(string fecha, string tipo, string estado, string desc, string idCiudadano)
        {
            int estadoInt = (estado == "Activo") ? 1 : 0;
            int idCiu = int.Parse(idCiudadano);
            sn.modificarAntecedente(fecha, tipo, estadoInt, desc, idCiu);
        }

    }
}