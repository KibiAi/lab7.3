using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7._3
{
    public class FunctionCache<TKey, TResult>
    {
        private Dictionary<TKey, CacheItem<TResult>> cache = new Dictionary<TKey, CacheItem<TResult>>();

        public delegate TResult Func<TKey, TResult>(TKey key);

        public TResult GetOrAdd(TKey key, Func<TKey, TResult> func, TimeSpan expirationTime)
        {
            if (cache.ContainsKey(key) && !cache[key].IsExpired(expirationTime))
            {
                return cache[key].Value;
            }
            else
            {
                TResult result = func(key);
                cache[key] = new CacheItem<TResult>(result, DateTime.Now.Add(expirationTime));
                return result;
            }
        }
    }
}
