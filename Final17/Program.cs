using System;
using System.Collections.Generic;

namespace Final17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature?: ");
            int currentTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the windspeed?: ");
            double windSpeed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the percentage chance of rain? (enter only the number): ");
            int rainChancePercentage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is the forecast? (sunny, windy, snowy): ");
            string forecast = Console.ReadLine();
            foreach (var item in BePrepared(currentTemp,windSpeed,rainChancePercentage,forecast))
            {
                Console.WriteLine(item);
            }
        }
        public static List<string> BePrepared(int currentTemp, double windSpeed, int rainChancePercentage, string forecast)
        {
            var clothes = new List<string>();
            if(currentTemp <= 32)
            {
                clothes.Add("Put on a heavy coat");
            }
            if(currentTemp > 32 && currentTemp < 40)
            {
                clothes.Add("Wear your mittens");
            }
            if (currentTemp > 40 && currentTemp < 70)
            {
                clothes.Add("Dig out your long sleeve shirt");
            }
            if(currentTemp > 70)
            {
                clothes.Add("A short sleeve shirt will be fine");
            }
            if (currentTemp > 110)
            {
                clothes.Add("Move out of Texas");
            }
            if (windSpeed < 10.8)
            {
                clothes.Add("Nothing extra");
            }
            if (windSpeed > 10.8 && windSpeed < 45.5)
            {
                clothes.Add("Put on a wind breaker");
            }
            if (windSpeed > 45.5 && windSpeed < 75.2)
            {
                clothes.Add("Stay in doors");
            }
            if (windSpeed >= 75.2)
            {
                clothes.Add("Get to the storm cellar");
            }
            if (rainChancePercentage < 10)
            {
                clothes.Add("Don't worry about it");
            }
            if (rainChancePercentage > 10 && rainChancePercentage < 35)
            {
                clothes.Add("Wear a hat");
            }
            if (rainChancePercentage > 35)
            {
                clothes.Add("Take an umbrella to be safe");
            }
            if (rainChancePercentage > 80)
            {
                clothes.Add("Stay home and read a book");
            }
            switch (forecast)
            {
                case "sunny":
                    clothes.Add("Put on your sun glasses and put on sun screen");
                    break;
                case "windy":
                    clothes.Add("Wear a coat");
                    break;
                case "snowy":
                    clothes.Add("Wear you boots");
                    break;
            }
            return clothes;
        }
    }
}
