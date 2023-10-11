namespace LeetCode.Algorithms;

// EASY
internal class _1603
{
	public class ParkingSystem
	{
		private readonly int[] _slots;

		public ParkingSystem(int big, int medium, int small)
		{
			_slots = new int[3] { big, medium, small };
		}

		public bool AddCar(int carType)
		{
			if (_slots[carType - 1] > 0)
			{
				_slots[carType - 1]--;

				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
