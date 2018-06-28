using System;
using System.Text.RegularExpressions;
namespace Regex
{
    public class RegexTests
    {
        public RegexTests()
        {
        }

        public bool Match(string pattern, string stringToCheck)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(pattern);
            Match match = regex.Match(stringToCheck);
            return match.Success;
        }

        public string Replace(string pattern, string stringToReplace, string replacementText)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(pattern);
            return regex.Replace(stringToReplace, replacementText);
        }
    }
}
