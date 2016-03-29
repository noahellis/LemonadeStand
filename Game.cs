using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

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
            GameInfo();

            if (startStore.ShowMoney() > 0)
            {
                for (int dayIndex = 1; dayIndex <= numberOfDays; dayIndex++)
                {
                    Console.Clear();
                    Console.WriteLine("Day {0} of your Lemonade stand.", dayIndex);
                    startStore.GetWeather();
                    startStore.BuyLemons();
                    startStore.BuyIce();
                    startStore.BuySugar();
                    startStore.BuyCups();
                    startStore.inputPrice();
                    startStore.DetermineWillBuyPrice();
                    startStore.ShowPurchased();
                    startStore.ShowDidNotPurchase();
                    Console.WriteLine("Press any key to start the next day");
                    Console.ReadKey();               
                }
            }
            else
            {
                EndGame();
            }
        }
        public void EndGame ()
        {
            Console.WriteLine("The game has ended. You ended with {0:C2}. Would you like to try again?", startStore.remainingMoney);
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

        public void GameInfo()
        {
            Console.WriteLine("Hello {0}!!", startPlayer.name);
            Console.WriteLine("Welcome to my Lemonade Stand!!!");
            Console.WriteLine("This game takes place across seven days.  Each glass of Lemonade needs a Cup, a Cup of Ice, two Servings of Sugar, and a Lemon.");
            Console.WriteLine("Make sure you have enough ingredients to get through each day, or the day will end early!");
            Thread.Sleep(10000);
            Console.Clear();
        }
    }
}