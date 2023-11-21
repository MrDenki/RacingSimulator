using Controller;
using System;

namespace RacingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();

            Console.Write("Введите желаемую длину трассы:\t");
            int dist = Convert.ToInt32(Console.ReadLine());

            race.AddTrack(dist, "На земле");
            race.AddTrack(dist, "В воздухе");
            race.AddTrack(dist, "Смешанное");

            race.PrintTracks();

            int value;

            Console.Write("Выберите тип гонки:\t");
            value = Convert.ToInt32(Console.ReadLine());

            string name;
            Console.Write("Как вас зовут:\t");
            name = Console.ReadLine();

            race.AddRandomTransport(value);

            int car;
            race.PrintCars();
            Console.Write("Выберите транспорт:\t");
            switch (value)
            {
                case 1:
                    car = Convert.ToInt32(Console.ReadLine());

                    race.AddTransoprts(car, name);
                    break;
                case 2:
                    car = Convert.ToInt32(Console.ReadLine());
                    race.AddTransoprts(car, name);
                    break;
                case 3:
                    car = Convert.ToInt32(Console.ReadLine());
                    race.AddTransoprts(car, name);
                    break;
            }
            race.PrintOpennents();

            race.StartRace(value);

            Console.ReadKey();
        }
    }
}
