
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        char[] separators = { ',', '.', '!', '?' };
        var words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var longestString = 0;

        foreach (var item in words)
        {
            var arrayItem = item.Trim().Split(' ');
            if (arrayItem.Length >= 0 && arrayItem.Length > longestString)
            {
                longestString = arrayItem.Length;
            }

        }
        return longestString;
    }
}
