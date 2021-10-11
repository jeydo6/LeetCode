using Newtonsoft.Json;
using System;

namespace LeetCode
{
	internal static class Program
	{
		private static void Main()
		{
			var json = JsonConvert.SerializeObject(
				""
			);
			Console.WriteLine(json);
		}
	}
}
