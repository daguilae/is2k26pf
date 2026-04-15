using System.Data;
using Capa_Modelo_Banrural; // Referencia Capa Modelo

namespace Capa_Controlador_Banrural
{
    public class Cls_Controlador //Paula Leonardo 0901-22-9580
    {
        // Instancia de la capa modelo
        private readonly Cls_Sentencias sen = new Cls_Sentencias();

        // 1. BUSCAR CIUDADANO POR DPI
        public DataTable BuscarCiudadanoPorDpi(long dpi)
        {
            return sen.BuscarCiudadanoPorDpi(dpi);
        }

        // 2. OBTENER TIPOS DE PASAPORTE
        public DataTable ObtenerTiposPasaporte()
        {
            return sen.ObtenerTiposPasaporte();
        }

        // 3. OBTENER DURACIONES POR TIPO
        public DataTable ObtenerDuracionesPorTipo(string tipo)
        {
            return sen.ObtenerDuracionesPorTipo(tipo);
        }

        // 4. OBTENER PRECIO
        public decimal ObtenerPrecio(string tipo, int duracion)
        {
            return sen.ObtenerPrecio(tipo, duracion);
        }

        // 5. GUARDAR BOLETA
        public int GuardarBoleta(int numeroBoleta, int idCiudadano, int idTipo)
        {
            return sen.InsertarBoleta(numeroBoleta, idCiudadano, idTipo);
        }

        // 6. VALIDAR SI EXISTE NÚMERO DE BOLETA
        public bool ExisteNumeroBoleta(int numeroBoleta)
        {
            return sen.ExisteNumeroBoleta(numeroBoleta);
        }

        // 7. OBTENER ID TIPO PASAPORTE
        public int ObtenerIdTipoPasaporte(string tipo, int duracion)
        {
            return sen.ObtenerIdTipoPasaporte(tipo, duracion);
        }

        // 8. OBTENER BOLETAS POR CIUDADANO
        public DataTable ObtenerBoletasPorCiudadano(int idCiudadano)
        {
            return sen.ObtenerBoletasPorCiudadano(idCiudadano);
        }

        // 8B.
        public DataTable ObtenerTodasLasBoletasConCiudadano()
        {
            return sen.ObtenerTodasLasBoletasConCiudadano();
        }

        // 8C.
        public DataTable ObtenerBoletasPorDpi(long dpi)
        {
            return sen.ObtenerBoletasPorDpi(dpi);
        }

        // 9. ELIMINAR BOLETA
        public int EliminarBoleta(int idBoleta)
        {
            return sen.EliminarBoleta(idBoleta);
        }

        // 10. ACTUALIZAR BOLETA
        public int ActualizarBoleta(int idBoleta, int idTipo)
        {
            return sen.ActualizarBoleta(idBoleta, idTipo);
        }

        // 11. OBTENER DETALLE DE BOLETA PARA EDITAR
        public DataTable ObtenerBoletaPorId(int idBoleta)
        {
            return sen.ObtenerBoletaPorId(idBoleta);
        }
    }
}
