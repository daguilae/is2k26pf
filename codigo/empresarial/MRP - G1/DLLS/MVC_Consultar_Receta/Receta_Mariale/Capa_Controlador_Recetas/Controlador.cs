using System;
using System.Collections.Generic;
using System.Data;
using Capa_Modelo_Recetas;
using Capa_Controlador_Seguridad;

namespace Capa_Controlador_Recetas
{

    public class Controlador
    {
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26

        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();
        private int idAplicacion = 736; 

        Sentencias sen = new Sentencias();

        public DataTable cargarProductos()
        {
            return sen.obtenerProductosTerminados();
        }

        public DataTable cargarBOM(int idProducto)
        {
            return sen.obtenerBOM(idProducto);
        }

        public DataTable cargarBOMGrid(int idProducto)
        {
            return sen.obtenerBOMGrid(idProducto);
        }

        public DataTable cargarEstados()
        {
            return sen.obtenerEstados();
        }

        // guardar cesar santizo 0901-22-5215
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void guardarBOM(string descripcion, string version, DateTime fecha, int estado, int producto)
        {
            sen.insertarBOM(descripcion, version, fecha, estado, producto);

            gCtrlBitacora.RegistrarAccion(
                Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                $"Registró un BOM con versión '{version}' para el producto '{producto}'",
                true
            );
        }

        // editar cesar santizo 0901-22-5215
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void editarBOM(int idBOM, string descripcion, string version, DateTime fecha, int estado)
        {
            sen.editarBOM(idBOM, descripcion, version, fecha, estado);

            gCtrlBitacora.RegistrarAccion(
                Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                $"Modificó el BOM '{idBOM}' con versión '{version}'",
                true
            );
        }

        // eliminar maria morales 0901-22-1226
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void eliminarBOM(int idBOM)
        {
            sen.eliminarBOM(idBOM);

            gCtrlBitacora.RegistrarAccion(
                Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                $"Eliminó el BOM '{idBOM}'",
                true
            );
        }

        //Método para transacción completa. Anderson Trigueros
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void guardarBOMCompleto(string descripcion, string version, DateTime fecha, int estado, int producto,
            List<(int idMaterial, int idUnidad, decimal cantidad)> listaDetalles,
            List<(string sFase, string sDescripcion, int iHoras)> listaFases)
        {
            sen.creaciónCompleta(descripcion, version, fecha, estado, producto, listaDetalles, listaFases);

            gCtrlBitacora.RegistrarAccion(
                Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                $"Registró un BOM completo con versión '{version}' para el producto '{producto}'",
                true
            );
        }



        //Método para transacción datos nuevos con BOM existente. Anderson Trigueros
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void guardarDatosNuevos(int iCodigoBOM,
            List<(int idMaterial, int idUnidad, decimal cantidad)> listaDetalle,
            List<(string sFase, string sDescripcion, int iHoras)> listaFases)
        {
            sen.agregarDatosNuevos(iCodigoBOM, listaDetalle, listaFases);

            gCtrlBitacora.RegistrarAccion(
                Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                $"Agregó nuevos detalles y fases al BOM '{iCodigoBOM}'",
                true
            );
        }


        // SENTENCIAS PARA RECETAS YA INGRESADAS 

        // Hecho por: Maria Morales 0901-22-1226
        public DataTable obtenerListadoBOM()
        {
            return sen.obtenerTodosBOM();
        }

        public DataTable obtenerBOMPorID(int id)
        {
            return sen.obtenerBOMPorID(id);
        }

        public DataTable obtenerDetalleBOM(int id)
        {
            return sen.obtenerDetalleBOM(id);
        }

        //Hecho por Diego Monterroso
        public DataTable filtrarListadoBOM(string id, string estado, DateTime? desde, DateTime? hasta)
        {
            return sen.filtrarBOM(id, estado, desde, hasta);
        }

    }
}