using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {

        public int weatherNumber;



        public int DetermineWeather()
        {
            
               Random weatherRand = new Random();
               int randomWeather = weatherRand.Next(0, 100);

            if (randomWeather >= 0 && randomWeather <= 14)
            {
                weatherNumber = 1;
            }

            else if (randomWeather >= 15 && randomWeather <= 39)
            {
                weatherNumber = 2;
            }

            else if (randomWeather >= 40 && randomWeather <= 59)
            {
                weatherNumber = 3;
            }

            else if (randomWeather >= 60 && randomWeather <= 84)
            {
                weatherNumber = 4;
            }
            else if (randomWeather >= 85 && randomWeather <= 100)
            {
                weatherNumber = 5;
            }
            
            return weatherNumber;
        }
        public void PresentDailyWeather()
        {
            //add forecast text (maybe a picture?)


            switch (weatherNumber)
            {
                case 1:
                    Console.WriteLine("Today's weather forecast is Sunny and Warm!!");
                    break;
                case 2:
                    Console.WriteLine("Today's weather forecast is Sunny and Cool!!");
                    break;
                case 3:
                    Console.WriteLine("Today's weather forecast is Rainy and Cool!!");
                    break;
                case 4:
                    Console.WriteLine("Today's weather forecast is Rainy and Warm!!");
                    break;
                case 5:
                    Console.WriteLine("Today's weather forecast is Snowy!!");
                    break;
                default:
                    break;
            }
        }
    }
}
