using System;
namespace Regex
{
    public class TestingData
    {
        public TestingData()
        {
        }

        public static string Emails()
        {
            string value = "My Name <my-email@email.com>\n";
            value += "Test Name <test@mail-me.com>\n";
            value += "Random Person <my-random-e-mail@stuff.com>";
            return value;
        }
    }
}
