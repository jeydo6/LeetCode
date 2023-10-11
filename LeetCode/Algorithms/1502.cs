namespace LeetCode.Algorithms;

// EASY
internal class _1502
{
	public static bool CanMakeArithmeticProgression(int[] arr)
	{
		var minValue = arr[0];
		var maxValue = arr[0];
		for (var i = 1; i < arr.Length; i++)
		{
			if (arr[i] > maxValue)
			{
				maxValue = arr[i];
			}
			if (arr[i] < minValue)
			{
				minValue = arr[i];
			}
		}

		if ((maxValue - minValue) % (arr.Length - 1) != 0)
		{
			return false;
		}

		var diff = (maxValue - minValue) / (arr.Length - 1);
		for (var i = 0; i < arr.Length;)
		{
			if (arr[i] == minValue + i * diff)
			{
				i++;
			}
			else if ((arr[i] - minValue) % diff != 0)
			{
				return false;
			}
			else
			{
				var j = (arr[i] - minValue) / diff;
				if (arr[i] == arr[j])
				{
					return false;
				}

				(arr[i], arr[j]) = (arr[j], arr[i]);
			}
		}

		return true;
	}
}
