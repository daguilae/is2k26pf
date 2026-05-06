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

    }
    }

