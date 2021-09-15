namespace LeetCode.Algorithms
{
	// MEDIUM
	class _978
	{
		public static int MaxTurbulenceSize(int[] arr)
		{
			var result = 1;
			
			var inc = 1;
			var dec = 1;
			for (var i = 1; i < arr.Length; i++)
			{
				if (arr[i] < arr[i - 1])
				{
					dec = inc + 1;
					inc = 1;
				}
				else if (arr[i] > arr[i - 1])
				{
					inc = dec + 1;
					dec = 1;
				}
				else
				{
					inc = 1;
					dec = 1;
				}
				result = Math.Max(result, Math.Max(dec, inc));
			}

			return result;
		}
	}
}
