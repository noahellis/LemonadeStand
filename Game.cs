using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //Weather startWeather = new Weather();
        Customer startCustomer = new Customer();
        Store startStore = new Store();
        Player startPlayer = new Player();
        Day startDay = new Day();
        public int numberOfDays = 7;
        

        public void StartGame()
        {
            startPlayer.GetUserInfo();
            if (startStore.ShowMoney() > 0)
            {
                for (int dayIndex = 1; dayIndex <= numberOfDays; dayIndex++)
                {
                    Console.WriteLine("Day {0} of your Lemonade stand.", dayIndex);


                    startStore.GetWeather();
                    startStore.BuyLemons();
                    startStore.BuyIce();
                    startStore.BuySugar();
                    startStore.BuyCups();
                    startStore.inputPrice();
                    startStore.DetermineWillBuyPrice();
                }
                
            }

            //else end game
                
           
        }

    }
}
