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
        //public double startOfDayMoney;
        //public double expenditure; 
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
        Weather getWeather = new Weather();
        
        //print inventory before purchasing
        
        public void StartStore()
        {
            
            BuyLemons();
            BuySugar();
            BuyIce();
            BuyCups();
        }
        public double BuyLemons()
        {
            
            Console.WriteLine("How many Lemons would you like to buy? Lemons are $0.10 each");
            int choice = int.Parse(Console.ReadLine());            
            if (playerInfo.money - (choice * .10)< 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuyLemons();
            }
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Lemons for {1:C2} or 'no' to try again.", choice, choice * .1);
                yesNo = Console.ReadLine();
                switch (yesNo)
                {
                    case "yes":
                        lemons = remainingLemons + choice;
                        playerInfo.money = playerInfo.money - (choice * .1);
                        Console.WriteLine("Purchase completed!");
                        Console.WriteLine("You have {0:C2} remaining.", playerInfo.money);
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
            return playerInfo.money;           
            
        }

        public double BuyCups()
        {
            Console.WriteLine("How many Cups would you like to buy? Cups are $0.05 each");
            int choice = int.Parse(Console.ReadLine());
            if (playerInfo.money - (choice * .05) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuyCups();
            }
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Cups for {1:C2} or 'no' to try again.", choice, choice * .05);
                yesNo = Console.ReadLine();
                switch (yesNo)
                {
                    case "yes":
                        lemons = remainingLemons + choice;
                        playerInfo.money = playerInfo.money - (choice * .05);
                        Console.WriteLine("Purchase completed!");
                        Console.WriteLine("You have {0:C2} remaining.", playerInfo.money);
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
            return playerInfo.money;


        }

        public double BuyIce()
        {
            Console.WriteLine("How many Cups of Ice would you like to buy? Cups of Ice are $0.05 each");
            int choice = int.Parse(Console.ReadLine());
            if (playerInfo.money - (choice * .05) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuyIce();
            }
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Cups of Ice for {1:C2} or 'no' to try again.", choice, choice * .05);
                yesNo = Console.ReadLine();
                switch (yesNo)
                {
                    case "yes":
                        lemons = remainingLemons + choice;
                        playerInfo.money = playerInfo.money - (choice * .05);
                        Console.WriteLine("Purchase completed!");
                        Console.WriteLine("You have {0:C2} remaining.", playerInfo.money);
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

            return playerInfo.money;
        }

        public double BuySugar()
        {
            Console.WriteLine("How many servings of Sugar would you like to buy? Servings of Sugar are $0.02 each");
            int choice = int.Parse(Console.ReadLine());
            if (playerInfo.money - (choice * .02) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuySugar();
            }
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Servings of Sugar for {1:C2} or 'no' to try again.", choice, choice * .02);
                yesNo = Console.ReadLine();
                switch (yesNo)
                {
                    case "yes":
                        lemons = remainingLemons + choice;
                        playerInfo.money = playerInfo.money - (choice * .02);
                        Console.WriteLine("Purchase completed!");
                        Console.WriteLine("You have {0:C2} remaining.", playerInfo.money);
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

            return playerInfo.money;
        }
        //public double AddExpenditures()
        //{
        //    expenditure = startOfDayMoney - playerInfo.money;
        //    return expenditure;
        //    add amount spent at store each day so that
        //}


        public void CheckInventory()
        {
            //will check after each day, 
        }
    }
}
