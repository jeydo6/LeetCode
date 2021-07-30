using Newtonsoft.Json;
using System;

namespace LeetCode
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				""
			);
			Console.WriteLine(json);
		}
	}
}
