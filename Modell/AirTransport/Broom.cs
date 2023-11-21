using System;
using System.Collections.Generic;
using System.Text;

namespace Model.AirTransport
{
    public class Broom : AirTransport
    {
        public Broom(string name, int speed)
            : base(name, speed, speed * speed) { }


        public override int CalculateRaceTime(int distance)
        {
            return this.AccelerationCoefficient * distance / this.Speed;
        }
    }

}
