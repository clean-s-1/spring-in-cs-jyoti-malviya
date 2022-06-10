using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            var stats = new Stats();
            if (numbers.Count == 0)
            {
                stats.average = Double.NaN;
                stats.min = Double.NaN;
                stats.max = Double.NaN;
            }
            else {
                stats.average = Queryable.Average(numbers.AsQueryable());
                stats.min = Queryable.Min(numbers.AsQueryable());
                stats.max = Queryable.Max(numbers.AsQueryable());
            }

            average = stats.average;
            min = stats.min;
            max = stats.max;

            return stats;
        }

        public double average { get; set; }
        public double min { get; set; }
        public double max { get; set; }
    }
}
