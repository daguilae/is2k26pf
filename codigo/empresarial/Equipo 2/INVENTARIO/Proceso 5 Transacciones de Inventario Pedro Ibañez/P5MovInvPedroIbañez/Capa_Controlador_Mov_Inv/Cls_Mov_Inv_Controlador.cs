using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Mov_Inv;

namespace Capa_Controlador_Mov_Inv
{
    public class Cls_Mov_Inv_Controlador
    {
        Cls_Dao_Mov_Inv Dao = new Cls_Dao_Mov_Inv();

        public DataTable fun_CargarIdsMovimiento()
        {
            DataTable dtIdMovInv = Dao.fun_ObtenerIDMOV();
            return dtIdMovInv;
        }

        public DataTable fun_CargarIdTypeMov()
        {
            DataTable dtIdTypeMov = Dao.fun_ObtenerTypeMov();
            return dtIdTypeMov;
        }

        public DataTable fun_CargarIdInventario()
        {
            DataTable dtIdInv = Dao.fun_ObtenerInventario();
            return dtIdInv;
        }

        public DataTable fun_UnidadMedida()
        {
            DataTable dtIdUn = Dao.fun_ObtenerUnidadMedida();
            return dtIdUn;
        }

        public DataTable fun_CargarIdBodega()
        {
            DataTable dtIdbod = Dao.fun_ObtenerBodega();
            return dtIdbod;
        }

        public DataTable fun_ObtenerDetallesPorMovimiento(int idMovimiento)
        {
            try
            {

                return Dao.fun_ObtenerDetallesPorMovimiento(idMovimiento);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en controlador al obtener detalles: " + ex.Message);
            }
        }

        private bool fun_Verificar_TipoMov(int idTipoMov)
        {
            //ENTRADA = TRUE
            //SALIDA = FALSE
            string SEfectoTipoMod = Dao.fun_ObtenerTypeMovVerificacion(idTipoMov);

            if (SEfectoTipoMod == "SALIDA")
            {
                return false;
            }else
            {
                return true;
            }
        }

        private float fun_CalcularStock(float stockActual, float cantidad, int idTipoMovimiento)
        {
            // Ajusta los IDs según tu tabla de tipos de movimiento
            bool verificacion_TipoMov = fun_Verificar_TipoMov(idTipoMovimiento);
            if (verificacion_TipoMov) {
                // ENTRADA - aumenta stock
                return stockActual + cantidad;
            }
            else {// SALIDA - disminuye stock
                if (stockActual - cantidad < 0)
                    throw new Exception("Stock insuficiente para realizar la salida.");
                return stockActual - cantidad;
            }
                   throw new Exception($"Tipo de movimiento no reconocido: {idTipoMovimiento}");
            
        }

        private int fun_CalcularEstadoExistencia(float stockNuevo)
        {
            if (stockNuevo > 0) {
                return 1; // Con existencia
            }
            else{
                return 2; // Sin existencia
            }
        }


        public bool fun_Actualizar_Existencias(int idTipoMovimiento,
                                                List<(int idInventario,int idBodega, float cantidad, int idUnidad)> detalle)
        {
            try
            {
                // Construir lista nueva con el stock calculado
                List<(int idInventario, int idBodega, float stockNuevo, int EstadoExis, int idUnidad)> listaStock =
                    new List<(int, int, float, int, int)>();

                foreach (var item in detalle)
                {
                    // Obtener stock actual desde la BD
                    float stockActual = Dao.fun_ObtenerStockActual(item.idInventario, item.idBodega);

                    // Calcular nuevo stock según tipo de movimiento
                    float stockNuevo = fun_CalcularStock(stockActual, item.cantidad, idTipoMovimiento);

                    // Calcular EstadoExis internamente 
                    int EstadoExis = fun_CalcularEstadoExistencia(stockNuevo);

                    listaStock.Add((item.idInventario, item.idBodega, stockNuevo, EstadoExis, item.idUnidad));
                }

                // Enviar lista calculada al DAO para actualizar
                bool resultado = Dao.fun_ActualizarStock(listaStock);
                return resultado;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error en al actualizar existencias " + ex.Message);
            }
        }

        public bool fun_GuardarMovimiento( int idTipoMovimiento, DateTime fechaMovimiento,
                                    string descripcion, List<(int idInventario,int idBodega, float cantidad,int idUnidad)> detalle)
        {
            try
            {
                //Guardar el movimiento
                bool resultadoMovimiento = Dao.fun_InsertarMovimientoCompleto(idTipoMovimiento, fechaMovimiento,
                                                                               descripcion, detalle);
                if (!resultadoMovimiento) return false; //Si falla el movimiento, retornar false

                // Actualizar existencias
                bool resultadoExistencias = fun_Actualizar_Existencias(idTipoMovimiento, detalle);
                if (!resultadoExistencias) return false; // Si falla el stock, retornar false

                return true; //Todo salió bien
            }
            catch (Exception ex)
            {     
                return false;
                throw new Exception("Error al guardar movimiento " + ex.Message);
            }
        }

        public bool fun_ApartarStock(int idTipoMovimiento, DateTime fechaMovimiento,
                            string descripcion, List<(int idInventario, int idBodega, float cantidad, int idUnidad)> detalle)
        {
            try
            {
                //Guardar el movimiento
                bool resultadoMovimiento = Dao.fun_InsertarMovimientoCompleto(idTipoMovimiento, fechaMovimiento,
                                                                               descripcion, detalle);
                if (!resultadoMovimiento) return false; //Si falla el movimiento, retornar false

                // Actualizar existencias
                bool resultadoExistencias = fun_CreacionApartadoExistencias(idTipoMovimiento, detalle);
                if (!resultadoExistencias) return false; // Si falla el stock, retornar false

                return true; //Todo salió bien
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en fun_ApartarStock");
                return false;
                throw new Exception("Error al guardar movimiento " + ex.Message);
            }
        }

        public bool fun_CreacionApartadoExistencias(int idTipoMovimiento,
                                                List<(int idInventario, int idBodega, float cantidad, int idUnidad)> detalle)
        {
            try
            {
                // Construir lista nueva con el stock calculado
                List<(int idInventario, int idBodega, float stockNuevo,
                                      float CantidadApartada, int EstadoExistencia, int idUnidad) > listaStock =
                    new List<(int, int, float ,float, int, int)>();

                foreach (var item in detalle)
                {
                    // Obtener stock actual desde la BD
                    float stockActual = Dao.fun_ObtenerStockActual(item.idInventario, item.idBodega);

                    // Calcular nuevo stock según tipo de movimiento
                    float stockNuevo = fun_CalcularApartado(stockActual, item.cantidad, idTipoMovimiento);

                    // Calcular EstadoExis internamente 
                    int EstadoExis = fun_CalcularEstadoExistencia(stockNuevo);

                    listaStock.Add((item.idInventario, item.idBodega, stockNuevo,item.cantidad, EstadoExis, item.idUnidad));
                }

                // Enviar lista calculada al DAO para actualizar
                bool resultado = Dao.fun_ApartarStockDao(listaStock);
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al apartar stock Controlador");
                return false;
               
                throw new Exception("Error en al actualizar existencias " + ex.Message);
            }

        }
        private float fun_CalcularApartado(float stockActual, float cantidad, int idTipoMovimiento)
        {
            // Ajusta los IDs según tu tabla de tipos de movimiento
            try
            {
                // Resta stock por la cantidad
                return stockActual - cantidad;

            }
            catch
            {
                Console.WriteLine("Error al calcular apartado de stock");
                throw new Exception($"Error al calcular apartado {idTipoMovimiento}");
            }
        }
    }
}
