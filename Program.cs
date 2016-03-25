using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Store testStore = new Store();
            testStore.BuySugar();
            testStore.BuyLemons();
            testStore.BuyIce();
            testStore.BuyCups();
            
        }
    }
}
