using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _2353
{
    public class FoodRatings
    {
        private readonly IDictionary<string, int> _foodRatings = new Dictionary<string, int>();
        private readonly IDictionary<string, string> _foodCuisines = new Dictionary<string, string>();
        private readonly IDictionary<string, SortedSet<(int Rating, string Name)>> _cuisineFoods = new Dictionary<string, SortedSet<(int Rating, string Name)>>();

        private static readonly IComparer<(int Rating, string Name)> _cuisineFoodsComparer = Comparer<(int Rating, string Name)>.Create((a, b) =>
        {
            var compareByRating = a.Rating - b.Rating;
            if (compareByRating != 0)
            {
                return compareByRating;
            }

            return string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase);
        });

        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            for (var i = 0; i < foods.Length; i++)
            {
                _foodRatings[foods[i]] = ratings[i];
                _foodCuisines[foods[i]] = cuisines[i];

                if (!_cuisineFoods.ContainsKey(cuisines[i]))
                {
                    _cuisineFoods[cuisines[i]] = new SortedSet<(int Rating, string Name)>(_cuisineFoodsComparer);
                }
                _cuisineFoods[cuisines[i]].Add((ratings[i], foods[i]));
            }
        }

        public void ChangeRating(string food, int newRating)
        {
            var cuisineSet = _cuisineFoods[_foodCuisines[food]];
            cuisineSet.Remove((_foodRatings[food], food));

            _foodRatings[food] = newRating;
            cuisineSet.Add((newRating, food));
        }

        public string HighestRated(string cuisine)
        {
            var (_, name) = _cuisineFoods[cuisine].Max;
            return name;
        }
    }
}