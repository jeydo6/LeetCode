using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _1656
	{
		public class OrderedStream
		{
			private readonly string[] _inserted;

			private int _pointer;

			public OrderedStream(int n)
			{
				_inserted = new string[n];
				_pointer = 0;
			}

			public IList<string> Insert(int key, string value)
			{
				_inserted[key - 1] = value;

				var result = new List<string>();
				while (_pointer < _inserted.Length)
				{
					if (_inserted[_pointer] != null)
					{
						result.Add(_inserted[_pointer]);
						_pointer++;
					}
					else
					{
						break;
					}
				}
				return result;
			}
		}
	}
}
