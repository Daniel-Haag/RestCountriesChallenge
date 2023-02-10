using Microsoft.Extensions.Caching.Memory;

namespace RestCountriesChallenge.Services
{
    public interface ICountriesService
    {
        List<Country> GetCountryData(string name);
        MemoryCacheEntryOptions SetCacheOptions(int expirationSeconds);
        string teste(bool go);
    }
}
