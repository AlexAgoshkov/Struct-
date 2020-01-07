using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    struct Train
    {
        string _nameOfCity;
        int _trainNumber;
        double _timeStart;

        public Train(string nameOfCity, int trainNumber, double timeStart)
        {
            _nameOfCity = nameOfCity;
            _trainNumber = trainNumber;
            _timeStart = timeStart;
        }

        public void Display()
        {
            Console.WriteLine($"{_nameOfCity} {_trainNumber} {_timeStart}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];

            string name;
            int train;
            double time;

            for (int i = 0; i < trains.Length; i++)
            {
                name = Console.ReadLine();
                train = Convert.ToInt32(Console.ReadLine());
                time = Convert.ToDouble(Console.ReadLine());

                trains[i] = new Train(name, train, time);
            }

            foreach (var item in trains)
            {
                item.Display();
            }

            Console.ReadKey();
        }
    }
}
