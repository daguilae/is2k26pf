using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;

namespace Capa_Controlador_OrdenProduccion
{
    public class Cls_ServicioAPI
    {
        // #1: HttpClient estático y reutilizable
        private static readonly HttpClient _client = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(30)   // FIX #2: Timeout explícito (antes no tenía)
        };

        //  #3: URL desde App.config (antes estaba hardcodeada en el código)

        private readonly string _urlApi =
                ConfigurationManager.AppSettings["UrlApiMRP"] ?? "http://10.33.111.28/api/Ordenes";
        //  #4: Retorna string con el error en lugar de bool

        public async Task<string> EnviarOrdenAProduccion(object ordenDto)
        {
            try
            {
                // #5: JsonSerializerSettings con formato de fecha explícito

                string json = JsonConvert.SerializeObject(ordenDto, new JsonSerializerSettings
                {
                    DateFormatString = "yyyy-MM-dd",
                    NullValueHandling = NullValueHandling.Ignore
                });

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(_urlApi, content);

                // Leer el cuerpo de la respuesta siempre (exitosa o no)
                string cuerpoRespuesta = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                    return null;
                else
                    return cuerpoRespuesta;
            }
            catch (TaskCanceledException)
            {
                throw new Exception("La API del MRP no respondió en 30 segundos. Verifique la conexión de red.");
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión con el servidor de producción: " + ex.Message);
            }
        }
    }
}
