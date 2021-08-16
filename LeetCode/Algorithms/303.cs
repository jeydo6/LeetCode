namespace LeetCode.Algorithms
{
	class _303
	{
		public static string GetResult()
		{
			var numArray = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });
			numArray.SumRange(0, 2);
			numArray.SumRange(2, 5);
			numArray.SumRange(0, 5);
			return "";
		}
		public class NumArray
		{
			private readonly int[] _sums;

			public NumArray(int[] numbers)
			{
				_sums = new int[numbers.Length];
				numbers.CopyTo(_sums, 0);
				for (var i = 1; i < numbers.Length; i++)
				{
					_sums[i] += _sums[i - 1];
				}
			}

			public int SumRange(int left, int right)
			{
				if (left == 0)
				{
					return _sums[right];
				}
				else
				{
					return _sums[right] - _sums[left - 1];
				}
			}
		}
	}
}
