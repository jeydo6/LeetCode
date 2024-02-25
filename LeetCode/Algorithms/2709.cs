namespace LeetCode.Algorithms;

// HARD
internal sealed class _2709
{
	public static bool CanTraverseAllPairs(int[] nums)
	{
		if (nums.Length == 1)
		{
			return true;
		}

		const int max = 100000;
		var has = new bool[max + 1];
		for (var i = 0; i < nums.Length; i++)
		{
			has[nums[i]] = true;
		}

		if (has[1])
		{
			return false;
		}

		var sieve = new int[max + 1];
		for (var d = 2; d <= max; d++)
		{
			if (sieve[d] == 0)
			{
				for (var v = d; v <= max; v += d)
				{
					sieve[v] = d;
				}
			}
		}

		var union = new Dsu(2 * max + 1);
		for (var i = 0; i < nums.Length; i++)
		{
			var val = nums[i];
			while (val > 1)
			{
				var prime = sieve[val];
				var root = prime + max;
				if (union.Find(root) != union.Find(nums[i]))
				{
					union.Merge(root, nums[i]);
				}

				while (val % prime == 0)
				{
					val /= prime;
				}
			}
		}

		var result = 0;
		for (var i = 2; i <= max; i++)
		{
			if (has[i] && union.Find(i) == i)
			{
				result++;
			}
		}

		return result == 1;
	}

	private class Dsu
	{
		private readonly int[] _dsu;
		private readonly int[] _size;

		public Dsu(int n)
		{
			_dsu = new int[n + 1];
			_size = new int[n + 1];

			for (var i = 0; i < n + 1; i++)
			{
				_dsu[i] = i;
				_size[i] = 1;
			}
		}

		public int Find(int x)
		{
			return _dsu[x] == x ? x : _dsu[x] = Find(_dsu[x]);
		}

		public void Merge(int x, int y)
		{
			var fx = Find(x);
			var fy = Find(y);

			if (fx == fy)
			{
				return;
			}

			if (_size[fx] > _size[fy])
			{
				(fx, fy) = (fy, fx);
			}

			_dsu[fx] = fy;
			_size[fy] += _size[fx];
		}
	}
}