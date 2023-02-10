using Microsoft.Extensions.Caching.Memory;
using RestSharp;
using System.Text.Json;

namespace RestCountriesChallenge.Services
{
    public class CountriesService
    {
        public List<Country> GetCountryData(string name)
        {
            List<Country> result;
            var client = new RestClient("https://restcountries.com/v3.1/name/" + name);
            var request = new RestRequest();
            RestResponse response = client.Execute(request);

            result = JsonSerializer.Deserialize<List<Country>>(response.Content);
            return result;
        }

        public MemoryCacheEntryOptions SetCacheOptions(int expirationSeconds)
        {
            return new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(expirationSeconds));
        }
    }
}
