using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    public class SparseArrays
    {
        public static void Run()
        {
            string[] strings = new string[] { "def", "de", "fgh" };
            string[] queries = new string[] { "de", "lmn", "fgh" };

            var answers = matchingStrings(strings, queries);
        }

        static int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] result = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                for (int j = 0; j < strings.Length; j++)
                {
                    if (strings[j].Equals(queries[i]))
                    {
                        result[i]++;
                    }
                    
                }
            }

            return result;
        }
    }
}
