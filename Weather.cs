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
            Console.WriteLine(weatherNumber);
            return weatherNumber;
        }       
    }
}
