using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Asignacion;


namespace Capa_Controlador_Asignacion
{
    public class Cls_Controlador_Asignacion
    {
        Cls_Sentencias_Asignacion sentencias = new Cls_Sentencias_Asignacion();
        public (int iIdEmpleado, string sNombre) fun_ObtenerEmpleado(int iIdUsuario)
        {
            var emp = sentencias.fun_ObtenerEmpleado(iIdUsuario);

            if (emp == null)
                return (0, "");

            return (emp.iIdEmpleado, emp.sNombres + " " + emp.sApellidos);
        }
    }
}
