using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Capa_Modelo_Ventas;

namespace Capa_Controlador_Ventas
{
    public class Cls_Asignacion_Clientes_Controlador
    {
        private Cls_Asignacion_ClientesDAO dao = new Cls_Asignacion_ClientesDAO();

        //VALIDACIÓN
        public (bool success, string message) ValidarAsignacion(int idVendedor, int idCliente)
        {
            if (idVendedor <= 0)
                return (false, "Debe seleccionar un vendedor válido.");

            if (idCliente <= 0)
                return (false, "Debe seleccionar un cliente válido.");

            return (true, "Validación exitosa");
        }

        //GUARDAR
        public (bool success, string message) GuardarAsignacion(int idVendedor, int idCliente)
        {
            var validacion = ValidarAsignacion(idVendedor, idCliente);
            if (!validacion.success)
                return (false, validacion.message);

            if (dao.ExisteAsignacion(idVendedor, idCliente))
                return (false, "La asignación ya existe.");

            bool resultado = dao.InsertarAsignacion(idVendedor, idCliente) > 0;

            return (resultado,
                resultado ? "Asignación guardada correctamente."
                          : "Error al guardar la asignación.");
        }
        // ELIMINAR
        public (bool success, string message) EliminarAsignacion(int idVendedor, int idCliente)
        {
            int filas = dao.EliminarAsignacion(idVendedor, idCliente);

            if (filas > 0)
                return (true, "Asignación eliminada correctamente.");
            else
                return (false, "No se pudo eliminar la asignación.");
        }

        //COMBOBOX VENDEDORES
        public DataTable ObtenerVendedores()
        {
            return dao.ObtenerVendedores();
        }

        //COMBOBOX CLIENTES
        public DataTable ObtenerClientes()
        {
            return dao.ObtenerClientes();
        }

        // GRID (CON NOMBRES)
        public DataTable ObtenerAsignacionesConNombres()
        {
            return dao.ObtenerAsignacionesConNombres();
        }
        // LISTA DE CLIENTES DE UN VENDEDOR
        public DataTable ObtenerClientesPorVendedor(int idVendedor)
        {
            DataTable dt = dao.ObtenerAsignacionesConNombres();
            DataView dv = dt.DefaultView;

            dv.RowFilter = $"Pk_Id_Vendedor = {idVendedor}";

            return dv.ToTable();
        }
    }
}