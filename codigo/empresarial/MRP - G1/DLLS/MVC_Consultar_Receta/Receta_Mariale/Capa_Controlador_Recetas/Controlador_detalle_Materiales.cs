// Diego Monterroso
using System.Data;
using Capa_Modelo_Recetas;

namespace Capa_Controlador_Recetas
{
    public class Controlador_detalle_Materiales
    {
        Sentencia_detalle_Materiales modelo = new Sentencia_detalle_Materiales();
        // Diego Monterroso
        public DataTable getProductos() => modelo.obtenerProductos();
        // Diego Monterroso
        public DataTable getMateriales() => modelo.obtenerMateriales();
        // Diego Monterroso
        public DataTable getUnidades() => modelo.obtenerUnidades();
        // Diego Monterroso
        public DataTable getDetalles() => modelo.obtenerDetalles();

        // Ruben Lopez 0901-20-4620
        public bool guardarDetalle(int p, int m, int u, decimal c)
            => modelo.insertarDetalle(p, m, u, c);
        // Ruben Lopez 0901-20-4620
        public bool actualizarDetalle(int id, int p, int m, int u, decimal c)
            => modelo.actualizarDetalle(id, p, m, u, c);
        // Ruben Lopez 0901-20-4620
        public bool eliminarDetalle(int id)
            => modelo.eliminarDetalle(id);
    }
}