using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Banrural; //Referencia Capa Modelo Paula Daniela Leonardo Paredes 0901-22-9580

namespace Capa_Controlador_Banrural
{
    public class Cls_Controlador
    {
        private readonly Cls_Sentencias sen = new Cls_Sentencias();

        public DataTable BuscarCiudadanoPorDpi(long dpi)
        {
            return sen.BuscarCiudadanoPorDpi(dpi);
        }

        public DataTable ObtenerTiposPasaporte()
        {
            return sen.ObtenerTiposPasaporte();
        }

        public DataTable ObtenerDuracionesPorTipo(string tipo)
        {
            return sen.ObtenerDuracionesPorTipo(tipo);
        }

        public decimal ObtenerPrecio(string tipo, int duracion)
        {
            return sen.ObtenerPrecio(tipo, duracion);
        }

        public int GuardarBoleta(int numeroBoleta, int idCiudadano, int idTipo)
        {
            return sen.InsertarBoleta(numeroBoleta, idCiudadano, idTipo);
        }

        public bool ExisteNumeroBoleta(int numeroBoleta)
        {
            return sen.ExisteNumeroBoleta(numeroBoleta);
        }
    }
}
