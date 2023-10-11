namespace LeetCode.Algorithms
{
	internal class _1185
	{
		public static string DayOfTheWeek(int day, int month, int year)
		{
			var daysOfWeek = new string[7]
			{
				"Friday",
				"Saturday",
				"Sunday",
				"Monday",
				"Tuesday",
				"Wednesday",
				"Thursday"
			};
			var daysOfMonth = new int[12]
			{
				31,
				year % 4 == 0 ? 29 : 28,
				31,
				30,
				31,
				30,
				31,
				31,
				30,
				31,
				30,
				31
			};

			var result = day - 1;
			for (var i = 0; i < month - 1; i++)
			{
				result += daysOfMonth[i];
			}
			for (var i = 1971; i < year; i++)
			{
				if (i % 4 == 0)
				{
					result += 366;
				}
				else
				{
					result += 365;
				}
			}
			return daysOfWeek[result % daysOfWeek.Length];
		}
	}
}
