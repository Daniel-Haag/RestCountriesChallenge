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
        private readonly ICountriesService _countryService;

        //Injeções de dependência
        public CountriesController(IMemoryCache cache, ICountriesService countryService)
        {
            _cache = cache;
            _countryService = countryService;
        }

        /// <summary>
        /// Método utilizado para retornar os dados de um país conforme o nome informado
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("GetCountry")]
        public List<Country> GetCountry(string name)
        {
            var cacheKey = "Country";
            List<Country> result = new List<Country>();
            MemoryCacheEntryOptions? cacheOptions;

            if (!_cache.TryGetValue<List<Country>>(cacheKey, out result))
            {
                result = _countryService.GetCountryData(name);
                cacheOptions = _countryService.SetCacheOptions(30);

                _cache.Set(cacheKey, result, cacheOptions);

                if (result != null)
                {
                    return result;
                }
            }
            else
            {
                if (result != null && result.Count > 0)
                {
                    string maybeOldName = result[0].name.common.ToString().ToLower();

                    if (maybeOldName.ToLower() != name.ToLower())
                    {
                        result = _countryService.GetCountryData(name);
                        cacheOptions = _countryService.SetCacheOptions(30);
                        _cache.Set(cacheKey, result, cacheOptions);
                    }
                }
            }

            return result;
        }
    }
}