using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AppClima1.Clases;
using System.Net.Http;
using System; 


namespace AppClima1.Servicios
{
    public static class ServicioClima
    {
        static string Key="116be50d5edd9b7f6e236817a565723f ";
        public static async Task<Clima> ConsultarClima(string ciudad)
        {
            var conexion = $"http://api.openweathermap.org/data/2.5/weather?q={ciudad}&appid={Key}";
            using (var cliente = new HttpClient())
            {
                var peticion = await cliente.GetAsync(conexion);
                if (peticion != null)
                {
                    var json = peticion.Content.ReadAsString.Async().Result;
                    var datos = (JContainer)JsonConvert.DeserializeObject(json);
                    if (datos["weather"] != null)
                    {
                        var clima = new Clima();
                        clima.Titulo = (string)datos["name"];
                        clima.Temperatura = ((float)datos["main"]["temp"] - 273.15).ToString("N2") + "C°";
                        clima.Viento = (string)datos["wind"]["speed"] + "mph";
                        clima.Humedad = (string)datos["main"]["humidity"] + "%";
                        clima.Visibilidad = (string)datos["weather"][0]["main"];
                        return clima;
                    }
                }
            }
            return default(Clima);
        }
    }

    internal class HttpClient : IDisposable
    {
    }
}
