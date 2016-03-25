using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string Name = Console.ReadLine();
        public double money = 20;
        public Player()
        {
            
        }
        public void GetUserInfo()
        {
            Console.WriteLine("Please enter your Name");
            Name = Console.ReadLine();
        }

        public void TrackUserMoney()
        {

        }

       
    }
}
