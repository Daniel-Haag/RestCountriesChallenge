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

        //Injeções de dependência
        public CountriesController(IMemoryCache cache)
        {
            _cache = cache;
        }

        /// <summary>
        /// Método utilizado para retornar os dados de um país conforme o nome, moeda ou sigla informados
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

            //Serviço que tem a lógica para os dados dos países
            CountriesService countriesService = new CountriesService();

            //Serviço que tem a lógica para as configurações de cache
            CacheService cacheService = new CacheService();

            //Configurando a chave de acesso aos dados do cache em tempo de execução
            cacheKey = cacheService.SetCacheKey(name, currency, code, cacheKey);

            if (!_cache.TryGetValue<List<Country>>(cacheKey, out result))
            {
                //Obtendo os dados necessários via api rest
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