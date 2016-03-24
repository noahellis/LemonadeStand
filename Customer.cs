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
        public int potentialCustomer;
        Weather customerNumber = new Weather();
        public List<int> dailyCustomers = new List<int>();
        public void DetermineWillBuyWeather()
        {
            Random custBuy = new Random();

            
            for (int dayCust = 0; dayCust <= potentialCustomer; dayCust++)
            {
                int weatherBuy = custBuy.Next(0, 100);


                if (customerNumber.weatherNumber == 1)
                {
                    if (weatherBuy < 90)
                    {
                        willBuy = true;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (customerNumber.weatherNumber == 2)
                {
                    if (weatherBuy < 70)
                    {
                        willBuy = true;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (customerNumber.weatherNumber == 3)
                {
                    if (weatherBuy < 50)
                    {
                        willBuy = true;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (customerNumber.weatherNumber == 4)
                {
                    if (weatherBuy < 60)
                    {
                        willBuy = true;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                if (customerNumber.weatherNumber == 5)
                {
                    if (weatherBuy < 10)
                    {
                        willBuy = true;
                    }
                    else
                    {
                        willBuy = false;
                    }
                }

                while (willBuy)
                {
                    // DetermineWillBuyPrice();
                    Console.WriteLine("Bought Lemonade");
                    break;
                }

                while (!willBuy)
                {
                    Console.WriteLine("Didn't buy Lemonade");
                    break;
                }
            }
        }

        public void DetermineWillBuyPrice()
        {
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
    }
}