using System;

namespace LeetCode.Algorithms
{
	class _3828
	{
		public static int ThreeSumClosest(int[] numbers, int target)
		{
			var result = int.MaxValue;

			Array.Sort(numbers);

			var min = int.MaxValue;
			for (var i = 0; i < numbers.Length - 2; i++)
			{
				var left = i + 1;
				var right = numbers.Length - 1;

				while (left < right)
				{
					var sum = numbers[i] + numbers[left] + numbers[right];

					if (sum == target)
					{
						min = 0;
						result = target;
						break;
					}
					else
					{
						var d = Math.Abs(sum - target);
						if (d < min)
						{
							min = d;
							result = sum;
						}

						if (sum < target)
						{
							left++;
						}
						else
						{
							right--;
						}
					}
				}
			}

			return result;
		}
	}
}
