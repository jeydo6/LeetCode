namespace LeetCode.Algorithms;

// HARD
internal class _1220
{
	private const long Modulo = 1000000007;

	public static int CountVowelPermutation(int n)
	{
		var aCount = 1L;
		var eCount = 1L;
		var iCount = 1L;
		var oCount = 1L;
		var uCount = 1L;

		for (var i = 1; i < n; i++)
		{
			var aCountNew = (eCount + iCount + uCount) % Modulo;
			var eCountNew = (aCount + iCount) % Modulo;
			var iCountNew = (eCount + oCount) % Modulo;
			var oCountNew = (iCount) % Modulo;
			var uCountNew = (iCount + oCount) % Modulo;

			aCount = aCountNew;
			eCount = eCountNew;
			iCount = iCountNew;
			oCount = oCountNew;
			uCount = uCountNew;
		}

		var result = (aCount + eCount + iCount + oCount + uCount) % Modulo;

		return (int)result;
	}
}