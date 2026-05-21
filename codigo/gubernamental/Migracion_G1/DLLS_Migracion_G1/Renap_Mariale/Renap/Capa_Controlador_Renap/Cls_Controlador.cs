using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Renap;
using System.Data;
using System.Data.Odbc;


// EMPIEZA CODIGO HECHO POR: MARIA MORALES 0901-22-1226 EN LA FECHA DE: 04/03/2026
namespace Capa_Controlador_Renap
{
    public class Cls_Controlador
    {
        Cls_Sentencias modelo = new Cls_Sentencias();


        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = modelo.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }



        public bool Guardar(long dpi, string nombres, string apellidos,
                            int sexo, string nacionalidad,
                            string lugarNacimiento, DateTime fechaNacimiento)
        {
            return modelo.GuardarCiudadano(
                dpi,
                nombres,
                apellidos,
                sexo,
                nacionalidad,
                lugarNacimiento,
                fechaNacimiento
            );
        }


        public bool Eliminar(int idCiudadano)
        {
            return modelo.EliminarCiudadano(idCiudadano);
        }


        public bool Modificar(int idCiudadano, long dpi, string nombres, string apellidos,
                      int sexo, string nacionalidad,
                      string lugarNacimiento, DateTime fechaNacimiento)
        {
            return modelo.ModificarCiudadano(
                idCiudadano,
                dpi,
                nombres,
                apellidos,
                sexo,
                nacionalidad,
                lugarNacimiento,
                fechaNacimiento
            );
        }



        public DataTable Mostrar()
        {
            return modelo.MostrarCiudadanos();
        }

    }
}
// FINALIZA CODIGO HECHO POR: MARIA MORALES 0901-22-1226 EN LA FECHA DE: 04/03/2026