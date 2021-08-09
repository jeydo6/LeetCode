namespace LeetCode.Algorithms
{
	public class _905
	{
		public static int[] SortArrayByParity(int[] numbers)
		{
			var result = new int[numbers.Length];
			var i = 0;
			var j = numbers.Length - 1;
			foreach (var number in numbers)
			{
				if (number % 2 == 0)
				{
					result[i++] = number;
				}
				else
				{
					result[j--] = number;
				}
			}
			return result;
		}

		//public static int[] SortArrayByParity(int[] numbers)
		//{
		//	Array.Sort(numbers, (m, n) =>
		//	{
		//		return m % 2 - n % 2;
		//	});

		//	return numbers;
		//}
	}
}
