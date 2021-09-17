using System.Linq;

namespace LISPValidator
{
    public class Validator
    {
        public static bool ValidateLISP(string lispString)
        {
            //no parentheses
            if (lispString.IndexOfAny(new char[] { '(', ')' }) == -1) return false;

            //unequal number of open and closed parentheses
            var openParenthesisCount = lispString.Count(x => x == '(');
            var closedParenthesisCount = lispString.Count(x => x == ')');

            if (openParenthesisCount != closedParenthesisCount) return false;

            //unmatched parentheses
            lispString = lispString.Replace("()", "");
            var firstOpenParenthesesIndex = lispString.IndexOf('(');
            var firstClosedParenthesesIndex = lispString.IndexOf(')');
            var lastOpenParenthesesIndex = lispString.LastIndexOf('(');
            var lastClosedParenthesesIndex = lispString.LastIndexOf(')');

            if (firstOpenParenthesesIndex > firstClosedParenthesesIndex ||
                lastOpenParenthesesIndex > lastClosedParenthesesIndex)
                return false;
            else return true;

        }
    }
}
