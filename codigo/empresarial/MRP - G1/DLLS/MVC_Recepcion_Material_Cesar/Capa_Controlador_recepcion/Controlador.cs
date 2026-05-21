using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_recepcion;
using Capa_Controlador_Seguridad;
using Capa_Modelo_Seguridad;

namespace Capa_Controlador_recepcion
{
    public class Controlador
    {
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();

        Sentencias sen = new Sentencias();
        //cesar santizo 0901-22-5215

        public DataTable getMateriales()
        {
            return sen.obtenerMateriales();
        }
        //cesar santizo 0901-22-5215

        public DataTable cargarUbi()
        {
            return sen.obtenerUbi();
        }
        //cesar santizo 0901-22-5215

        public DataTable cargarestado() 
        {
            return sen.estado();
        }
        public DataTable obtenerListadoRecepciones()
        {
            return sen.obtenerListadoRecepciones();
        }

        // Cesar Santizo 0901-22-5215
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void actualizarInventario(int idMaterial, int idAlmacen, decimal cantidad, decimal costo)
        {
            sen.actualizarInventario(idMaterial, idAlmacen, cantidad, costo);

            gCtrlBitacora.RegistrarAccion(
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                738,
                $"Actualizó inventario del material '{idMaterial}' en almacén '{idAlmacen}' con cantidad '{cantidad}' y costo '{costo}'",
                true
            );
        }


        public DataTable filtrarListadoRecepciones(string id, string estado, DateTime desde, DateTime hasta)
        {
            return sen.filtrarListadoRecepciones(id, estado, desde, hasta);
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void eliminarRecepcion(int idRecepcion)
        {
            sen.eliminarRecepcion(idRecepcion);

            gCtrlBitacora.RegistrarAccion(
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                738,
                $"Eliminó la recepción '{idRecepcion}'",
                true
            );
        }

        // Diego Monterroso 0901-22-1369
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26

        public int guardarRecepcionEncabezado(string idExterno, int almacen, int estado, DateTime notificacion, DateTime ingreso, string observacion)
        {
            int idRecepcion = sen.guardarRecepcionEncabezado(idExterno, almacen, estado, notificacion, ingreso, observacion);

            if (idRecepcion > 0)
            {
                gCtrlBitacora.RegistrarAccion(
                    Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                    738,
                    $"Registró encabezado de recepción '{idRecepcion}' con ID externo '{idExterno}'",
                    true
                );
            }

            return idRecepcion;
        }

        // Diego Monterroso 0901-22-1369
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void guardarRecepcionDetalle(int idRecepcion, int idMaterial, decimal cantidad, decimal costo)
        {
            sen.guardarRecepcionDetalle(idRecepcion, idMaterial, cantidad, costo);

            gCtrlBitacora.RegistrarAccion(
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                739,
                $"Registró detalle de recepción '{idRecepcion}' para material '{idMaterial}' con cantidad '{cantidad}'",
                true
            );
        }

        // Diego Monterroso 0901-22-1369
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void modificarRecepcionEncabezado(int idRecepcion, string idExterno, int almacen, int estado, DateTime notificacion, DateTime ingreso, string observacion)
        {
            sen.modificarRecepcionEncabezado(idRecepcion, idExterno, almacen, estado, notificacion, ingreso, observacion);

            gCtrlBitacora.RegistrarAccion(
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                738,
                $"Modificó encabezado de recepción '{idRecepcion}' con ID externo '{idExterno}'",
                true
            );
        }

        // Diego Monterroso 0901-22-1369
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void eliminarDetalleRecepcion(int idRecepcion)
        {
            sen.eliminarDetalleRecepcion(idRecepcion);

            gCtrlBitacora.RegistrarAccion(
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                739,
                $"Eliminó el detalle de la recepción '{idRecepcion}'",
                true
            );
        }

        // Diego Monterroso 0901-22-1369
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void eliminarRecepcionCompleta(int idRecepcion)
        {
            sen.eliminarRecepcionCompleta(idRecepcion);

            gCtrlBitacora.RegistrarAccion(
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                738,
                $"Eliminó completamente la recepción '{idRecepcion}'",
                true
            );
        }
        public DataTable obtenerRecepcionPorId(int id)
        {
            return sen.obtenerRecepcionPorId(id);
        }

        public DataTable obtenerDetalleRecepcion(int id)
        {
            return sen.obtenerDetalleRecepcion(id);
        }
    }
    }

