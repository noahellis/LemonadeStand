﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public  double chargePrice;
        //Weather dailyWeather = new Weather();
        Store getStoreInfo = new Store();



        public void ShowProfit()
        {
            
            //income - expenses 
        }

        

        //public void MakeLemonade()
        //{
            
            
        //}

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

    }
}
