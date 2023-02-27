using Microsoft.Extensions.Caching.Memory;
//using RestCountriesChallenge.Models;
using RestSharp;
using System.Text.Json;

namespace RestCountriesChallenge.Services
{
    public class CountriesService
    {
        public List<Country> GetData(string? name, string? currency, string? code, List<Country> result)
        {
            if (!string.IsNullOrEmpty(name))
            {
                //Consumo da API para obter os dados por nome do país
                result = GetCountryDataByName(name);
            }
            else if (!string.IsNullOrEmpty(currency))
            {
                //Consumo da API para obter os dados por moeda do país
                result = GetCountryDataByCurrency(currency);
            }
            else if (!string.IsNullOrEmpty(code))
            {
                //Consumo da API para obter os dados por moeda do país
                result = GetCountryDataByCode(code);
            }

            return result;
        }
        public List<Country> GetCountryDataByName(string name)
        {
            List<Country> result;
            var client = new RestClient("https://restcountries.com/v3.1/name/" + name);
            var request = new RestRequest();
            RestResponse response = client.Execute(request);

            result = JsonSerializer.Deserialize<List<Country>>(response.Content);
            return result;
        }

        public List<Country> GetCountryDataByCurrency(string currency)
        {
            List<Country> result;
            var client = new RestClient("https://restcountries.com/v3.1/currency/" + currency);
            var request = new RestRequest();
            RestResponse response = client.Execute(request);

            result = JsonSerializer.Deserialize<List<Country>>(response.Content);
            return result;
        }

        public List<Country> GetCountryDataByCode(string code)
        {
            List<Country> result;
            var client = new RestClient("https://restcountries.com/v3.1/alpha/" + code);
            var request = new RestRequest();
            RestResponse response = client.Execute(request);

            result = JsonSerializer.Deserialize<List<Country>>(response.Content);
            return result;
        }
    }
}
