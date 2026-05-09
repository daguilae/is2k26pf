// Arón Ricardo Esquit Silva 0901-22-13036 07/05/2026
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Orden_Material;

namespace Capa_Controlador_Orden_Material
{
    public class Cls_Controlador_Encabezado_Orden_Material
    {
        private Cls_Dao_Encabezado_Orden_Material dao = new Cls_Dao_Encabezado_Orden_Material();

        public DataTable Fun_Mostrar_Encabezado_Orden_Material()
        {
            return dao.Fun_Mostrar_Encabezado_Orden_Material();
        }

        public DataTable Fun_Buscar_Encabezado_Orden_Material(int iIdOrdenMaterial)
        {
            return dao.Fun_Buscar_Encabezado_Orden_Material(iIdOrdenMaterial);
        }

        public DataTable Fun_Filtrar_Por_Orden_Produccion(int iIdOrdenProduccion)
        {
            return dao.Fun_Filtrar_Por_Orden_Produccion(iIdOrdenProduccion);
        }

        public DataTable Fun_Filtrar_Por_Estado(int iIdEstado)
        {
            return dao.Fun_Filtrar_Por_Estado(iIdEstado);
        }

        public DataTable Fun_Obtener_Estados_Orden_Material()
        {
            return dao.Fun_Obtener_Estados_Orden_Material();
        }

        public DataTable Fun_Obtener_Ordenes_Produccion()
        {
            return dao.Fun_Obtener_Ordenes_Produccion();
        }

        public bool Fun_Enviar_Logistica(int iIdOrdenMaterial)
        {
            return dao.Fun_Enviar_Logistica(iIdOrdenMaterial);
        }

        public DataTable Fun_Obtener_Id_Ordenes_Material()
        {
            return dao.Fun_Obtener_Id_Ordenes_Material();
        }

        public DataTable Fun_Filtrar_Por_Fechas(string sFechaInicio, string sFechaFin)
        {
            return dao.Fun_Filtrar_Por_Fechas(sFechaInicio, sFechaFin);
        }

    }
}