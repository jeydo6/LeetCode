using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal static class _1845
{
    public class SeatManager
    {
        private readonly PriorityQueue<int, int> _seats = new PriorityQueue<int, int>();
        private int _marker = 1;

        public SeatManager(int n) { }

        public int Reserve()
        {
            if (_seats.Count > 0)
            {
                return _seats.Dequeue();
            }

            return _marker++;
        }

        public void Unreserve(int seatNumber)
        {
            _seats.Enqueue(seatNumber, seatNumber);
        }
    }
}