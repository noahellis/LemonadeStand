using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class FileWriter
    {
        public void WriteInventory()
        {
            string[] inventoryLines = { "Day: {0}", "Money: {1:C2}", "Lemons: {2}", "Ice: {3}", "Sugar: {4}", "Cups: {5}"};
            System.IO.File.WriteAllLines(@"C:\Users\Noah\Documents\Visual Studio 2015\Projects\LemonadeStand\LemonadeStand\LemonadeStandInfo.txt", inventoryLines);
        }
    }
}
