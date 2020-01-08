using Microsoft.Extensions.Caching.Memory;
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public IMemoryCache _cache;

        public Program(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }

        public void GetValues()
        {
           Console.WriteLine("Cache Value :{0}", _cache.Get<string>("key1"));
        }
        public void SetValues()
        {
            _cache.Set("key1", "Value of Key1");
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Program pgm = new Program(new IMemoryCache());
            pgm.SetValues();
            pgm.GetValues();
            Console.ReadLine();
        }

    }
}
