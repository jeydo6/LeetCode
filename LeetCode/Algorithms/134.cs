namespace LeetCode.Algorithms;

// MEDIUM
internal class _134
{
	public static int CanCompleteCircuit(int[] gas, int[] cost)
	{
		var sumGas = 0;
		var sumCost = 0;
		var start = 0;
		var tank = 0;
		for (var i = 0; i < gas.Length; i++)
		{
			sumGas += gas[i];
			sumCost += cost[i];
			tank += gas[i] - cost[i];
			if (tank < 0)
			{
				start = i + 1;
				tank = 0;
			}
		}

		return sumGas < sumCost ? -1 : start;
	}
}
