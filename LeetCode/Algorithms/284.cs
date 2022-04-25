using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _284
	{
		public class PeekingIterator
		{
			private readonly IEnumerator<int> _iterator;

			private bool _hasNext;

			public PeekingIterator(IEnumerator<int> iterator)
			{
				_iterator = iterator;
				_hasNext = true;
			}

			public int Peek()
			{
				return _iterator.Current;
			}

			public int Next()
			{
				var result = _iterator.Current;

				_hasNext = _iterator.MoveNext();

				return result;
			}

			public bool HasNext()
			{
				return _hasNext;
			}
		}
	}
}
