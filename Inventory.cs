using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {

        public int lemons;
        public int ice;
        public int cups;
        public int sugar;
        public double money = 20;
        //Store storePurchases = new Store();
        //call at end of day, report to user
        public void GetLemonStock()
        {
            
        }

        public void GetIceStock()
        {
            
        }

        public void GetCupStock()
        {
            
        }

        public void GetSugarStock(int Sugar)
        {
            
        }

        public void SubtractInventory()
        {

            if (lemons > 0 || ice > 0 || sugar > 1 || cups > 0)
            {
                lemons = lemons - 1;
                ice = ice - 1;
                sugar = sugar - 2;
                cups = cups - 1;
            }      
            else
            {
            Console.WriteLine("You no longer have enough ingredients to get through the day. Restock, then try again tomorrow");
            }
            
        }




    }
}
