using System;
using System.Threading;

namespace LeetCode.Concurrency
{
	internal class _1114
	{
		public class Foo
		{
			private readonly Semaphore _first;
			private readonly Semaphore _second;
			private readonly Semaphore _third;

			public Foo()
			{
				_first = new Semaphore(1, 1);
				_second = new Semaphore(0, 1);
				_third = new Semaphore(0, 1);
			}

			public void First(Action printFirst)
			{
				_first.WaitOne();
				printFirst();
				_second.Release();
			}

			public void Second(Action printSecond)
			{
				_second.WaitOne();
				printSecond();
				_third.Release();
			}

			public void Third(Action printThird)
			{
				_third.WaitOne();
				printThird();
				_first.Release();
			}
		}
	}
}
