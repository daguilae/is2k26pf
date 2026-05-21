using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Controlador_Seguridad;
using Capa_Modelo_Fase;


namespace Capa_Controlador_Fase
{
    public class Cls_Controlador_Fase
    {
        Cls_Sentencias sentencias = new Cls_Sentencias();
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();
        private int idAplicacion = 729;

        public DataTable fun_DatosProductos()
        {
            return sentencias.fun_ObtenerProductos();
        }

        public DataTable fun_DatosFase(int iCodigoProducto)
        {
            return sentencias.fun_ObtenerFasesProducción(iCodigoProducto);
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void pro_GuardarFase(int iProducto, string sFase, string sDescripcion, int iHoras)
        {
            sentencias.pro_GuardarDatosFase(iProducto, sFase, sDescripcion, iHoras);

            gCtrlBitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                $"Registró la fase '{sFase}' para el producto '{iProducto}'",
                true
            );
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void pro_EliminarFase(int iCodigoFase)
        {
            sentencias.pro_EliminarReceta(iCodigoFase);

            gCtrlBitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                $"Eliminó la fase '{iCodigoFase}'",
                true
            );
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void pro_ActualizarFase(int iCodigoFase, string sFase, string sDescripcion, int iHoras)
        {
            sentencias.pro_Actualizar(iCodigoFase, sFase, sDescripcion, iHoras);

            gCtrlBitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                $"Actualizó la fase '{iCodigoFase}' con nombre '{sFase}'",
                true
            );
        }

    }
}
