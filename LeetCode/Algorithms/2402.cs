using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal sealed class _2402
{
	private static readonly IComparer<long[]> _longComparer =
		Comparer<long[]>.Create((a, b) => a[0] != b[0] ? a[0].CompareTo(b[0]) : a[1].CompareTo(b[1]));

	private static readonly IComparer<int[]> _intComparer =
		Comparer<int[]>.Create((a, b) => a[0] != b[0] ? a[0].CompareTo(b[0]) : a[1].CompareTo(b[1]));

	public static int MostBooked(int n, int[][] meetings)
	{
		var meetingCount = new int[n];
		var usedRooms = new PriorityQueue<long[], long[]>(_longComparer);
		var unusedRooms = new PriorityQueue<int, int>();

		for (var i = 0; i < n; i++)
		{
			unusedRooms.Enqueue(i, i);
		}

		Array.Sort(meetings, _intComparer);

		for (var i = 0; i < meetings.Length; i++)
		{
			var start = meetings[i][0];
			var end = meetings[i][1];

			while (usedRooms.Count > 0 && usedRooms.Peek()[0] <= start)
			{
				var room = (int)usedRooms.Dequeue()[1];
				unusedRooms.Enqueue(room, room);
			}

			if (unusedRooms.Count > 0)
			{
				var room = unusedRooms.Dequeue();
				var item = new long[] { end, room };
				usedRooms.Enqueue(item, item);
				meetingCount[room]++;
			}
			else
			{
				var roomAvailabilityTime = usedRooms.Peek()[0];
				var room = (int)usedRooms.Dequeue()[1];
				var item = new long[] { roomAvailabilityTime + end - start, room };
				usedRooms.Enqueue(item, item);
				meetingCount[room]++;
			}
		}

		int maxMeetingCount = 0, maxMeetingCountRoom = 0;
		for (var i = 0; i < n; i++)
		{
			if (meetingCount[i] > maxMeetingCount)
			{
				maxMeetingCount = meetingCount[i];
				maxMeetingCountRoom = i;
			}
		}

		return maxMeetingCountRoom;
	}
}