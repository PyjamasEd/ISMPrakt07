using System;

namespace ISMPrakt07
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        Airplane[] ReadAirplaneArray(int n)
        {
            string startCity, finishCity;
            int Day, Month, Year, Hour, Minute;
            Airplane[] airplanes = new Airplane[n];
            for (int i = 0; i < airplanes.Length; i++)
            {
                Console.WriteLine($"AirPlane №{i+1} of {airplanes.Length}");

                Console.Write("StartCity:");
                startCity = Console.ReadLine();

                Console.Write("FinishCity:");
                finishCity = Console.ReadLine();

                Console.WriteLine("StartDate-\\//");

                Console.Write("Day:");
                Day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Month:");
                Month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Year:");
                Year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Hour:");
                Hour = Convert.ToInt32(Console.ReadLine());

                Console.Write("Minute:");
                Minute = Convert.ToInt32(Console.ReadLine());

                airplanes[i] = new Airplane(startCity, finishCity, new Date(Day, Month, Year, Hour, Minute), new Date(Day, Month, Year, Hour, Minute));

                Console.WriteLine("FinishDate-\\//");

                Console.Write("Day:");
                Day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Month:");
                Month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Year:");
                Year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Hour:");
                Hour = Convert.ToInt32(Console.ReadLine());

                Console.Write("Minute:");
                Minute = Convert.ToInt32(Console.ReadLine());

                airplanes[i].FinishDate = new Date(Day, Month, Year, Hour, Minute);
            }
            return airplanes;
        }
        void PrintAirplane(Airplane airplane)
        {
            Console.WriteLine($"StartCity: {airplane.StartCity}");
            Console.WriteLine($"FinishCity: {airplane.FinishCity}");
            Console.WriteLine($"StartDate: {airplane.StartDate.Day}.{airplane.StartDate.Month}.{airplane.StartDate.Year}|{airplane.StartDate.Hours}:{airplane.StartDate.Minutes}");
            Console.WriteLine($"FinishDate: {airplane.FinishDate.Day}.{airplane.FinishDate.Month}.{airplane.FinishDate.Year}|{airplane.FinishDate.Hours}:{airplane.FinishDate.Minutes}");
        }
        void PrintAirplanes(Airplane[] airplanes)
        {
            for (int i = 0; i < airplanes.Length; i++)
            {
                Console.WriteLine($"StartCity: {airplanes[i].StartCity}");
                Console.WriteLine($"FinishCity: {airplanes[i].FinishCity}");
                Console.WriteLine($"StartDate: {airplanes[i].StartDate.Day}.{airplanes[i].StartDate.Month}.{airplanes[i].StartDate.Year}|{airplanes[i].StartDate.Hours}:{airplanes[i].StartDate.Minutes}");
                Console.WriteLine($"FinishDate: {airplanes[i].FinishDate.Day}.{airplanes[i].FinishDate.Month}.{airplanes[i].FinishDate.Year}|{airplanes[i].FinishDate.Hours}:{airplanes[i].FinishDate.Minutes}");
            }
        }
        void GetAirplaneInfo(Airplane[] airplanes, out int shortTime, out int longTime)
        {
            shortTime = 9999;
            longTime = 0;
            for (int i = 0; i < airplanes.Length; i++)
            {
                if (shortTime > airplanes[i].GetTotalTime())
                {
                    shortTime = airplanes[i].GetTotalTime();
                }
                if (longTime < airplanes[i].GetTotalTime())
                {
                    longTime = airplanes[i].GetTotalTime();
                }
            }
        }
        void SortAirplanesByDate(Airplane[] airplanes)
        {
            int[] Tmp = new int[airplanes.Length];
            for (int i = 0; i < airplanes.Length; i++)
                Tmp[i] = airplanes[i].StartDate.Month + airplanes[i].StartDate.Day;
            Array.Sort(Tmp, airplanes);
            Array.Reverse(airplanes);
            PrintAirplanes(airplanes);
        }

        void SortAirplanesByTotalTime(Airplane[] airplanes)
        {
            double[] Tmp = new double[airplanes.Length];
            for (int i = 0; i < airplanes.Length; i++)
                Tmp[i] = airplanes[i].GetTotalTime();
            Array.Sort(Tmp, airplanes);
            PrintAirplanes(airplanes);
        }
    }
}
