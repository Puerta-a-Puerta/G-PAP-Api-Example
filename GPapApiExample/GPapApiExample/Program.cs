using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GPapApiExample
{
    class Program
    {
        private static HttpClient _httpClient;
        private const string REST_URL = "http://166.62.126.46:8080/{0}";

        static void Main(string[] args)
        {
            User user = LoginAsync().Result;

            if (user != null)
            {
                GetMyPackagesAsync(user.accessToken).Wait();
            }
        }

        /// <summary>
        /// Método para loguear en el api y obtener un accessToken
        /// </summary>
        /// <returns></returns>
        private static async Task<User> LoginAsync()
        {
            User user = null;
            try
            {
                string username = "yourusername";
                string password = "yourpassword";

                var uri = new Uri(string.Format(REST_URL, "api/User/login"));
                var jsonRequest = JsonConvert.SerializeObject(new { Username = username, Password = password });
                var stringContent = new StringContent(jsonRequest, Encoding.UTF8, "text/json");

                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, uri);
                requestMessage.Content = stringContent;

                if (_httpClient == null)
                {
                    _httpClient = new HttpClient();
                }

                var response = await _httpClient.SendAsync(requestMessage);

                //if (response.IsSuccessStatusCode)
                //{
                    var content = await response.Content.ReadAsStringAsync();
                    user = JsonConvert.DeserializeObject<User>(content);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return user;
        }

        /// <summary>
        /// Ejemplo de como obtener todos los paquetes creados por mi usuario
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private static async Task GetMyPackagesAsync(string token)
        {
            try
            {
                var uri = new Uri(string.Format(REST_URL, "api/Package/getPackages"));

                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
    
                requestMessage.Headers.Add("access-token", token);

                if (_httpClient == null)
                {
                    _httpClient = new HttpClient();
                }

                var response = await _httpClient.SendAsync(requestMessage);

                //if (response.IsSuccessStatusCode)
                //{
                var content = await response.Content.ReadAsStringAsync();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
