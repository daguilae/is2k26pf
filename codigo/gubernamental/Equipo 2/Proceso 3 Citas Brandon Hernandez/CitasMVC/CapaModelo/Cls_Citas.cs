using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Citas
{
    public class Cls_Citas
    {
        public int iPk_Id_Cita { get; set; }
        public int iFk_Id_Sede { get; set; }
        public DateTime dCmp_Fecha_Hora { get; set; }
        public string sCmp_Estado_Cita { get; set; }

        public Cls_Citas() { }

        public Cls_Citas(int iPkIdCita, int iFkIdSede, DateTime dCmpFechaHora, string sCmpEstadoCita)
        {
            this.iPk_Id_Cita = iPkIdCita;
            this.iFk_Id_Sede = iFkIdSede;
            this.dCmp_Fecha_Hora = dCmpFechaHora;
            this.sCmp_Estado_Cita = sCmpEstadoCita;
        }
    }
}
