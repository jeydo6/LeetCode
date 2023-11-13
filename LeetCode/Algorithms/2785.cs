using System.Text;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2785
{
    private const string SortedVowel = "AEIOUaeiou";

    public static string SortVowels(string s)
    {
        var counts = new int[58];
        for (var i = 0; i < s.Length; i++)
        {
            if (IsVowel(s[i]))
            {
                counts[s[i] - 'A']++;
            }
        }

        var sb = new StringBuilder();
        
        var j = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (!IsVowel(s[i]))
            {
                sb.Append(s[i]);
            }
            else
            {
                while (counts[SortedVowel[j] - 'A'] == 0)
                {
                    j++;
                }

                sb.Append(SortedVowel[j]);
                counts[SortedVowel[j] - 'A']--;
            }
        }
        return sb.ToString();
    }

    private static bool IsVowel(char ch)
    {
        return ch is
            'a' or 'e' or 'o' or 'u' or 'i' or
			'A' or 'E' or 'O' or 'U' or 'I';
    }
}