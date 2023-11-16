using System.Text;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1980
{
    public static string FindDifferentBinaryString(string[] nums)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < nums.Length; i++)
        {
            var ch = nums[i][i];
            sb.Append(ch == '0' ? '1' : '0');
        }
        
        return sb.ToString();
    }
}