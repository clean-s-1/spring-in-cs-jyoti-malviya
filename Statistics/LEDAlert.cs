using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class LEDAlert : IAlerter
    {
        //public IAlerter ledAlert;

        //public LEDAlert()
        //{
        //    this.ledAlert = new IAlerter();
        //    this.ledAlert.alert = (double)5.2;
        //}

        public Boolean ledGlows { get; set; }

        public void SetParams(object data)
        {
            ledGlows = (bool)data;
        }
    }
}
