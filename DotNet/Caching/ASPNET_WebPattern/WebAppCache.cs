using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
namespace ASPNET_WebPattern
{
    public static class WebAppCache
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