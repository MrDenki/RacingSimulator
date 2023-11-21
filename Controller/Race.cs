using Model;
using Model.AirTransport;
using Model.GroundTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Controller
{
    public class Race
    {
        public List<Track> Races { get; set; }

        public Race()
        {
            Races = new List<Track>();
        }

        public void AddTrack(int distance, string typeOfRace)
        {
            Track track = new Track(distance, typeOfRace);
            Races.Add(track);
        }

        public void PrintTracks()
        {
            int i = 1;
            foreach (var item in Races)
            {
                Console.WriteLine($"{i} - {item.TypeOfRace}\t-\t{item.Distance}");
                i++;
            }
        }

        public Dictionary<int, string> cars = new Dictionary<int, string>()
        {
            { 1, "Ступня бабы Яги"},
            { 2, "Сапоги-скороходы"},
            { 3, "Карета-тыква"},
            { 4, "Избушка на курьих ножках"},
            { 5, "Кентавр"},
            { 6, "Метла"},
            { 7, "Ковер-самолет"},
            { 8, "Летучий корабль"}
        };



        public void PrintCars()
        {
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key}\t-\t{item.Value}");
            }
        }

        public List<Transport> participants = new List<Transport>();

        public void AddTransoprts(int value, string name)
        {
            Transport transport;
            Random random = new Random();

            switch (value)
            {
                case 1:
                    transport = new BabaYagaMortar(name, random.Next(50, 100));
                    break;
                case 2:
                    transport = new SpeedingBoots(name, random.Next(20, 70));
                    break;
                case 3:
                    transport = new PumpkinCarriage(name, random.Next(60, 120));
                    break;
                case 4:
                    transport = new HutOnChickenLegs(name, random.Next(100, 200));
                    break;
                case 5:
                    transport = new Centaur(name, random.Next(20, 50));
                    break;
                case 6:
                    transport = new Broom(name, random.Next(70, 140));
                    break;
                case 7:
                    transport = new FlyingCarpet(name, random.Next(100, 200));
                    break;
                case 8:
                    transport = new FlyingShip(name, random.Next(30, 110));
                    break;
                default:
                    transport = new SpeedingBoots(name, random.Next(20, 70));
                    break;
            }
            participants.Add(transport);
        }

        public void AddRandomTransport(int value)
        {
            Random random = new Random();
            int count = random.Next(1, 20);
            for (int i = 1; i <= count; i++)
            {
                switch (value)
                {
                    case 1:
                        AddTransoprts(random.Next(1, 5), $"Соперник № {i}");
                        break;
                    case 2:
                        AddTransoprts(random.Next(6, 8), $"Соперник № {i}");
                        break;
                    case 3:
                        AddTransoprts(random.Next(1, 8), $"Соперник № {i}");
                        break;
                }
            }
        }

        public void PrintOpennents()
        {
            Console.WriteLine($"Имя \t\t|\tСкорость");
            foreach (var item in participants)
            {
                Console.WriteLine($"{item.Name}\t|\t{item.Speed}");
            }
        }

        public void StartRace(int typeOfRace)
        {
            List<Transport> groudTransport = participants.Where(item => !(item is GroundTransport)).ToList();
            List<Transport> airTransport = participants.Where(item => !(item is AirTransport)).ToList();

            if (typeOfRace == 1 && groudTransport.Count() != 0) Environment.Exit(1);
            else if (typeOfRace == 2 && airTransport.Count() != 0) Environment.Exit(1);

            Transport winner = null;
            int bestTime = int.MaxValue;
            int distance = Races[typeOfRace - 1].Distance;

            foreach (var transport in participants)
            {
                int time = transport.CalculateRaceTime(distance);
                if (time < bestTime)
                {
                    bestTime = time;
                    winner = transport;
                }
            }

            Console.WriteLine($"Чемпион - {winner.Name}, с результатом - {bestTime} секунд!");
        }
    }
}
