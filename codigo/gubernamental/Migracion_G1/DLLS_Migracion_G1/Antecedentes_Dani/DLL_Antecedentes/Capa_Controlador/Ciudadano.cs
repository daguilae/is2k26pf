using System.Collections.Generic;
using Capa_Modelo_Antecedentes;

namespace Capa_Controlador
{
    public class CiudadanoControlador
    {
        CiudadanoDAO dao = new CiudadanoDAO();

        public List<Ciudadano> ObtenerCiudadanos()
        {
            return dao.ObtenerCiudadanos();
        }
    }
}