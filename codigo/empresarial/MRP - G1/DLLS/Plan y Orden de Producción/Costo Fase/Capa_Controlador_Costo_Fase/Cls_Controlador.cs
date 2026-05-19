using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Costo_Fase;
using Capa_Controlador_Seguridad;
using Capa_Modelo_Seguridad;

namespace Capa_Controlador_Costo_Fase
{
   public class Cls_Controlador
    {


        Cls_Sentencias sentencias = new Cls_Sentencias();

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();
        private int idAplicacion = 740;


        public bool ValidarExisteCosto(int idFase, int idTipoCosto)
        {
           
            return sentencias.fun_ExisteCostoFase(idFase, idTipoCosto);
        }

        public List<Cls_Datos_Material> ObtenerMateriales()
        {
            return sentencias.fun_ObtenerMateriales();
        }

        
        public List<Cls_Datos_Fase> ObtenerFasesPorMaterial(int idMaterial)
        {
            return sentencias.fun_ObtenerFasesPorMaterial(idMaterial);
        }


        public List<Cls_Datos_Tipo_Costo> ObtenerTiposCosto()
        {
            return sentencias.fun_ObtenerTiposCosto();
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void InsertarCostoFase(int idFase, int idTipoCosto, decimal costo)
        {
            sentencias.fun_InsertarCostoFase(idFase, idTipoCosto, costo);

            gCtrlBitacora.RegistrarAccion(
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                $"Registró costo de fase para la fase '{idFase}' con tipo de costo '{idTipoCosto}' y monto '{costo}'",
                true
            );
        }


        public List<Cls_Datos_Costo_Fase> ObtenerCostoFase()
        {
            return sentencias.fun_ObtenerCostoFase();
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void ModificarCostoFase(int id, int idFase, int idTipoCosto, decimal costo)
        {
            sentencias.fun_ModificarCostoFase(id, idFase, idTipoCosto, costo);

            gCtrlBitacora.RegistrarAccion(
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                $"Modificó el costo de fase '{id}' con nuevo monto '{costo}'",
                true
            );
        }

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void EliminarCostoFase(int id)
        {
            sentencias.fun_EliminarCostoFase(id);

            gCtrlBitacora.RegistrarAccion(
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario,
                idAplicacion,
                $"Eliminó el costo de fase '{id}'",
                true
            );
        }


    }
}
