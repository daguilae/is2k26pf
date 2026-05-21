//controlador

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo__DispoInve;
using System.Data;

namespace Capa_Controlador_DispoInve
{
    public class CRL_Inventario
    {
        private readonly DAL_Inventario _dal = new DAL_Inventario();

        public List<Inventario> ConsultarDisponibilidad(
            int tipoInventario,
            int idAlmacen,
            string busqueda)
        {
            if (busqueda == null) busqueda = string.Empty;

            try
            {
                return _dal.ObtenerInventario(tipoInventario, idAlmacen, busqueda.Trim());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar inventario: " + ex.Message);
            }
        }

        public DataTable ObtenerAlmacenes()
        {
            try
            {
                return _dal.ObtenerAlmacenes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar almacenes: " + ex.Message);
            }
        }
    }
}