namespace LeetCode.Algorithms
{
	class _1460
	{
		public static bool CanBeEqual(int[] target, int[] arr)
		{
			Array.Sort(target);
			Array.Sort(arr);

			for (var i = 0; i < target.Length; i++)
			{
				if (target[i] != arr[i])
				{
					return false;
				}
			}
			return true;
		}
	}
}