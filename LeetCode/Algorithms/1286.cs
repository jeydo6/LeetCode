using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1286
	{
		public static void GetResult()
		{
			var obj = new CombinationIterator("abc", 2);
			var param_1 = obj.Next();
			var param_2 = obj.HasNext();
			var param_3 = obj.Next();
			var param_4 = obj.HasNext();
			var param_5 = obj.Next();
			var param_6 = obj.HasNext();
		}

		private class CombinationIterator
		{
			private readonly ISet<string> _set;
			private readonly IEnumerator<string> _enumerator;

			private readonly string _last;

			public CombinationIterator(string characters, int combinationLength)
			{
				_set = GetCombinations(characters, combinationLength);
				_enumerator = _set.GetEnumerator();
				while (_enumerator.MoveNext())
				{
					_last = _enumerator.Current;
				}
				_enumerator.Reset();
			}

			public string Next()
			{
				return _enumerator.Current != _last && _enumerator.MoveNext() ? _enumerator.Current : "";
			}

			public bool HasNext()
			{
				return _enumerator.Current != _last;
			}

			private static ISet<string> GetCombinations(string characters, int combinationLength)
			{
				var result = new SortedSet<string>();
				for (var i = 1; i < (1 << characters.Length); i++)
				{
					var combination = "";

					var j = 0;
					var number = i;
					while (number > 0)
					{
						if ((number & 1) > 0)
						{
							combination += characters[j];
						}
						j++;
						number >>= 1;
					}
					if (combination.Length == combinationLength)
					{
						result.Add(combination);
					}
				}
				return result;
			}
		}
	}
}
