using System;
using System.Data;
using Capa_Modelo_Pasaporte;

namespace Capa_Controlador_Pasaporte
{
    public class Controlador_Ver_Pasaporte
    {
        Sentencias_Ver_Pasaporte modelo = new Sentencias_Ver_Pasaporte();

        // =====================================================
        // VER PASAPORTE
        // =====================================================
        public DataTable VerPasaporte(int numeroPasaporte)
        {
            if (numeroPasaporte <= 0)
                throw new Exception("Número de pasaporte inválido.");

            return modelo.ObtenerPasaportePorNumero(numeroPasaporte);
        }
    }
}