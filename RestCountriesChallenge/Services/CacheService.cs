using Microsoft.Extensions.Caching.Memory;
using RestSharp;
using System.Text.Json;

namespace RestCountriesChallenge.Services
{
    public class CacheService
    {
        public MemoryCacheEntryOptions SetCacheOptions(int expirationSeconds)
        {
            return new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(expirationSeconds));
        }

        public string SetCacheKey(string? name, string? currency, string? code, string cacheKey)
        {
            if (!string.IsNullOrEmpty(name))
            {
                cacheKey = name;
            }
            else if (!string.IsNullOrEmpty(currency))
            {
                cacheKey = currency;
            }
            else if (!string.IsNullOrEmpty(code))
            {
                cacheKey = code;
            }

            return cacheKey;
        }
    }
}
