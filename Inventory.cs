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
        public double money = 7.00;
        public bool enoughInventory;
        public void SubtractInventory()
        {
                lemons = lemons - 1;
                ice = ice - 1;
                sugar = sugar - 2;
                cups = cups - 1;          
        }

        public bool CheckInventory()
        {
            if (lemons >=1 && ice >=1 && sugar >=2 && cups >=1)
                enoughInventory = true;
            else
            {
                enoughInventory = false;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You ran out of product before you could serve all your customers!! Buy more and try again tomorrow!!");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            
            return enoughInventory;
        }
        public void DisplayCashAndInventory()
        {
            Console.WriteLine("Inventory: {0} Lemons, {1} Servings of Sugar, {2} Cups, {3} Cups of Ice", lemons, sugar, cups, ice);
            Console.WriteLine("Money: {0:C2}", money);

        }
    }
}