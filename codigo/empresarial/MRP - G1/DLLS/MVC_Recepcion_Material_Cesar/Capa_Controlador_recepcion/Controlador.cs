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

        public DataTable filtrarListadoRecepciones(string id, string estado, DateTime desde, DateTime hasta)
        {
            return sen.filtrarListadoRecepciones(id, estado, desde, hasta);
        }

        public void eliminarRecepcion(int idRecepcion)
        {
            sen.eliminarRecepcion(idRecepcion);
        }

        // Diego Monterroso 0901-22-1369
        public int guardarRecepcionEncabezado(string idExterno, int almacen, int estado, DateTime notificacion, DateTime ingreso, string observacion)
        {
            return sen.guardarRecepcionEncabezado(idExterno, almacen, estado, notificacion, ingreso, observacion);
        }

        // Diego Monterroso 0901-22-1369
        public void guardarRecepcionDetalle(int idRecepcion, int idMaterial, decimal cantidad, decimal costo)
        {
            sen.guardarRecepcionDetalle(idRecepcion, idMaterial, cantidad, costo);
        }

        // Diego Monterroso 0901-22-1369
        public void modificarRecepcionEncabezado(int idRecepcion, string idExterno, int almacen, int estado, DateTime notificacion, DateTime ingreso, string observacion)
        {
            sen.modificarRecepcionEncabezado(idRecepcion, idExterno, almacen, estado, notificacion, ingreso, observacion);
        }

        // Diego Monterroso 0901-22-1369
        public void eliminarDetalleRecepcion(int idRecepcion)
        {
            sen.eliminarDetalleRecepcion(idRecepcion);
        }

        // Diego Monterroso 0901-22-1369
        public void eliminarRecepcionCompleta(int idRecepcion)
        {
            sen.eliminarRecepcionCompleta(idRecepcion);
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

