using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1441
{
    public static IList<string> BuildArray(int[] target, int n)
    {
        var result = new List<string>();

        var j = 0;
        for (var i = 0; i < target.Length; i++)
        {
            while (j < target[i] - 1)
            {
                result.Add("Push");
                result.Add("Pop");
                j++;
            }

            result.Add("Push");
            j++;
        }

        return result;
    }
}