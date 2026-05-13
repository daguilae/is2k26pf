using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Capa_Modelo_OrdenProduccion;
using System.Data;

//Kenph Luna 29/04/2026
namespace Capa_Controlador_OrdenProduccion
{
    public class Cls_ControladorOrdenP
    {
        private Cls_ProduccionDAO oProduccionDAO = new Cls_ProduccionDAO();

        //Metodo para Insertar
        public int InsertarOrdenProduccion(string sIdVendedor, DateTime dFechaEmision, DateTime dFechaEstimada, string sEstado, List<(string sIdProducto, string sCantSolicitada, string sCantRecibida)> lDetallesCrudos)
        {
            //Validaciones de Encabezado
            if (string.IsNullOrWhiteSpace(sIdVendedor) || !int.TryParse(sIdVendedor, out int iIdVendedor) || iIdVendedor <= 0)
            {
                throw new ArgumentException("El Vendedor seleccionado no es válido.");
            }

            if (dFechaEstimada.Date < dFechaEmision.Date)
            {
                throw new ArgumentException("La Fecha Estimada de Entrega no puede ser menor a la Fecha de Emisión.");
            }

            // Validación del ENUM
            var estadosValidos = new List<string> { "Emitida", "En Proceso", "Finalizada", "Recibida", "Cancelada" };
            if (!estadosValidos.Contains(sEstado))
            {
                throw new ArgumentException("El Estado seleccionado no es válido en el sistema.");
            }

            // Validaciones de Detalle
            if (lDetallesCrudos == null || lDetallesCrudos.Count == 0)
            {
                throw new ArgumentException("Debe ingresar al menos un producto en el detalle de la orden.");
            }

            List<(int iIdProducto, int iCantidadSolicitada, int iCantidadRecibida)> lDetallesValidados = new List<(int, int, int)>();

            foreach (var det in lDetallesCrudos)
            {
                //Validar nulos
                if (string.IsNullOrWhiteSpace(det.sIdProducto) || string.IsNullOrWhiteSpace(det.sCantSolicitada) || string.IsNullOrWhiteSpace(det.sCantRecibida))
                    throw new ArgumentException("Existen campos vacíos en el detalle de productos.");

                if (!int.TryParse(det.sIdProducto, out int iIdProd) || iIdProd <= 0)
                    throw new ArgumentException($"El producto con ID '{det.sIdProducto}' no es válido.");

                //Validar Cantidad Solicitada
                if (!System.Text.RegularExpressions.Regex.IsMatch(det.sCantSolicitada, @"^\d+$"))
                    throw new ArgumentException("La cantidad solicitada debe contener únicamente números enteros positivos.");
                if (!int.TryParse(det.sCantSolicitada, out int iCantSol) || iCantSol <= 0)
                    throw new ArgumentException("La cantidad solicitada debe ser mayor a cero.");

                //Validar Cantidad Recibida
                if (!System.Text.RegularExpressions.Regex.IsMatch(det.sCantRecibida, @"^\d+$"))
                    throw new ArgumentException("La cantidad recibida debe contener únicamente números enteros.");
                if (!int.TryParse(det.sCantRecibida, out int iCantRec) || iCantRec < 0)
                    throw new ArgumentException("La cantidad recibida no puede ser menor a cero.");

                if (iCantRec > iCantSol)
                    throw new ArgumentException($"Para el producto ID {iIdProd}, la cantidad recibida ({iCantRec}) no puede ser mayor a la solicitada ({iCantSol}).");

                lDetallesValidados.Add((iIdProd, iCantSol, iCantRec));
            }

            // se inserta en DAO
            try
            {
                return oProduccionDAO.InsertarOrdenProduccion(Convert.ToInt32(sIdVendedor), dFechaEmision, dFechaEstimada, sEstado, lDetallesValidados);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message);
            }
        }

        // Método para Modificar
        public void ModificarOrdenProduccion(int idOrden, string sIdVendedor, DateTime dFechaEmision, DateTime dFechaEstimada, string sEstado, List<(string sIdProducto, string sCantSolicitada, string sCantRecibida)> lDetallesCrudos)
        {
            if (idOrden <= 0) throw new ArgumentException("ID de orden inválido.");

            // Validaciones encabezado
            if (string.IsNullOrWhiteSpace(sIdVendedor) || !int.TryParse(sIdVendedor, out int iIdVendedor) || iIdVendedor <= 0)
            {
                throw new ArgumentException("El Vendedor seleccionado no es válido.");
            }

            if (dFechaEstimada.Date < dFechaEmision.Date)
            {
                throw new ArgumentException("La Fecha Estimada de Entrega no puede ser menor a la Fecha de Emisión.");
            }

            // Validación del ENUM
            var estadosValidos = new List<string> { "Emitida", "En Proceso", "Finalizada", "Recibida", "Cancelada" };
            if (!estadosValidos.Contains(sEstado))
            {
                throw new ArgumentException("El Estado seleccionado no es válido en el sistema.");
            }

            // Detalles validaciones
            if (lDetallesCrudos == null || lDetallesCrudos.Count == 0)
            {
                throw new ArgumentException("Debe ingresar al menos un producto en el detalle de la orden.");
            }

            List<(int iIdProducto, int iCantidadSolicitada, int iCantidadRecibida)> lDetallesValidados = new List<(int, int, int)>();

            foreach (var det in lDetallesCrudos)
            {
                //Validar valores nulos
                if (string.IsNullOrWhiteSpace(det.sIdProducto) || string.IsNullOrWhiteSpace(det.sCantSolicitada) || string.IsNullOrWhiteSpace(det.sCantRecibida))
                    throw new ArgumentException("Existen campos vacíos en el detalle de productos.");

                //Validar que el ID del producto sea un número válido
                if (!int.TryParse(det.sIdProducto, out int iIdProd) || iIdProd <= 0)
                    throw new ArgumentException($"El producto con ID '{det.sIdProducto}' no es válido.");

                //Validar Cantidad Solicitada
                if (!System.Text.RegularExpressions.Regex.IsMatch(det.sCantSolicitada, @"^\d+$"))
                    throw new ArgumentException("La cantidad solicitada debe contener únicamente números enteros positivos.");

                if (!int.TryParse(det.sCantSolicitada, out int iCantSol) || iCantSol <= 0)
                    throw new ArgumentException("La cantidad solicitada debe ser mayor a cero.");

                //Validar Cantidad Recibida
                if (!System.Text.RegularExpressions.Regex.IsMatch(det.sCantRecibida, @"^\d+$"))
                    throw new ArgumentException("La cantidad recibida debe contener únicamente números enteros.");

                if (!int.TryParse(det.sCantRecibida, out int iCantRec) || iCantRec < 0)
                    throw new ArgumentException("La cantidad recibida no puede ser menor a cero.");

                if (iCantRec > iCantSol)
                    throw new ArgumentException($"Para el producto ID {iIdProd}, la cantidad recibida ({iCantRec}) no puede ser mayor a la solicitada ({iCantSol}).");

                lDetallesValidados.Add((iIdProd, iCantSol, iCantRec));
            }

            try
            {
                oProduccionDAO.ActualizarOrdenProduccion(idOrden, iIdVendedor, dFechaEmision, dFechaEstimada, sEstado, lDetallesValidados);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en BD: " + ex.Message);
            }
        }

        // Método para Eliminar
        public void EliminarOrden(string sIdOrden)
        {
            if (!int.TryParse(sIdOrden, out int idOrden) || idOrden <= 0)
            {
                throw new ArgumentException("Seleccione una orden válida para eliminar.");
            }

            try
            {
                oProduccionDAO.EliminarOrdenProduccion(idOrden);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en BD: " + ex.Message);
            }
        }




        //Obtener Datos
        public DataTable ObtenerVendedores()
        {
            return oProduccionDAO.ObtenerDatos(Cls_SentenciasSQL.sObtenerVendedores);
        }

        public DataTable ObtenerProductos()
        {
            return oProduccionDAO.ObtenerDatos(Cls_SentenciasSQL.sObtenerProductos);
        }

        public DataTable ObtenerEncabezados()
        {
            return oProduccionDAO.ObtenerDatos(Cls_SentenciasSQL.sObtenerEncabezados);
        }

        public DataTable ObtenerDetallesPorId(int idOrden)
        {
            return oProduccionDAO.ObtenerDetalles(idOrden);
        }
    }
}
