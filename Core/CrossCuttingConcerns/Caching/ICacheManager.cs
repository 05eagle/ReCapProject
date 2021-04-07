using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        object Get(string key);
        void Add(string key, object value,int duration);
        T Get<T>(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
        bool IsAdd(string key);
    }
}
