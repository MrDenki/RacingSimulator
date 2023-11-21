using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Track
    {
        public int Distance { get; set; }
        public string TypeOfRace { get; set; }

        public Track(int distance, string typeOfRace)
        {
            this.Distance = distance;
            this.TypeOfRace = typeOfRace;
        }
    }
}
