using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GroundTransport
{
    public class Centaur : GroundTransport
    {
        public Centaur(string name, int speed)
            : base(name, speed, speed * speed * 3, 302) { }

        public override int CalculateRaceTime(int distance)
        {
            return this.TimeBeforeRest + this.TimeForRest + distance / this.Speed;
        }
    }
}
