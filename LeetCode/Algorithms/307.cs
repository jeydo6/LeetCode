using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _307
	{
		public class NumArray
		{
			private readonly int[] _nums;
			private readonly int[] _array;

			public NumArray(int[] nums)
			{
				_nums = nums;
				
				var length = (int)Math.Ceiling(
					nums.Length / Math.Sqrt(nums.Length)
				);

				_array = new int[length];
				for (var i = 0; i < nums.Length; i++)
				{
					_array[i / _array.Length] += nums[i];
				}
			}

			public void Update(int index, int val)
			{
				var arrayIndex = index / _array.Length;
				_array[arrayIndex] = _array[arrayIndex] - _nums[index] + val;
				_nums[index] = val;
			}

			public int SumRange(int left, int right)
			{
				var result = 0;
				var startBlock = left / _array.Length;
				int endBlock = right / _array.Length;
				if (startBlock == endBlock)
				{
					for (var k = left; k <= right; k++)
					{
						result += _nums[k];
					}
				}
				else
				{
					for (var k = left; k <= (startBlock + 1) * _array.Length - 1; k++)
					{
						result += _nums[k];
					}

					for (var k = startBlock + 1; k <= endBlock - 1; k++)
					{
						result += _array[k];
					}

					for (var k = endBlock * _array.Length; k <= right; k++)
					{
						result += _nums[k];
					}
				}

				return result;
			}
		}
	}
}
