using System;
using System.Data;
using Capa_Modelo_Pasaporte;
using Capa_Controlador_Seguridad;

namespace Capa_Controlador_Pasaporte
{
    public class Controlador_Pasaporte
    {
        Sentencias_Pasaporte modelo = new Sentencias_Pasaporte();
        //Aron Esquit 4/3/26
        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();

        // =====================================================
        // CONSULTAR BOLETA
        // =====================================================
        public DataTable ConsultarBoleta(int numeroBoleta)
        {
            if (numeroBoleta <= 0)
                throw new Exception("Número de boleta inválido.");

            return modelo.ObtenerDatosPorBoleta(numeroBoleta);
        }

        // =====================================================
        // OBTENER NÚMERO DE LIBRETA
        // =====================================================
        public int ObtenerNumeroLibreta()
        {
            return modelo.ObtenerSiguienteNumeroPasaporte();
        }

        // =====================================================
        // GENERAR NÚMERO DE PASAPORTE
        // Prefijo:
        // 11 = Adulto
        // 12 = Menor
        // + últimos 4 del DPI
        // =====================================================
        public int GenerarNumeroPasaporte(string dpi, DateTime fechaNacimiento)
        {
            if (string.IsNullOrWhiteSpace(dpi) || dpi.Length < 4)
                throw new Exception("DPI inválido para generar pasaporte.");

            int edad = CalcularEdad(fechaNacimiento);

            string prefijo = edad >= 18 ? "11" : "12";
            string ultimos4 = dpi.Substring(dpi.Length - 4);

            string numero = prefijo + ultimos4;

            return Convert.ToInt32(numero);
        }

        // =====================================================
        // EMITIR PASAPORTE
        // =====================================================
        public void EmitirPasaporte(
    int numeroPasaporte,
    DateTime fechaEmision,
    DateTime fechaExpiracion,
    int idCita,
    int idPais,
    bool huellas,
    bool firma,
    byte[] fotografia,
    int estatura,
    bool menor,
    bool certificadoNacimiento,
    bool ambosPadres,
    bool dpiAmbosPadres,
    bool cartaNotariada,
    bool autorizacionJudicial,
    bool dpiPadreRep)
        {
            if (modelo.ExisteNumeroPasaporte(numeroPasaporte))
            {
                throw new Exception("El número de pasaporte ya existe.");
            }

            modelo.InsertarPasaporteCompleto(
                numeroPasaporte,
                fechaEmision,
                fechaExpiracion,
                idCita,
                idPais,
                huellas,
                firma,
                fotografia,
                estatura,
                menor,
                certificadoNacimiento,
                ambosPadres,
                dpiAmbosPadres,
                cartaNotariada,
                autorizacionJudicial,
                dpiPadreRep);
       

            gCtrlBitacora.RegistrarAccion(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario, 1, $"Se emitio el pasaporte '{numeroPasaporte}'", true);

        }

        // =====================================================
        // OBTENER LISTA DE PAISES
        // =====================================================
        public DataTable ObtenerPaises()
        {
            return modelo.ObtenerPaises();
        }

        // =====================================================
        // FECHA EMISIÓN
        // =====================================================
        public DateTime ObtenerFechaEmision()
        {
            return DateTime.Now.Date;
        }

        // =====================================================
        // CALCULAR FECHA EXPIRACIÓN
        // =====================================================
        public DateTime CalcularFechaExpiracion(DateTime fechaEmision, int duracion)
        {
            if (duracion <= 0)
                throw new Exception("Duración inválida.");

            return fechaEmision.AddYears(duracion);
        }

        // =====================================================
        // VALIDAR SI ES MENOR DE EDAD
        // =====================================================
        public bool EsMenorDeEdad(DateTime fechaNacimiento)
        {
            return CalcularEdad(fechaNacimiento) < 18;
        }

        // =====================================================
        // MÉTODO PRIVADO PARA CALCULAR EDAD CORRECTAMENTE
        // =====================================================
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            if (DateTime.Now < fechaNacimiento.AddYears(edad))
                edad--;

            return edad;
        }


    }
}