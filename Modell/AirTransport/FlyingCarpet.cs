using System;
using System.Collections.Generic;
using System.Text;

namespace Model.AirTransport
{
    public class FlyingCarpet : AirTransport
    {
        public FlyingCarpet(string name, int speed)
            : base(name, speed, speed / 2) { }

        public override int CalculateRaceTime(int distance)
        {
            return this.AccelerationCoefficient * distance / this.Speed;
        }
    }
}
