using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _895
	{
		public static void GetResult()
		{
			var obj = new FreqStack();
			obj.Push(0);
			_ = obj.Pop();
		}

		public class FreqStack
		{
			private readonly IDictionary<int, int> _frequencies = new Dictionary<int, int>();
			private readonly IDictionary<int, Stack<int>> _groups = new Dictionary<int, Stack<int>>();

			private int maxFrequency = 0;

			public void Push(int val)
			{
				if (!_frequencies.ContainsKey(val))
				{
					_frequencies[val] = 0;
				}
				var frequency = _frequencies[val]++;
				if (frequency > maxFrequency)
				{
					maxFrequency = frequency;
				}

				if (!_groups.ContainsKey(frequency))
				{
					_groups[frequency] = new Stack<int>();
				}
				_groups[frequency].Push(val);
			}

			public int Pop()
			{
				var val = _groups[maxFrequency].Pop();
				_frequencies[val]--;
				if (_groups[maxFrequency].Count == 0)
				{
					maxFrequency--;
				}
				return val;
			}
		}
	}
}
