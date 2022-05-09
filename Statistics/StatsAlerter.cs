using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics
{
    public class StatsAlerter
    {
        private float maxThreshold;
        private IAlerter[] alerters;
        public StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.alerters = alerters;
        }

        public void checkAndAlert(List<float> numbers) {

            var threshold = numbers.Average();
                if (this.maxThreshold > threshold)
                {
                    this.alerters[0].SetParams(true);
                    this.alerters[1].SetParams(true);
                }
        }
    }
}
