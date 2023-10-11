using System.Text;

namespace LeetCode.Algorithms
{
	internal class _1108
	{
		public static string DefangIPaddr(string address)
		{
			var sb = new StringBuilder(address, 24);

			sb.Replace(".", "[.]");

			return sb.ToString();
		}
	}
}