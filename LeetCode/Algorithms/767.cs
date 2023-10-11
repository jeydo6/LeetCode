namespace LeetCode.Algorithms;

// MEDIUM
internal class _767
{
    public string ReorganizeString(string s)
    {
        var charCounts = new int[26];
        for (var i = 0; i < s.Length; i++)
        {
            charCounts[s[i] - 'a']++;
        }

        var maxCount = 0;
        var maxCountIndex = 0;
        for (var i = 0; i < charCounts.Length; i++)
        {
            if (charCounts[i] > maxCount)
            {
                maxCount = charCounts[i];
                maxCountIndex = i;
            }
        }

        if (maxCount > (s.Length + 1) / 2)
        {
            return string.Empty;
        }

        var result = new char[s.Length];
        var index = 0;
        while (charCounts[maxCountIndex] > 0)
        {
            result[index] = (char)(maxCountIndex + 'a');
            index += 2;
            charCounts[maxCountIndex]--;
        }

        for (var i = 0; i < charCounts.Length; i++)
        {
            while (charCounts[i] > 0)
            {
                if (index >= s.Length)
                {
                    index = 1;
                }
                result[index] = (char)(i + 'a');
                index += 2;
                charCounts[i]--;
            }
        }

        return new string(result);
    }
}