using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GroundTransport
{
    public abstract class GroundTransport : Transport
    {
        public int TimeBeforeRest { get; set; }
        public int TimeForRest { get; set; }

        public GroundTransport(string name, int speed, int timeBeforeRest, int timeForRest) 
            : base(name, speed) { }
    }
}
