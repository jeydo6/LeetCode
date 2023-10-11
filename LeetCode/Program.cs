using System;
using System.Text.Json;

namespace LeetCode
{
	internal static class Program
	{
		private static void Main()
		{
			var result = "";
			WriteLine(result);
		}

		private static void WriteLine(object result)
		{
			var json = JsonSerializer.Serialize(result, new JsonSerializerOptions
			{
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
				WriteIndented = true
			});
			Console.WriteLine(json);
		}
	}
}
