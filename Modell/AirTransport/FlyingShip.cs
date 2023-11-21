using System;
using System.Collections.Generic;
using System.Text;

namespace Model.AirTransport
{
    public class FlyingShip : AirTransport
    {
        public FlyingShip(string name, int speed) 
            : base (name, speed, speed) { }

        public override int CalculateRaceTime(int distance)
        {
            return this.AccelerationCoefficient * distance / this.Speed;
        }
    }
}
