namespace LeetCode.Algorithms;

// MEDIUM
internal class _393
{
	public static bool ValidUtf8(int[] data)
	{
		var numberOfBytesToProcess = 0;

		var mask1 = 1 << 7;
		var mask2 = 1 << 6;

		for (var i = 0; i < data.Length; i++)
		{
			if (numberOfBytesToProcess == 0)
			{
				var mask = 1 << 7;
				while ((mask & data[i]) != 0)
				{
					numberOfBytesToProcess += 1;
					mask >>= 1;
				}

				if (numberOfBytesToProcess == 0)
				{
					continue;
				}

				if (numberOfBytesToProcess > 4 || numberOfBytesToProcess == 1)
				{
					return false;
				}
			}
			else
			{
				if (!((data[i] & mask1) != 0 && (mask2 & data[i]) == 0))
				{
					return false;
				}
			}
			numberOfBytesToProcess -= 1;
		}

		return numberOfBytesToProcess == 0;
	}
}
