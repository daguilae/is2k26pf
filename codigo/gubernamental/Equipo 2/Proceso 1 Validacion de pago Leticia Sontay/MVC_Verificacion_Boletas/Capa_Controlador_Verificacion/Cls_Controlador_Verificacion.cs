using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Verificacion;

namespace Capa_Controlador_Verificacion
{
        public class Cls_Controlador_Verificacion
    {
            private Cls_Sentencias_Verificacion sentencias = new Cls_Sentencias_Verificacion();

            // Método para validar boleta
            public DataTable ValidarBoleta(string numeroBoleta)
            {
                return sentencias.BuscarBoleta(numeroBoleta);
            }
        }
    }