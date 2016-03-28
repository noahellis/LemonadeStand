using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonadeSales
    {
        Store inventoryCount = new Store();
        public int remainingLemons;  //need to link these to store purchases
        public int remainingIce;
        public int remainingSugar;
        public int remainingCups;
        //Customer purchasingCustomer = new Customer();
        
        public void GetIngredientCount()
        {
            remainingLemons = inventoryCount.lemons;
            remainingIce = inventoryCount.ice;
            remainingSugar = inventoryCount.sugar;
            remainingCups = inventoryCount.cups;
        }
        public void SubtractIngredients()
        {
            do
            {
                remainingLemons = inventoryCount.lemons - 1;
                remainingIce = inventoryCount.ice - 1;
                remainingSugar = inventoryCount.sugar - 2;
                remainingCups = inventoryCount.cups - 1;
            }
            while (remainingCups > 0 || remainingSugar > 0 || remainingIce > 0 || remainingLemons > 0);                    
                     
                
            Console.WriteLine("You no longer have enough ingredients to get through the day. Restock, then try again tomorrow");
        }

            //subtract ingredients for each buying customer (ingredient type starting -(sales * ingredient type))
            //need to add code to end the day if user runs out of any kind of ingredient
            //decrement ingredients until one reaches 0 or all customers go through line
        

        public void AddMoney()
        {
            //add sales from variable inputted by user, multiplied by number of sales
        }

        
    }
}
