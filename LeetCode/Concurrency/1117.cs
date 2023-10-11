using System;
using System.Threading;

namespace LeetCode.Concurrency
{
	// MEDIUM
	internal class _1117
	{
		public class H2O
		{
			private readonly Semaphore _hydrogen;
			private readonly Semaphore _oxygen;
			private readonly Mutex _mutex;

			private int _count;

			public H2O()
			{
				_hydrogen = new Semaphore(2, 2);
				_oxygen = new Semaphore(0, 1);

				_mutex = new Mutex();

				_count = 0;
			}

			public void Hydrogen(Action releaseHydrogen)
			{
				_hydrogen.WaitOne();

				releaseHydrogen();

				_mutex.WaitOne();
				if (++_count % 2 == 0)
				{
					_oxygen.Release();
				}
				_mutex.ReleaseMutex();
			}

			public void Oxygen(Action releaseOxygen)
			{
				_oxygen.WaitOne();

				releaseOxygen();

				_hydrogen.Release(2);
			}
		}
	}
}
