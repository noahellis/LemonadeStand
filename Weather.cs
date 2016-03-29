﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public int weatherNumber;
        public bool willBuy;
        public bool willApproach;
        public int potentialCustomer;
        public int approachingCustomers;
        public List<int> dailyCustomers = new List<int>();
        public List<int> purchasingCustomers = new List<int>();
        public List<bool> customersThatBought = new List<bool>();
        public int DetermineWeather()
        {
            Random weatherRand = new Random();
            int randomWeather = weatherRand.Next(0, 100);
            if (randomWeather >= 0 && randomWeather <= 14)
            {
                weatherNumber = 1;
            }
            else if (randomWeather >= 15 && randomWeather <= 39)
            {
                weatherNumber = 2;
            }
            else if (randomWeather >= 40 && randomWeather <= 59)
            {
                weatherNumber = 3;
            }
            else if (randomWeather >= 60 && randomWeather <= 84)
            {
                weatherNumber = 4;
            }
            else if (randomWeather >= 85 && randomWeather <= 100)
            {
                weatherNumber = 5;
            }

            return weatherNumber;
        }

        public void PresentDailyWeather()
        {
            switch (weatherNumber)
            {
                case 1:
                    Console.WriteLine("Today's weather forecast is Sunny and Warm!!");
                    break;
                case 2:
                    Console.WriteLine("Today's weather forecast is Sunny and Cool!!");
                    break;
                case 3:
                    Console.WriteLine("Today's weather forecast is Rainy and Cool!!");
                    break;
                case 4:
                    Console.WriteLine("Today's weather forecast is Rainy and Warm!!");
                    break;
                case 5:
                    Console.WriteLine("Today's weather forecast is Snowy!!");
                    break;
                default:
                    break;
            }
        }

        public int DetermineWillBuyWeather()
        {
            Random custApproach = new Random();
            for (int dayCust = 0; dayCust <= potentialCustomer; dayCust++)
            {
                int weatherBuy = custApproach.Next(0, 100);
                if (weatherNumber == 1)
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

                if (weatherNumber == 2)
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

                if (weatherNumber == 3)
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

                if (weatherNumber == 4)
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

                if (weatherNumber == 5)
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
            }

            approachingCustomers = purchasingCustomers.Count;
            return approachingCustomers;
        }

        public void GetNumberOfPotentialCustomers()
        {
            Random custNum = new Random();
            if (weatherNumber == 1)
            {
                potentialCustomer = custNum.Next(30, 60);
            }
            else if (weatherNumber == 2)
            {
                potentialCustomer = custNum.Next(20, 50);
            }
            else if (weatherNumber == 3)
            {
                potentialCustomer = custNum.Next(20, 30);
            }
            else if (weatherNumber == 4)
            {
                potentialCustomer = custNum.Next(20, 40);
            }
            else if (weatherNumber == 5)
            {
                potentialCustomer = custNum.Next(10, 30);
            }

            for (int customers = 0; customers <= potentialCustomer; customers++)
            {
                dailyCustomers.Add(1);
            }
        }


    }
}