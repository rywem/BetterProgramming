using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
namespace ASPNET_WebPattern
{
    public static class WebContextCache
    {
        public static string UserContextData
        {
            get
            {
                return (string)HttpContext.Current.Cache["ContextData"];
            }
        }
        public static void Load()
        {
            HttpContext.Current.Cache["ContextData"] = new RandomGenerator().GetSimulatedData();
        }
    }

    public static class WebRuntimeCache
    {
        public static string UserGetRuntimeData
        {
            get
            {
                return (string)HttpRuntime.Cache.Get("RuntimeData");
            }
        }
        public static void Load()
        {
            DateTime utcExpires = DateTime.UtcNow.AddHours(7);
            HttpRuntime.Cache.Insert($"RuntimeData", new RandomGenerator().GetSimulatedData().ToString(), null, utcExpires, System.Web.Caching.Cache.NoSlidingExpiration);
        }
    }    
    public class RandomGenerator
    {
        private Random random = new Random();
        public string GetSimulatedData()
        {
            return RandomString(random.Next(10, 50));
        
        }
        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

}