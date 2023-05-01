using Newtonsoft.Json;
using SearchMovie.Models;

namespace SearchMovie.API
{
    public class MovieAPI
    {
        HttpClient httpClient;
        string apiKey;
        
        public MovieAPI(string apiKey)
        {
            httpClient = new HttpClient();
            this.apiKey = apiKey;
        }
        public async Task<string> GetJsonString(string link)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(link + apiKey);
            var jsonString = await response.Content.ReadAsStringAsync();
            return jsonString;
        }
        
    }
}
