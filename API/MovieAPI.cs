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
            var response = await httpClient.GetAsync(link + apiKey);
            var jsonString = await response.Content.ReadAsStringAsync();
            return jsonString;
        }

        public async Task<MovieModel.Movie> GetMovie(string title)
        {
            var jsonString = await GetJsonString($"https://www.omdbapi.com/?t={title}&apikey=");
            MovieModel.Movie movie = JsonConvert.DeserializeObject<MovieModel.Movie>(jsonString);
            return movie;
        }

        public async Task<MovieModel.SearchResponse> GetSearchResponse(string search)
        {
            var jsonString = await GetJsonString($"https://www.omdbapi.com/?s={search}&apikey=");
            MovieModel.SearchResponse searchResponse = JsonConvert.DeserializeObject<MovieModel.SearchResponse>(jsonString);
            return searchResponse;
        }
    }
}
