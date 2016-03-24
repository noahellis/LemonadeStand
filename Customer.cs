using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public int potentialCustomer;

        public void DetermineWillBuyWeather()
        {

        }

        public void DetermineWillBuyPrice()
        {

        }

        public void GetNumberOfPotentialCustomers()
        {
            //int potentialCustomers;
            Random custNum = new Random();

            Weather customerNumber = new Weather();
            customerNumber.DetermineWeather();

            // switch (customerNumber.DetermineWeather)
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
        }
    }
}
