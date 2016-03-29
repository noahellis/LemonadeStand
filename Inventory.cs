﻿using System;
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
            if (lemons > 0 && ice > 0 && sugar > 1 && cups >0)
                enoughInventory = true;           
            else
                enoughInventory = false;
            return enoughInventory;
        }
    }
}