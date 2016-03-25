using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public bool willBuy;
        public bool willApproach;
        public int potentialCustomer;
        public int approachingCustomers; 
        Weather customerNumber = new Weather();
        Game getChargedPrice = new Game();
        public List<int> dailyCustomers = new List<int>();
        public List<int> purchasingCustomers = new List<int>();

        public void DetermineWillBuyWeather()
        {
            Random custApproach = new Random();

            
            for (int dayCust = 0; dayCust <= potentialCustomer; dayCust++)
            {
                int weatherBuy = custApproach.Next(0, 100);


                if (customerNumber.weatherNumber == 1)
                {
                    if (weatherBuy < 90)
                    {
                        willApproach = true;
                        purchasingCustomers.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (customerNumber.weatherNumber == 2)
                {
                    if (weatherBuy < 70)
                    {
                        willApproach = true;
                        purchasingCustomers.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (customerNumber.weatherNumber == 3)
                {
                    if (weatherBuy < 50)
                    {
                        willApproach = true;
                        purchasingCustomers.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (customerNumber.weatherNumber == 4)
                {
                    if (weatherBuy < 60)
                    {
                        willApproach = true;
                        purchasingCustomers.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (customerNumber.weatherNumber == 5)
                {
                    if (weatherBuy < 10)
                    {
                        willApproach = true;
                        purchasingCustomers.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }           
                   approachingCustomers = purchasingCustomers.Count;
                            
            }
            DetermineWillBuyPrice(getChargedPrice); 
        }

        public void DetermineWillBuyPrice(Game game)
        {
            
            Random custBuy = new Random();
            foreach (int buyer in purchasingCustomers)
            {
                int priceBuy = custBuy.Next(0, 100);

                if (getChargedPrice.chargePrice > 0 && getChargedPrice.chargePrice <= .2)
                {
                    willBuy = true;
                    Console.WriteLine("bought lemonade");
                    
                }



                if (getChargedPrice.chargePrice > .2 && getChargedPrice.chargePrice <= .5)
                {
                    if (priceBuy < 80)
                    {
                        willBuy = true;
                        Console.WriteLine("bought lemonade");
                        
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }
                if (getChargedPrice.chargePrice > .5 && getChargedPrice.chargePrice <= .75)
                {
                    if (priceBuy < 70)
                    {
                        willBuy = true;
                        Console.WriteLine("bought lemonade");
                        
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }
                if (getChargedPrice.chargePrice > .75 && getChargedPrice.chargePrice <= 1)
                {
                    if (priceBuy < 60)
                    {
                        willBuy = true;
                        Console.WriteLine("bought lemonade");
                        
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }
                if (getChargedPrice.chargePrice > 1 && getChargedPrice.chargePrice <= 1.25)
                {
                    if(priceBuy < 40)
                    {
                        willBuy = true;
                        Console.WriteLine("bought lemonade");
                        
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }
                if (getChargedPrice.chargePrice >1.25 && getChargedPrice.chargePrice <= 1.5)
                {
                    if(priceBuy < 30)
                    {
                        willBuy = true;
                        Console.WriteLine("bought lemonade");
                        
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }
                if (getChargedPrice.chargePrice > 1.5)
                {
                    if (priceBuy < 10)
                    {
                        willBuy = true;
                        Console.WriteLine("bought lemonade");
                        
                    }
                    else
                    {
                        Console.WriteLine("Approached stand, didn't buy");
                    }
                }
            }
        }

        public void GetNumberOfPotentialCustomers()
        {
            Random custNum = new Random();
            customerNumber.DetermineWeather();
            if (customerNumber.weatherNumber == 1)
            {
                potentialCustomer = custNum.Next(30, 60);                
            }
            else if (customerNumber.weatherNumber == 2)
            {
                potentialCustomer = custNum.Next(20, 50);
            }
            else if (customerNumber.weatherNumber == 3)
            {
                potentialCustomer = custNum.Next(20, 30);
            }
            else if (customerNumber.weatherNumber == 4)
            {
                potentialCustomer = custNum.Next(20, 40);
            }
            else if (customerNumber.weatherNumber == 5)
            {
                potentialCustomer = custNum.Next(10, 30);
            }
            dailyCustomers.Add(potentialCustomer);
            

            Console.WriteLine(potentialCustomer);
            DetermineWillBuyWeather();
        }

        public void Start()
        {
            getChargedPrice.inputPrice();
            GetNumberOfPotentialCustomers();
            Console.WriteLine(getChargedPrice.chargePrice);
            Console.ReadLine();
        }
    }
}