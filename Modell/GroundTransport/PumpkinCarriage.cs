using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GroundTransport
{
    public class PumpkinCarriage : GroundTransport
    {
        public PumpkinCarriage(string name, int speed)
            : base(name, speed, speed + 555, 107) { }

        public override int CalculateRaceTime(int distance)
        {
            return this.TimeBeforeRest + this.TimeForRest + distance / this.Speed;
        }
    }
}
