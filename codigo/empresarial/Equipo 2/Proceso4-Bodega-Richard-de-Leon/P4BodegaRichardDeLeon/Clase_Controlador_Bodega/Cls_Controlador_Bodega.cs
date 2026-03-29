using System;
using System.Data;
using Capa_Modelo;

namespace Capa_Controlador
{
    public class Cls_Controlador_Bodega
    {
        private Cls_Sentencias_Bodega cls_Bodega = new Cls_Sentencias_Bodega();

        // INSERTAR
        public bool fun_InsertarBodega(string sNombre, string sDireccion, string sEstado)
        {
            try
            {
                return cls_Bodega.fun_InsertarBodega(sNombre, sDireccion, sEstado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador InsertarBodega: " + ex.Message);
                return false;
            }
        }

        // CONSULTAR TODOS
        public DataTable fun_ConsultarBodega()
        {
            try
            {
                return cls_Bodega.fun_ConsultarBodega();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador ConsultarBodega: " + ex.Message);
                return new DataTable();
            }
        }

        // BUSCAR POR ID
        public DataTable fun_BuscarBodega(int iId)
        {
            try
            {
                return cls_Bodega.fun_BuscarBodega(iId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador BuscarBodega: " + ex.Message);
                return new DataTable();
            }
        }

        // MODIFICAR
        public bool fun_ModificarBodega(int iId, string sNombre, string sDireccion, string sEstado)
        {
            try
            {
                return cls_Bodega.fun_ModificarBodega(iId, sNombre, sDireccion, sEstado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador ModificarBodega: " + ex.Message);
                return false;
            }
        }

        // ELIMINAR
        public bool fun_EliminarBodega(int iId)
        {
            try
            {
                return cls_Bodega.fun_EliminarBodega(iId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en controlador EliminarBodega: " + ex.Message);
                return false;
            }
        }
    }
}