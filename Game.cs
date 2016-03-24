using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        

        public void ShowProfit()
        {

        }

        public void PresentDailyWeather()
        {
            Weather dailyWeather = new Weather();
            dailyWeather.DetermineWeather();
            
        }

        public void MakePitchers()
        {
            //pitcher = 6 cups
            //may just make user able to make as many cups as they have ingredients for, kinda hate premake the pitcher thing
        }

    }
}
