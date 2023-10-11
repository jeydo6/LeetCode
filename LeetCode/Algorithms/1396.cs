using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1396
	{
		public class UndergroundSystem
		{
			private readonly IDictionary<string, (double TotalTime, double TotalTrips)> _journeyData;
			private readonly IDictionary<int, (string Station, int Time)> _checkInData;

			public UndergroundSystem()
			{
				_journeyData = new Dictionary<string, (double TotalTime, double TotalTrips)>();
				_checkInData = new Dictionary<int, (string StationName, int CheckInTime)>();
			}

			public void CheckIn(int id, string stationName, int t)
			{
				_checkInData[id] = (stationName, t);
			}

			public void CheckOut(int id, string stationName, int t)
			{
				(var startStation, var checkInTime) = _checkInData[id];
				var tripTime = t - checkInTime;

				var routeKey = GetRouteKey(startStation, stationName);
				(var totalTime, var totalTrips) = _journeyData.ContainsKey(routeKey) ? _journeyData[routeKey] : (0.0, 0.0);

				_journeyData[routeKey] = (totalTime + tripTime, ++totalTrips);
				_checkInData.Remove(id);
			}

			public double GetAverageTime(string startStation, string endStation)
			{
				var routeKey = GetRouteKey(startStation, endStation);
				(var totalTime, var totalTrips) = _journeyData[routeKey];
				return totalTime / totalTrips;
			}

			private static string GetRouteKey(string startStation, string endStation)
			{
				return $"{startStation}->{endStation}";
			}
		}
	}
}
