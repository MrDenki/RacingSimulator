using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GroundTransport
{
    public class HutOnChickenLegs : GroundTransport
    {
        public HutOnChickenLegs(string name, int speed)
            : base(name, speed, 609, 0) { }

        public override int CalculateRaceTime(int distance)
        {
            return this.TimeBeforeRest + this.TimeForRest + distance / this.Speed;
        }
    }
}
