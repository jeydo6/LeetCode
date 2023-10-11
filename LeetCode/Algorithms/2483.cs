namespace LeetCode.Algorithms;

// MEDIUM
internal class _2483
{
	public static int BestClosingTime(string customers)
	{
		var result = 0;

		var minPenalty = 0;
		var currentPenalty = 0;

		for (var i = 0; i < customers.Length; i++)
		{
			if (customers[i] == 'Y')
			{
				currentPenalty--;
			}
			else
			{
				currentPenalty++;
			}

			if (currentPenalty < minPenalty)
			{
				result = i + 1;
				minPenalty = currentPenalty;
			}
		}

		return result;
	}
}