using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GroundTransport
{
    public class SpeedingBoots : GroundTransport
    {
        public SpeedingBoots(string name, int speed)
            : base(name, speed, 500, 60) { }

        public override int CalculateRaceTime(int distance)
        {
            int timeBeforeRest = 5;
            int timeForRest = 5;
            return timeBeforeRest + timeForRest + distance / this.Speed;
        }
    }
}
