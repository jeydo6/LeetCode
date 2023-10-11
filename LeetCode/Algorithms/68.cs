namespace LeetCode.Algorithms;

// HARD
internal class _68
{
    public static IList<string> FullJustify(string[] words, int maxWidth)
    {
        var result = new List<string>();
        var i = 0;
        while (i < words.Length)
        {
            var currentLine = GetWords(words, maxWidth, i);
            i += currentLine.Count;
            result.Add(CreateLine(words, maxWidth, i, currentLine));
        }
        
        return result;
    }

    private static IList<string> GetWords(string[] words, int maxWidth, int i)
    {
        var currentLine = new List<string>();
        var currentLength = 0;
        while (i < words.Length && currentLength + words[i].Length <= maxWidth)
        {
            currentLine.Add(words[i]);
            currentLength += words[i].Length + 1;
            i++;
        }

        return currentLine;
    }

    private static string CreateLine(string[] words, int maxWidth, int i, IList<string> line)
    {
        var baseLength = -1;
        for (var j = 0; j < line.Count; j++)
        {
            baseLength += line[j].Length + 1;
        }

        var extraSpaces = maxWidth - baseLength;
        if (line.Count == 1 || i == words.Length)
        {
            return string.Join(" ", line) + new string(' ', extraSpaces);
        }

        var wordCount = line.Count - 1;
        var spacesPerWord = extraSpaces / wordCount;
        var needsExtraSpace = extraSpaces % wordCount;
        for (var j = 0; j < needsExtraSpace; j++)
        {
            line[j] += " ";
        }

        for (var j = 0; j < wordCount; j++)
        {
            line[j] += new string(' ', spacesPerWord);
        }

        return string.Join(" ",  line);
    }
}