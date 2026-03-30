using Capa_Modelo_Citas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador_Citas
{
    public class Cls_Controlador_Citas
    {
        private Cls_Sentencias modelo = new Cls_Sentencias();

        public bool AgendarCita(
           DateTime fecha,
           int idTipo,
           int idHorario,
           int idSede,
           int idBoleta,
           out string mensaje)
        {
            mensaje = "";

            if (idTipo <= 0)
            {
                mensaje = "Seleccione un tipo de cita";
                return false;
            }

            if (idHorario <= 0)
            {
                mensaje = "Seleccione un horario";
                return false;
            }

            if (idSede <= 0)
            {
                mensaje = "Seleccione una sede";
                return false;
            }

            if (idBoleta <= 0)
            {
                mensaje = "Boleta inválida";
                return false;
            }

            
            Cls_Modelo_Citas cita = new Cls_Modelo_Citas
            {
                FechaCita = fecha,
                IdTipoCita = idTipo,
                IdHorario = idHorario,
                IdSede = idSede,
                IdBoleta = idBoleta,
                IdEstadoCita = 1
            };

            return modelo.Insertar(cita);
        }

        public DataTable ObtenerTiposCita()
        {
            return modelo.ObtenerTiposCita();
        }
        public DataTable ObtenerHorarios()
        {
            return modelo.ObtenerHorarios();
        }

        public DataTable ObtenerSedes()
        {
            return modelo.ObtenerSedes();
        }

        public bool AgendarCita(
            int idTipoCita,
            DateTime fecha,
            int idHorario,
            int idSede,
            int idBoleta
        )
        {
            int idEstadoAsignado = modelo.ObtenerIdEstadoAsignado();

            if (idEstadoAsignado == 0)
                return false;

            return modelo.InsertarCita(
                idTipoCita,
                fecha,
                idHorario,
                idSede,
                idEstadoAsignado,
                idBoleta
            );
        }
    }
}
