using Newtonsoft.Json;
using System;

namespace LeetCode
{
	class Program
	{
		static void Main()
		{
			var json = JsonConvert.SerializeObject(
				_1389.CreateTargetArray(new int[] { 4, 2, 1, 1 }, new int[] { 0, 0, 2, 0 })
			);
			Console.WriteLine(json);
		}
	}
}
