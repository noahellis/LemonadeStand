using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public int lemons;
        public int remainingLemons;
        public int cups;
        public int remainingCups;
        public int sugar;
        public int remainingSugar;
       // Player playerInfo = new Player(name:Console.ReadLine, 20);

        //give option to buy any number at a set price
        //subtract purchases from current cash
        public void BuyLemons()
        {
            Console.WriteLine("How many Lemons would you like to buy?");
        }

        public void BuyCups()
        {
            Console.WriteLine("How many Cups would you like to buy?");
        }

        public void BuyIce()
        {
            Console.WriteLine("How much Ice would you like to buy?");
        }

        public void BuySugar()
        {
            Console.WriteLine("How much Sugar would you like to buy?");
        }

       
        public void CheckInventory()
        {
            //will check after each day, 
        }
    }
}
