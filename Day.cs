using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public int numberOfDays = 7;
        Weather dailyWeather = new Weather();
        Customer dailyCustomer = new Customer();
        Store dailyStore = new Store();


        public void StartDay()
        {
            dailyWeather.DetermineWeather();
            dailyWeather.PresentDailyWeather();
            dailyStore.StartStore();
            dailyCustomer.GetNumberOfPotentialCustomers();
            //generate weather
            //report weather
            //start store class, buy needed products
            //subtract ingredients until out
            //add money made to existing cash
            //print profit margin?
        }

        public void CountDays()
        {
            //day one only run ask for name funciton
            for (int dayIndex = 0; dayIndex <= numberOfDays; dayIndex++) ;
        }

        //public void EndDay()
        //{
             //if stock runs out, end automatically
        //}
    }
}
