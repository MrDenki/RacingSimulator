using System;
using System.Collections.Generic;
using System.Text;

namespace Model.GroundTransport
{
    public class BabaYagaMortar : GroundTransport
    {
        public BabaYagaMortar(string name, int speed) 
            : base(name, speed, speed + 153, 218) { }

        public override int CalculateRaceTime(int distance)
        {
            return this.TimeBeforeRest + this.TimeForRest + distance / this.Speed;
        }
    }
}
