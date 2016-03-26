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
        
        
        //print inventory before purchasing
        
        
        public void BuyLemons()
        {
            Console.WriteLine("How many Lemons would you like to buy? Lemons are $0.20 each");
            int choice = int.Parse(Console.ReadLine());            
            if (playerInfo.money - (choice * .2)< 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuyLemons();
            }
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Lemons for {1:C2} or 'no' to try again.", choice, choice * .2);
                yesNo = Console.ReadLine();
                switch (yesNo)
                {
                    case "yes":
                        lemons = remainingLemons + choice;
                        playerInfo.money = playerInfo.money - (choice * .2);
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
            
            
        }

        public void BuyCups()
        {
            Console.WriteLine("How many Cups would you like to buy? Cups are $0.10 each");
            int choice = int.Parse(Console.ReadLine());
            if (playerInfo.money - (choice * .1) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuyCups();
            }
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Cups for {1:C2} or 'no' to try again.", choice, choice * .1);
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
                        BuyCups();
                        break;
                    default:
                        Console.WriteLine("Your entry is invalid. Please try again");
                        BuyCups();
                        break;
                }
            }


        }

        public void BuyIce()
        {
            Console.WriteLine("How many Cups of Ice would you like to buy? Cups of Ice are $0.10 each");
            int choice = int.Parse(Console.ReadLine());
            if (playerInfo.money - (choice * .1) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuyIce();
            }
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Cups of Ice for {1:C2} or 'no' to try again.", choice, choice * .1);
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
                        BuyIce();
                        break;
                    default:
                        Console.WriteLine("Your entry is invalid. Please try again");
                        BuyIce();
                        break;
                }
            }


        }

        public void BuySugar()
        {
            Console.WriteLine("How many servings of Sugar would you like to buy? Servings of Sugar are $0.08 each");
            int choice = int.Parse(Console.ReadLine());
            if (playerInfo.money - (choice * .08) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuySugar();
            }
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Servings of Sugar for {1:C2} or 'no' to try again.", choice, choice * .08);
                yesNo = Console.ReadLine();
                switch (yesNo)
                {
                    case "yes":
                        lemons = remainingLemons + choice;
                        playerInfo.money = playerInfo.money - (choice * .08);
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


        }


        public void CheckInventory()
        {
            //will check after each day, 
        }
    }
}
