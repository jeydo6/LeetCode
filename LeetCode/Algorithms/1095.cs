namespace LeetCode.Algorithms;

// HARD
internal class _1095
{
	public abstract class MountainArray
	{
		public abstract int Get(int index);
		public abstract int Length();
	}

	public static int FindInMountainArray(int target, MountainArray mountainArr)
	{
		var length = mountainArr.Length();

		var lo = 1;
		var hi = length - 2;
		while (lo != hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (mountainArr.Get(mid) < mountainArr.Get(mid + 1))
			{
				lo = mid + 1;
			}
			else
			{
				hi = mid;
			}
		}

		var peakIndex = lo;

		lo = 0;
		hi = peakIndex;
		while (lo != hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (mountainArr.Get(mid) < target)
			{
				lo = mid + 1;
			}
			else
			{
				hi = mid;
			}
		}

		if (mountainArr.Get(lo) == target)
		{
			return lo;
		}

		lo = peakIndex + 1;
		hi = length - 1;
		while (lo != hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (mountainArr.Get(mid) > target)
			{
				lo = mid + 1;
			}
			else
			{
				hi = mid;
			}
		}

		if (mountainArr.Get(lo) == target)
		{
			return lo;
		}

		return -1;
	}
}