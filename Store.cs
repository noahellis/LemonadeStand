using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //link remaining product with inventory class
        public int lemons;
        public int remainingLemons;
        public int cups;
        public int remainingCups;
        public int sugar;
        public int remainingSugar;
        public int ice;
        public int remainingIce;
        public string yesNo;
        
        Player playerInfo = new Player();
        //give option to buy any number at a set price
        //subtract purchases from current cash
        //print inventory before purchasing
        //show remaining cash
        //don't allow purchase if not enough cash
        public void BuyLemons()
        {
            Console.WriteLine("How many Lemons would you like to buy?");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter yes if you would like to purchase " + choice + " Lemons for " + (choice * .20) + " or no to try again.");
            yesNo = Console.ReadLine();
            switch (yesNo)
            {
                case "yes":
                    lemons = remainingLemons + choice;
                    playerInfo.money = playerInfo.money - (choice * .2);
                    Console.WriteLine("Purchase completed");
                    break;

                case "no":
                    BuyLemons();
                    break;
                default:
                    Console.WriteLine("Your entry is invalid. Please try again");
                    BuyLemons();
                    break;
            }
            
        }

        public void BuyCups()
        {
            Console.WriteLine("How many Cups would you like to buy?");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter yes if you would like to purchase " + choice + " Cups for " + (choice * .10) + " or no to try again.");
            yesNo = Console.ReadLine();
            switch (yesNo)
            {
                case "yes":
                    cups = remainingCups + choice;
                    playerInfo.money = playerInfo.money - (choice * .1);
                    Console.WriteLine("Purchase completed");
                    break;

                case "no":
                    BuyCups();
                    break;
                default:
                    Console.WriteLine("Your entry is invalid. Please try again");
                    BuyCups();
                    break;
            }
        }

        public void BuyIce()
        {
            Console.WriteLine("How many cups of Ice would you like to buy?");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter yes if you would like to purchase " + choice + " cups of Ice for " + (choice * .10) + " or no to try again.");
            yesNo = Console.ReadLine();
            switch (yesNo)
            {
                case "yes":
                    ice = remainingIce + choice;
                    playerInfo.money = playerInfo.money - (choice * .1);
                    Console.WriteLine("Purchase completed");
                    break;

                case "no":
                    BuyIce();
                    break;
                default:
                    Console.WriteLine("Your entry is invalid. Please try again");
                    BuyIce();
                    break;
            }
        }

        public void BuySugar()
        {
            Console.WriteLine("How much Sugar would you like to buy?");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter yes if you would like to purchase " + choice + " servings of Sugar for " + (choice * .10) + " or no to try again.");
            yesNo = Console.ReadLine();
            switch (yesNo)
            {
                case "yes":
                    sugar = remainingSugar + choice;
                    playerInfo.money = playerInfo.money - (choice * .08);
                    Console.WriteLine("Purchase completed");
                    break;

                case "no":
                    BuySugar();
                    break;
                default:
                    Console.WriteLine("Your entry is invalid. Please try again");
                    BuySugar();
                    break;
            }
        }

       
        public void CheckInventory()
        {
            //will check after each day, 
        }
    }
}
