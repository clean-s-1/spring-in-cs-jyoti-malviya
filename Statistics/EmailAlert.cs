using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class EmailAlert: IAlerter
    {

        public bool emailSent { get; set; }

        public void SetParams(object data)
        {
            emailSent = (bool)data;
        }
    }
}
