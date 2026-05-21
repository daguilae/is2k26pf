using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Empresa_Transporte;

namespace Capa_Controlador_Emp_Transp
{
    public class Cls_Emp_Transp_Controlador
    {
        Cls_Sentencias_Emp_Transp sentencias = new Cls_Sentencias_Emp_Transp();

        public DataTable fun_DatosEmpresa()
        {
            return sentencias.fun_ObtenerEmpresa();
        }

        public DataTable fun_DatosTransporte()
        {
            return sentencias.fun_ObtenerTransporte();
        }

        public void pro_GuardarTransporte(int iCodigoEmpresa, string sTipoTransp, string sPlaca, string sNombreP, int iCapacidad, string sEstado)
        {
            sentencias.pro_GuardarTransporte(iCodigoEmpresa, sTipoTransp, sPlaca, sNombreP, iCapacidad, sEstado);
        }

        public void pro_ModificarTransporte(int iCodigoTransporte, int iCodigoEmpresa, string sTipoTransp, string sPlaca, string sNombreP, int iCapacidad, string sEstado)
        {
            sentencias.pro_ModificarTransporte(iCodigoTransporte, iCodigoEmpresa, sTipoTransp, sPlaca, sNombreP, iCapacidad, sEstado);
        }

        public void pro_EliminarTransporte(int iCodigoTransporte)
        {
            sentencias.pro_EliminarTransporte(iCodigoTransporte);
        }

        public DataTable fun_DatosIdCompra()
        {
            return sentencias.fun_ObtenerIdCompra();
        }

        public DataTable fun_DatosCompra()
        {
            return sentencias.fun_ObtenerCompra();
        }

        public void pro_GuardarCompra(int iCodigoCompra, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            sentencias.pro_GuardarCompra(iCodigoCompra, iCodigoTransporte, sDireccion, sFecha, sEstado);
        }

        public void pro_ModificarCompra(int iCodigoEntrega, int iCodigoVenta, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            sentencias.pro_ModificarCompra(iCodigoEntrega, iCodigoVenta, iCodigoTransporte, sDireccion, sFecha, sEstado);
        }

        public bool fun_ExisteEntregaCompra(int iCodigoCompra)
        {
            return sentencias.fun_ExisteEntregaCompra(iCodigoCompra);
        }

        public void pro_EliminarCompra(int iCodigoEntrega)
        {
            sentencias.pro_EliminarCompra(iCodigoEntrega);
        }

        public DataTable fun_DatosIdVenta()
        {
            return sentencias.fun_ObtenerIdVenta();
        }

        public DataTable fun_DatosVenta()
        {
            return sentencias.fun_ObtenerVenta();
        }

        public void pro_GuardarVenta(int iCodigoVenta, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            sentencias.pro_GuardarVenta(iCodigoVenta, iCodigoTransporte, sDireccion, sFecha, sEstado);
        }

        public bool fun_ExisteEntregaVenta(int iCodigoVenta)
        {
            return sentencias.fun_ExisteEntregaVenta(iCodigoVenta);
        }

        public void pro_ModificarVenta(int iCodigoEntrega, int iCodigoVenta, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            sentencias.pro_ModificarVenta(iCodigoEntrega, iCodigoVenta, iCodigoTransporte, sDireccion, sFecha, sEstado);
        }

        public void pro_EliminarVenta(int iCodigoEntrega)
        {
            sentencias.pro_EliminarVenta(iCodigoEntrega);
        }

        public DataTable fun_DatosIdProduccion()
        {
            return sentencias.fun_ObtenerIdProduccion();
        }

        public DataTable fun_DatosProduccion()
        {
            return sentencias.fun_ObtenerProduccion();
        }

        public void pro_GuardarProduccion(int iCodigoOrdenP, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            sentencias.pro_GuardarProduccion(iCodigoOrdenP, iCodigoTransporte, sDireccion, sFecha, sEstado);
        }

        public bool fun_ExisteEntregaProduccion(int iCodigoOrdenP)
        {
            return sentencias.fun_ExisteEntregaProduccion(iCodigoOrdenP);
        }

        public void pro_ModificarProduccion(int iCodigoEntrega, int iCodigoOrdenP, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            sentencias.pro_ModificarProduccion(iCodigoEntrega, iCodigoOrdenP, iCodigoTransporte, sDireccion, sFecha, sEstado);
        }

        public void pro_EliminarProduccion(int iCodigoEntrega)
        {
            sentencias.pro_EliminarProduccion(iCodigoEntrega);
        }

        public DataTable fun_DatosIdTransporte()
        {
            return sentencias.fun_ObtenerIdTransporte();
        }
    }
}
