namespace LeetCode.Algorithms
{
	class _1299
	{
		public static int[] ReplaceElements(int[] array)
		{
			var end = array.Length - 1;
			var max = array[^1];

			for (var i = array.Length - 2; i >= 0; i--)
			{
				array[end] = array[i];
				array[i] = max;

				if (array[end] > max)
				{
					max = array[end];
				}
			}

			array[^1] = -1;
			return array;
		}
	}
}
