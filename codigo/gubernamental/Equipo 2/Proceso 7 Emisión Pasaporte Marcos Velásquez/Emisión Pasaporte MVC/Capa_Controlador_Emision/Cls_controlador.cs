using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_emision_pasaporte;


namespace Capa_Controlador_Emision
{
    public class Cls_controlador
    {


        Cls_Inserción modelo = new Cls_Inserción();


        public void Guardar(
    string dpi,
    string nombre,
    string apellido,
    string sexo,
    DateTime fechaNacimiento,
    string numeroPasaporte,
    DateTime fechaEmision,
    DateTime fechaVencimiento,
    byte[] fotografia, // Parámetro agregado
    byte[] firma       // Parámetro agregado
)
        {
            // Validación de campos obligatorios
            if (string.IsNullOrEmpty(dpi) || string.IsNullOrEmpty(nombre))
                throw new Exception("Campos obligatorios vacíos");

            // Enviar todos los datos, incluyendo la biometría, al método actualizado del modelo
            modelo.InsertarTodo(
                dpi,
                nombre,
                apellido,
                sexo,
                fechaNacimiento,
                numeroPasaporte,
                fechaEmision,
                fechaVencimiento,
                fotografia, // Pasar fotografía
                firma       // Pasar firma
            );
        }














        public DataTable ObtenerDatosSolicitante(string dpi)
        {
            if (string.IsNullOrEmpty(dpi))
                throw new Exception("El DPI es necesario para la búsqueda.");

            return modelo.BuscarPorDPI(dpi);
        }








    }

}

