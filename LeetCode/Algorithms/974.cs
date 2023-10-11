namespace LeetCode.Algorithms;

// MEDIUM
internal class _974
{
	public static int SubarraysDivByK(int[] nums, int k)
	{
		var result = 0;

		var modGroups = new int[k];
		modGroups[0] = 1;

		var prefixMod = 0;
		for (var i = 0; i < nums.Length; i++)
		{
			prefixMod = (prefixMod + nums[i] % k + k) % k;
			result += modGroups[prefixMod];
			modGroups[prefixMod]++;
		}

		return result;
	}
}
