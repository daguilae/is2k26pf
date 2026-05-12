// Arón Ricardo Esquit Silva 0901-22-13036 11/05/2026
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Capa_Controlador_Expl_Mat
{
    public class OrdenMaterialApi
    {
        public int idOrdenMaterial { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public List<DetalleOrdenMaterialApi> detalle { get; set; }
    }

    public class DetalleOrdenMaterialApi
    {
        public string nombreMaterial { get; set; }
        public decimal cantidadSolicitada { get; set; }
    }

    public class RespuestaApiOrdenMaterial
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
        public int IdOrdenMaterial { get; set; }
        public int IdVentaLogistica { get; set; }
        public decimal Total { get; set; }
    }

    public class Cls_Api_OrdenMaterial
    {
        private readonly string urlApi = "http://172.20.10.6:5001/api/Ordenes";

        public RespuestaApiOrdenMaterial EnviarOrdenMaterial(OrdenMaterialApi orden)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(orden);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = client
                        .PostAsync(urlApi, content)
                        .GetAwaiter()
                        .GetResult();

                    string responseBody = response.Content
                        .ReadAsStringAsync()
                        .GetAwaiter()
                        .GetResult();

                    if (response.IsSuccessStatusCode)
                    {
                        dynamic resultado = JsonConvert.DeserializeObject<dynamic>(responseBody);
                        return new RespuestaApiOrdenMaterial
                        {
                            Exitoso = true,
                            Mensaje = "Orden enviada correctamente.",
                            IdOrdenMaterial = (int)resultado.idOrdenMaterial,
                            IdVentaLogistica = (int)resultado.idVentaLogistica,
                            Total = (decimal)resultado.total
                        };
                    }
                    else
                    {
                        return new RespuestaApiOrdenMaterial
                        {
                            Exitoso = false,
                            Mensaje = "Error API (" + (int)response.StatusCode + "): " + responseBody
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new RespuestaApiOrdenMaterial
                {
                    Exitoso = false,
                    Mensaje = "No se pudo conectar con la API: " + ex.Message
                };
            }
        }
    }
}