using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Store startStore = new Store();
        Player startPlayer = new Player();
        public int numberOfDays = 7;
        public string choice;        
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
            else
            {
                EndGame();
            }
        }
        public void EndGame ()
        {
            Console.WriteLine("Sorry, you have run out of money. Would you like to try again?");
            choice = Console.ReadLine();
            bool correct = true;
            while (correct)
            {
                switch (choice)
                {

                    case ("yes"):
                        StartGame();
                        break;
                    case ("Yes"):
                        StartGame();
                        break;
                    case ("no"):
                        Environment.Exit(0);
                        break;
                    case ("No"):
                        Environment.Exit(0);
                        break;
                    default:
                        correct = false;
                        Console.WriteLine("Please try again, incorrect input.");
                        break;
                }
            }
        }
    }
}