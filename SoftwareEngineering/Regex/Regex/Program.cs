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
            QuantifierExample();
        }

        public static void StartingExample()
        {
            //match 
            RegexHelper helper = new RegexHelper();
            string pattern = @"(?<=<).*?(?=>)";

        }

        public static void QuantifierExample()
        {
            RegexHelper helper = new RegexHelper();
            string input = "hello how are you?";
            string pattern = @"[a-z]+";
            var result = helper.Match(pattern, input);
            Console.WriteLine(result);
        }
    }
}
