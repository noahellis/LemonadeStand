using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public string yesNo;
        public double chargePrice;
        public double remainingMoney;
        Inventory inventory = new Inventory();
        Weather weather = new Weather();
        public double inputPrice()
        {
            Console.WriteLine("Please enter how much you would like to charge per cup for the day. \n Enter number in $.cc format");
            chargePrice = double.Parse(Console.ReadLine());
            if (chargePrice <= 0.009)
            {
                Console.WriteLine("You have inputted an invalid price per cup. You have to charge a positve amount equal to or over $0.01");
                inputPrice();
            }

            return chargePrice;
        }

        public double BuyLemons()
        {
            Console.WriteLine("You currently have {0} Lemons.", inventory.lemons);
            Console.WriteLine("How many Lemons would you like to buy? Lemons are $0.10 each");
            int choice = int.Parse(Console.ReadLine());
            if (inventory.money - (choice * .10) < 0)
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
                        inventory.lemons = inventory.lemons + choice;
                        inventory.money = inventory.money - (choice * .1);
                        Console.WriteLine("Purchase completed!");
                        Console.WriteLine("You have {0:C2} remaining.", inventory.money);
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

            return inventory.money;
        }

        public double BuyCups()
        {
            Console.WriteLine("You currently have {0} Cups.", inventory.cups);
            Console.WriteLine("How many Cups would you like to buy? Cups are $0.05 each");
            int choice = int.Parse(Console.ReadLine());
            if (inventory.money - (choice * .05) < 0)
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
                        inventory.cups = inventory.cups + choice;
                        inventory.money = inventory.money - (choice * .05);
                        Console.WriteLine("Purchase completed!");
                        Console.WriteLine("You have {0:C2} remaining.", inventory.money);
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

            return inventory.money;
        }

        public double BuyIce()
        {
            Console.WriteLine("You currently have {0} Cups of Ice.", inventory.ice);
            Console.WriteLine("How many Cups of Ice would you like to buy? Cups of Ice are $0.05 each");
            int choice = int.Parse(Console.ReadLine());
            if (inventory.money - (choice * .05) < 0)
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
                        inventory.ice = inventory.ice + choice;
                        inventory.money = inventory.money - (choice * .05);
                        Console.WriteLine("Purchase completed!");
                        Console.WriteLine("You have {0:C2} remaining.", inventory.money);
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

            return inventory.money;
        }

        public double BuySugar()
        {
            Console.WriteLine("You currently have {0} Servings of Sugar.", inventory.sugar);
            Console.WriteLine("How many servings of Sugar would you like to buy? Servings of Sugar are $0.02 each");
            int choice = int.Parse(Console.ReadLine());
            if (inventory.money - (choice * .02) < 0)
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
                        inventory.sugar = inventory.sugar + choice;
                        inventory.money = inventory.money - (choice * .02);
                        Console.WriteLine("Purchase completed!");
                        Console.WriteLine("You have {0:C2} remaining.", inventory.money);
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

            return inventory.money;
        }

        public void DetermineWillBuyPrice()
        {
            Random custBuy = new Random();
            foreach (int buyer in weather.purchasingCustomers)
            {
                int priceBuy = custBuy.Next(0, 100);
                if (chargePrice > 0 && chargePrice <= .2)
                {
                    if (inventory.enoughInventory == true)
                    {
                        weather.willBuy = true;
                        Console.WriteLine("bought lemonade");
                        inventory.SubtractInventory();
                        inventory.money = inventory.money + chargePrice;
                    }
                    else
                        break;
                    
                }

                if (chargePrice > .2 && chargePrice <= .5)
                {
                    if (priceBuy < 80)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            Console.WriteLine("bought lemonade");
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }

                if (chargePrice > .5 && chargePrice <= .75)
                {
                    if (priceBuy < 70)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            Console.WriteLine("bought lemonade");
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }

                if (chargePrice > .75 && chargePrice <= 1)
                {
                    if (priceBuy < 60)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            Console.WriteLine("bought lemonade");
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }

                if (chargePrice > 1 && chargePrice <= 1.25)
                {
                    if (priceBuy < 40)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            Console.WriteLine("bought lemonade");
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }

                if (chargePrice > 1.25 && chargePrice <= 1.5)
                {
                    if (priceBuy < 30)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            Console.WriteLine("bought lemonade");
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }

                if (chargePrice > 1.5)
                {
                    if (priceBuy < 10)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            Console.WriteLine("bought lemonade");
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }
            }
        }

        public double ShowMoney()
        {
            remainingMoney = inventory.money;
            Console.WriteLine("You have {0:C2} remaining", remainingMoney);
            return remainingMoney;
        }

        public void GetWeather()
        {
            weather.DetermineWeather();
            weather.PresentDailyWeather();
            weather.GetNumberOfPotentialCustomers();
            weather.DetermineWillBuyWeather();
        }
    }
}