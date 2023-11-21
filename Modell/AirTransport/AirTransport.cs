using System;
using System.Collections.Generic;
using System.Text;

namespace Model.AirTransport
{
    public abstract class AirTransport : Transport
    {
        public int AccelerationCoefficient { get; set; }

        public AirTransport(string name, int speed, int acceleration) : base(name, speed) 
        {
            this.AccelerationCoefficient = acceleration;
        }
    }
}
