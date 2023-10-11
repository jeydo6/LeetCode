using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _341
	{
#pragma warning disable IDE1006 // Naming Styles
		public interface NestedInteger
		{

			// @return true if this NestedInteger holds a single integer, rather than a nested list.
			bool IsInteger();

			// @return the single integer that this NestedInteger holds, if it holds a single integer
			// Return null if this NestedInteger holds a nested list
			int GetInteger();

			// @return the nested list that this NestedInteger holds, if it holds a nested list
			// Return null if this NestedInteger holds a single integer
			IList<NestedInteger> GetList();
		}

		public class NestedIterator
		{
			private readonly IList<int> _values;
			
			private int _index;

			public NestedIterator(IList<NestedInteger> nestedList)
			{
				_values = new List<int>();
				_index = 0;

				GetValues(nestedList);
			}

			public bool HasNext()
			{
				return _index < _values.Count;
			}

			public int Next()
			{
				return _values[_index++];
			}

			private void GetValues(IList<NestedInteger> nestedList)
			{
				for (var i = 0; i < nestedList.Count; i++)
				{
					if (nestedList[i].IsInteger())
					{
						_values.Add(nestedList[i].GetInteger());
					}
					else
					{
						GetValues(nestedList[i].GetList());
					}
				}
			}
		}
#pragma warning restore IDE1006 // Naming Styles
	}
}
