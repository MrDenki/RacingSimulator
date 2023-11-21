using System;

namespace Model
{
    public abstract class Transport
    {
        public string Name { get; set; }  
        public int Speed { get; set; }

        public Transport(string name, int speed)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public abstract int CalculateRaceTime(int distance);
    }
}
