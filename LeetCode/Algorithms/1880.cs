namespace LeetCode.Algorithms
{
	class _1880
	{
		public static bool IsSumEqual(string firstWord, string secondWord, string targetWord)
		{
			var firstSum = 0;
			var firstBase = 1;
			for (var i = 0; i < firstWord.Length; i++)
			{
				firstSum += (firstWord[^(i + 1)] - 'a') * firstBase;
				firstBase *= 10;
			}

			var secondSum = 0;
			var secondBase = 1;
			for (var i = 0; i < secondWord.Length; i++)
			{
				secondSum += (secondWord[^(i + 1)] - 'a') * secondBase;
				secondBase *= 10;
			}

			var targetSum = 0;
			var targetBase = 1;
			for (var i = 0; i < targetWord.Length; i++)
			{
				targetSum += (targetWord[^(i + 1)] - 'a') * targetBase;
				targetBase *= 10;
			}

			return (firstSum + secondSum) == targetSum;
		}
	}
}
