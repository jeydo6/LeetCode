namespace LeetCode.Algorithms
{
	internal class _75
	{
		public static void SortColors(int[] nums)
		{
			var zero = 0;
			var one = 0;
			var two = 0;

			var i = 0;
			while (i < nums.Length)
			{
				switch (nums[i])
				{
					case 0:
						zero++;
						break;
					case 1:
						one++;
						break;
					default:
						two++;
						break;
				}

				i++;
			}

			i = 0;
			while (zero > 0)
			{
				nums[i++] = 0;
				zero--;
			}

			while (one > 0)
			{
				nums[i++] = 1;
				one--;
			}

			while (two > 0)
			{
				nums[i++] = 2;
				two--;
			}
		}
	}
}