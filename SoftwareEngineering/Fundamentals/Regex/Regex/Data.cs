using System;
namespace Regex
{
    public static class Data
    {
        public static string Emails()
        {
            string value = "My Name <my-email@email.com>\n";
            value += "Test Name <test@mail-me.com>\n";
            value += "Random Person <my-random-e-mail@stuff.com>";
            return value;
        }
    }
}
