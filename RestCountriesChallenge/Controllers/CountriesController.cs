using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using RestSharp;
using System.Text.Json;
using RestCountriesChallenge.Services;

namespace RestCountriesChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly IMemoryCache _cache;

        //Inje��es de depend�ncia
        public CountriesController(IMemoryCache cache)
        {
            _cache = cache;
        }

        /// <summary>
        /// M�todo utilizado para retornar os dados de um pa�s conforme o nome, moeda ou sigla informados
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("GetCountry")]
        public List<Country> GetCountry(string? name, string? currency, string? code)
        {
            //Chave para obter os dados do cache
            string cacheKey = string.Empty;

            //Objeto principal que entrega os dados obtidos
            List<Country> result = new List<Country>();

            //Servi�o que tem a l�gica para os dados dos pa�ses
            CountriesService countriesService = new CountriesService();

            //Servi�o que tem a l�gica para as configura��es de cache
            CacheService cacheService = new CacheService();

            //Configurando a chave de acesso aos dados do cache em tempo de execu��o
            cacheKey = cacheService.SetCacheKey(name, currency, code, cacheKey);

            if (!_cache.TryGetValue<List<Country>>(cacheKey, out result))
            {
                //Obtendo os dados necess�rios via api rest
                result = countriesService.GetData(name, currency, code, result);

                //Configurando e atribuindo o resultado no cache
                _cache.Set(cacheKey, result, cacheService.SetCacheOptions(30));

                if (result != null)
                {
                    return result;
                }
            }
            else
            {
                return result;
            }

            return result;
        }
    }
}