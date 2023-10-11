using System.Collections.Generic;

namespace Leetcode.Algorithms
{
	internal class _811
	{
		public static IList<string> SubdomainVisits(string[] cpdomains)
		{
			var result = new List<string>();

			var cpsubdomains = new Dictionary<string, int>();
			foreach (var cpdomain in cpdomains)
			{
				var spacePos = cpdomain.IndexOf(' ');
				var number = int.Parse(cpdomain[..spacePos]);
				var domain = cpdomain[(spacePos + 1)..];

				var parts = domain.Split('.');

				var subdomain = "";
				for (var i = parts.Length - 1; i >= 0; i--)
				{
					if (subdomain.Length == 0)
					{
						subdomain = parts[i];
					}
					else
					{
						subdomain = parts[i] + "." + subdomain;
					}

					if (!cpsubdomains.ContainsKey(subdomain))
					{
						cpsubdomains[subdomain] = number;
					}
					else
					{
						cpsubdomains[subdomain] += number;
					}
				}
			}

			foreach (var cpsubdomain in cpsubdomains)
			{
				result.Add(cpsubdomain.Value + " " + cpsubdomain.Key);
			}

			return result;
		}
	}
}
