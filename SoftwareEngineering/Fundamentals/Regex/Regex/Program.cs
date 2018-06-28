using System;

namespace Regex
{
    class MainClass
    {
        /// <summary>
        /// Based on udemy course:
        /// https://www.udemy.com/regex-academy-an-introduction-to-text-parsing-sorcery/learn/v4/t/lecture/8040022?start=0
        /// </summary>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void StartingExample()
        {
            //match 
            RegexHelper helper = new RegexHelper();
            string pattern = @"(?<=<).*?(?=>)";

        }
    }
}
