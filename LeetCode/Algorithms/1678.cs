namespace LeetCode.Algorithms
{
	class _1678
	{
		public static string Interpret(string command)
		{
			command = command.Replace("()", "o");
			command = command.Replace("(al)", "al");
			return command;
		}
	}
}
