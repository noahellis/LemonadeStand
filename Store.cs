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
        public double moneySpent;
        public double profit;
        public int choiceLemons;
        public int choiceIce;
        public int choiceCups;
        public int choiceSugar;
        Inventory inventory = new Inventory();
        Weather weather = new Weather();
        List<int> purchasedLemonade = new List<int>();
        List<int> didNotPurchaseLemonade = new List<int>();
        public double inputPrice()
        {
            Console.WriteLine("Please enter how much you would like to charge per cup for the day. \nEnter number in decimal form. For example, 50 cents per cup would be inputted as .50  \nHint: price of a cup of Lemonade should be less than $1.50");
            chargePrice = double.Parse(Console.ReadLine());
            if (chargePrice <= 0.009)
            {
                Console.WriteLine("You have inputted an invalid price per cup. You have to charge a positve amount equal to or over $0.01");
                inputPrice();
            }
            else if (chargePrice >= 2.00)
            {
                Console.WriteLine("You don't want to charge that much...nobody will but it.  Try again.");
                inputPrice();
            }

            return chargePrice;
        }

        public double BuyLemons()
        {
            Console.WriteLine("You currently have {0} Lemons.", inventory.lemons);
            Console.WriteLine("How many Lemons would you like to buy? Lemons are $0.10 each");
            try
            {
                choiceLemons = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a positive whole number, or zero");
                return BuyLemons();
            }
            if (inventory.money - (choiceLemons * .10) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                BuyLemons();
            }
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Lemons for {1:C2} or 'no' to try again.", choiceLemons, choiceLemons * .1);
                yesNo = Console.ReadLine();
                switch (yesNo)
                {
                    case "yes":
                        inventory.lemons = inventory.lemons + choiceLemons;
                        inventory.money = inventory.money - (choiceLemons * .1);
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
            try
            {
                choiceCups = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a positive whole number, or zero");
                return BuyCups();
            }
            if (inventory.money - (choiceCups * .05) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                return BuyCups();
            }
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Cups for {1:C2} or 'no' to try again.", choiceCups, choiceCups * .05);
                yesNo = Console.ReadLine();
                switch (yesNo)
                {
                    case "yes":
                        inventory.cups = inventory.cups + choiceCups;
                        inventory.money = inventory.money - (choiceCups * .05);
                        Console.WriteLine("Purchase completed!");
                        Console.WriteLine("You have {0:C2} remaining.", inventory.money);
                        break;
                    case "no":
                        return BuyCups();                        
                    default:
                        Console.WriteLine("Your entry is invalid. Please try again");
                        return BuyCups();                        
                }
            }

            return inventory.money;
        }

        public double BuyIce()
        {
            Console.WriteLine("You currently have {0} Cups of Ice.", inventory.ice);
            Console.WriteLine("How many Cups of Ice would you like to buy? Cups of Ice are $0.05 each");
            try
            {
                choiceIce = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a positive whole number, or zero");
                return BuyIce();
            }
            if (inventory.money - (choiceIce * .05) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                return BuyIce();
            }
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Cups of Ice for {1:C2} or 'no' to try again.", choiceIce, choiceIce * .05);
                yesNo = Console.ReadLine();
                switch (yesNo)
                {
                    case "yes":
                        inventory.ice = inventory.ice + choiceIce;
                        inventory.money = inventory.money - (choiceIce * .05);
                        Console.WriteLine("Purchase completed!");
                        Console.WriteLine("You have {0:C2} remaining.", inventory.money);
                        break;
                    case "no":
                        return BuyIce();                        
                    default:
                        Console.WriteLine("Your entry is invalid. Please try again");
                        return BuyIce();                        
                }
            }

            return inventory.money;
        }

        public double BuySugar()
        {
            Console.WriteLine("You currently have {0} Servings of Sugar.", inventory.sugar);
            Console.WriteLine("How many servings of Sugar would you like to buy? Servings of Sugar are $0.02 each");
            try
            {
                choiceSugar = int.Parse(Console.ReadLine());
                if (choiceSugar + inventory.sugar < inventory.lemons * 2 && choiceSugar + inventory.sugar < inventory.ice *2 && choiceSugar + inventory.sugar < inventory.cups *2)
                {
                    Console.WriteLine("Remember you need two servings of Sugar for every cup. Would you like to try again?");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "yes":
                            return BuySugar();
                        case "no":
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a positive whole number, or zero");
                return BuySugar();
            }
            if (inventory.money - (choiceSugar * .02) < 0)
            {
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                return BuySugar();
            }

            
            else
            {
                Console.WriteLine("Enter 'yes' if you would like to purchase {0} Servings of Sugar for {1:C2} or 'no' to try again.", choiceSugar, choiceSugar * .02);
                yesNo = Console.ReadLine();
                switch (yesNo)
                {
                    case "yes":
                        inventory.sugar = inventory.sugar + choiceSugar;
                        inventory.money = inventory.money - (choiceSugar * .02);
                        Console.WriteLine("Purchase completed!");
                        Console.WriteLine("You have {0:C2} remaining.", inventory.money);
                        break;
                    case "no":
                        return BuySugar();                        
                    default:
                        Console.WriteLine("Your entry is invalid. Please try again");
                        return BuySugar();                        
                }
            }

            return inventory.money;
        }

        public void DetermineWillBuyPrice()
        {
            purchasedLemonade.Clear();
            didNotPurchaseLemonade.Clear();
            Random custBuy = new Random();
            foreach (int buyer in weather.approachCust)
            {
                
                int priceBuy = custBuy.Next(0, 100);
                if (chargePrice > 0 && chargePrice <= .2)
                {
                    if (inventory.enoughInventory == true)
                    {
                        weather.willBuy = true;
                        purchasedLemonade.Add(1);
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
                            purchasedLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        didNotPurchaseLemonade.Add(1);
                    }
                }

                if (chargePrice > .5 && chargePrice <= .75)
                {
                    if (priceBuy < 70)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            purchasedLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        didNotPurchaseLemonade.Add(1);
                    }
                }

                if (chargePrice > .75 && chargePrice <= 1)
                {
                    if (priceBuy < 60)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            purchasedLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        didNotPurchaseLemonade.Add(1);
                    }
                }

                if (chargePrice > 1 && chargePrice <= 1.25)
                {
                    if (priceBuy < 40)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            purchasedLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        didNotPurchaseLemonade.Add(1);
                    }
                }

                if (chargePrice > 1.25 && chargePrice <= 1.5)
                {
                    if (priceBuy < 30)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            purchasedLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        didNotPurchaseLemonade.Add(1);
                    }
                }

                if (chargePrice > 1.5)
                {
                    if (priceBuy < 10)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            purchasedLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + chargePrice;
                        }
                        else
                            break;
                    }
                    else
                    {
                        didNotPurchaseLemonade.Add(1);
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

        public void ShowApproachingCustomers()
        {
            int approachingCustomers = purchasedLemonade.Count + didNotPurchaseLemonade.Count;
            if (approachingCustomers ==1)
            {
                Console.WriteLine("One customer approached to buy Lemonade");
            }
            else
            Console.WriteLine("{0} customers approached to buy Lemonade.", approachingCustomers);
        }

        public void ShowPurchased()
        {
            if (purchasedLemonade.Count == 1)
            {
                Console.WriteLine("One bought Lemonade!!");
            }

            else
            {
                Console.WriteLine("{0} bought Lemonade!!!", purchasedLemonade.Count());
            }
            
        }

        public void ShowDidNotPurchase()
        {
            if (didNotPurchaseLemonade.Count == 1)
            {
                Console.WriteLine("One person opted not to buy Lemonade because the price was too high");
            }
            else
            {
                Console.WriteLine("{0} people opted not to buy Lemonade because the price was too high", didNotPurchaseLemonade.Count());
            }
            
        }

        public double DisplayAmountSpent()
        {
            moneySpent = ((choiceCups * .05) + (choiceIce * .05) + (choiceLemons * .1) + (choiceSugar * .02));
            Console.WriteLine("You spent {0:C2} dollars on inventory.", moneySpent);
            return moneySpent;
        }

        public double DisplayProfit()
        {
            profit = inventory.money - 7;
            Console.WriteLine("Profit so far is {0:C2}", profit);
            return profit;
        }
        public void DisplayInventory()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your current Inventory is: {0} Lemons, {1} Cups of Ice, {2} Servings of Sugar, {3} Cups.", inventory.lemons, inventory.ice, inventory.sugar, inventory.cups);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void DisplaySimpleWeather()
        {
            weather.PresentDailyWeatherSimple();
        }

        public void GetWeather()
        {
            inventory.DisplayCashAndInventory();
            weather.DetermineWeather();
            weather.PresentDailyWeather();
            weather.GetNumberOfPotentialCustomers();
            weather.DetermineWillBuyWeather();
        }
    }
}