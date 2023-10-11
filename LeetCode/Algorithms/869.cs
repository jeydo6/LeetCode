namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _869
	{
		public static bool ReorderedPowerOf2(int n)
		{
			var arr = Count(n);
			for (var i = 0; i < 31; i++)
			{
				if (Equals(arr, Count(1 << i)))
				{
					return true;
				}
			}

			return false;
		}

		private static int[] Count(int n)
		{
			var result = new int[10];
			while (n > 0)
			{
				result[n % 10]++;
				n /= 10;
			}
			return result;
		}

		private static bool Equals(int[] arr1, int[] arr2)
		{
			if (arr1.Length != arr2.Length)
			{
				return false;
			}

			for (var i = 0; i < arr1.Length; i++)
			{
				if (arr1[i] != arr2[i])
				{
					return false;
				}
			}

			return true;
		}
	}
}
