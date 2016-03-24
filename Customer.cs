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

        public void DetermineWillBuyWeather()
        {
            Random custBuy = new Random();
            int weatherBuy = custBuy.Next(0, 100);

            //need to create list of customers based on number generated in GetNumberOfPotentialCustomers function !!!!!!!!  Then create foreach loop for that List!!!!!!!!!!!!!!!!
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

            if (customerNumber.weatherNumber ==2)
            {
                if (weatherBuy <70)
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
                Console.WriteLine("Bought Lemonade");
            }
            while (!willBuy)
            {
                Console.WriteLine("Didn't buy Lemonade");
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

            Console.WriteLine(potentialCustomer);
            DetermineWillBuyWeather();
        }
    }
}
