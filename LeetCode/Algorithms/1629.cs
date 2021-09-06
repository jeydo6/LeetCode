namespace LeetCode.Algorithms
{
	class _1629
	{
		public static char SlowestKey(int[] releaseTimes, string keysPressed)
		{
			var keyPressed = keysPressed[0];

			var longestDuration = releaseTimes[0];
			for (var i = 1; i < releaseTimes.Length; i++)
			{
				var duration = releaseTimes[i] - releaseTimes[i - 1];

				if (duration > longestDuration || (duration == longestDuration && keysPressed[i] > keyPressed))
				{
					longestDuration = duration;
					keyPressed = keysPressed[i];
				}
			}

			return keyPressed;
		}
	}
}
