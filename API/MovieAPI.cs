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
        public async Task<MovieModel> GetMovie(string title)
        {
            var jsonString = await GetJsonString($"https://www.omdbapi.com/?t={title}&apikey=");
            MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(jsonString);
            return movie;
        }
    }
}
