using System;
using System.Threading;

namespace LeetCode.Concurrency
{
	internal class _1195
	{
		public class FizzBuzz : IDisposable
		{
			private readonly int _number;
			private readonly Barrier _barrier;
			private bool disposedValue;

			public FizzBuzz(int number)
			{
				_number = number;
				_barrier = new Barrier(4);
			}

			public void Fizz(Action printFizz)
			{
				for (var i = 1; i <= _number; i++)
				{
					if (i % 3 == 0 && i % 5 != 0)
					{
						printFizz();
					}
					_barrier.SignalAndWait();
				}
			}

			public void Buzz(Action printBuzz)
			{
				for (var i = 1; i <= _number; i++)
				{
					if (i % 3 != 0 && i % 5 == 0)
					{
						printBuzz();
					}
					_barrier.SignalAndWait();
				}
			}

			public void Fizzbuzz(Action printFizzBuzz)
			{
				for (var i = 1; i <= _number; i++)
				{
					if (i % 3 == 0 && i % 5 == 0)
					{
						printFizzBuzz();
					}
					_barrier.SignalAndWait();
				}
			}

			public void Number(Action<int> printNumber)
			{
				for (var i = 1; i <= _number; i++)
				{
					if (i % 3 != 0 && i % 5 != 0)
					{
						printNumber(i);
					}
					_barrier.SignalAndWait();
				}
			}

			protected virtual void Dispose(bool disposing)
			{
				if (!disposedValue)
				{
					if (disposing)
					{
						_barrier.Dispose();
					}
					disposedValue = true;
				}
			}

			public void Dispose()
			{
				Dispose(disposing: true);
				GC.SuppressFinalize(this);
			}
		}
	}
}
