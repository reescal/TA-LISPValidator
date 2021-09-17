using System.Linq;
using System.Text.RegularExpressions;

namespace LISPValidator
{
    public class Validator
    {
        public static bool ValidateLISP(string lispString)
        {
            //no parenthesis or unequal number of open and closed parenthesis
            var openParenthesisCount = lispString.Count(x => x == '(');
            var closedParenthesisCount = lispString.Count(x => x == ')');

            if ((openParenthesisCount + closedParenthesisCount) == 0
                || openParenthesisCount != closedParenthesisCount)
                return false;

            //unmatched parenthesis
            lispString = Regex.Replace(lispString, @"[^()]\(\)", "");

            var firstOpenParenthesisIndex = lispString.IndexOf('(');
            var firstClosedParenthesisIndex = lispString.IndexOf(')');
            var lastOpenParenthesisIndex = lispString.LastIndexOf('(');
            var lastClosedParenthesisIndex = lispString.LastIndexOf(')');

            if (firstOpenParenthesisIndex > firstClosedParenthesisIndex ||
                lastOpenParenthesisIndex > lastClosedParenthesisIndex)
                return false;
            else
                return true;

        }
    }
}
