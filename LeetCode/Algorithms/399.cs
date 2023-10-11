using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _399
	{
		public static double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
		{
			var gidWeights = new Dictionary<string, (string Gid, double Weight)>();

			for (var i = 0; i < equations.Count; i++)
			{
				var equation = equations[i];
				var dividend = equation[0];
				var divisor = equation[1];
				var quotient = values[i];

				Union(gidWeights, dividend, divisor, quotient);
			}

			var results = new double[queries.Count];
			for (var i = 0; i < queries.Count; i++)
			{
				var query = queries[i];
				var dividend = query[0];
				var divisor = query[1];

				if (!gidWeights.ContainsKey(dividend) || !gidWeights.ContainsKey(divisor))
				{
					results[i] = -1.0;
				}
				else
				{
					(var dividendGid, var dividendWeight) = Find(gidWeights, dividend);
					(var divisorGid, var divisorWeight) = Find(gidWeights, divisor);

					if (dividendGid != divisorGid)
					{
						results[i] = -1.0;
					}
					else
					{
						results[i] = dividendWeight / divisorWeight;
					}
				}
			}

			return results;
		}

		private static (string Gid, double Weight) Find(IDictionary<string, (string Gid, double Weight)> gidWeights, string nodeId)
		{
			if (!gidWeights.ContainsKey(nodeId))
			{
				gidWeights[nodeId] = (nodeId, 1.0);
			}

			var entry = gidWeights[nodeId];
			if (entry.Gid != nodeId)
			{
				var newEntry = Find(gidWeights, entry.Gid);
				gidWeights[nodeId] = (newEntry.Gid, entry.Weight * newEntry.Weight);
			}

			return gidWeights[nodeId];
		}

		private static void Union(IDictionary<string, (string Gid, double Weight)> gidWeights, string dividend, string divisor, double value)
		{
			(var dividendGid, var dividendWeight) = Find(gidWeights, dividend);
			(var divisorGid, var divisorWeight) = Find(gidWeights, divisor);

			if (dividendGid != divisorGid)
			{
				gidWeights[dividendGid] = (divisorGid, divisorWeight * value / dividendWeight);
			}
		}
	}
}
