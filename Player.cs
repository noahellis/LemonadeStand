using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;

        //public Player()
        //{

        //}
        public void GetUserInfo()
        {
            Console.WriteLine("Please enter your Name");
            name = Console.ReadLine();
        }

       

       
    }
}
