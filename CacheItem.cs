using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7._3
{
    public class CacheItem<T>
    {
        public T Value { get; }
        public DateTime Expiration { get; }

        public CacheItem(T value, DateTime expiration)
        {
            Value = value;
            Expiration = expiration;
        }

        public bool IsExpired(TimeSpan expirationTime)
        {
            return DateTime.Now > Expiration - expirationTime;
        }
    }
}
