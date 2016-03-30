using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace LemonadeStand
{
    class Game
    {
        Store startStore = new Store();
        Player startPlayer = new Player();
        //FileWriter startFileWriter = new FileWriter();
        public int numberOfDays = 7;
        public string choice;
        public void FlashTitle()
        {
            Console.WriteLine(@"
$$\                                                                  $$\                  $$$$$$\    $$\                               $$\ 
$$ |                                                                 $$ |                $$  __$$\   $$ |                              $$ |
$$ |      $$$$$$\  $$$$$$\$$$$\   $$$$$$\  $$$$$$$\   $$$$$$\   $$$$$$$ | $$$$$$\        $$ /  \__|$$$$$$\    $$$$$$\  $$$$$$$\   $$$$$$$ |
$$ |     $$  __$$\ $$  _$$  _$$\ $$  __$$\ $$  __$$\  \____$$\ $$  __$$ |$$  __$$\       \$$$$$$\  \_$$  _|   \____$$\ $$  __$$\ $$  __$$ |
$$ |     $$$$$$$$ |$$ / $$ / $$ |$$ /  $$ |$$ |  $$ | $$$$$$$ |$$ /  $$ |$$$$$$$$ |       \____$$\   $$ |     $$$$$$$ |$$ |  $$ |$$ /  $$ |
$$ |     $$   ____|$$ | $$ | $$ |$$ |  $$ |$$ |  $$ |$$  __$$ |$$ |  $$ |$$   ____|      $$\   $$ |  $$ |$$\ $$  __$$ |$$ |  $$ |$$ |  $$ |
$$$$$$$$\\$$$$$$$\ $$ | $$ | $$ |\$$$$$$  |$$ |  $$ |\$$$$$$$ |\$$$$$$$ |\$$$$$$$\       \$$$$$$  |  \$$$$  |\$$$$$$$ |$$ |  $$ |\$$$$$$$ |
\________|\_______|\__| \__| \__| \______/ \__|  \__| \_______| \_______| \_______|       \______/    \____/  \_______|\__|  \__| \_______|");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine(@"
__                                                                   __                    ______     __                                __
|  \                                                                 |  \                 /      \   |  \                              |  \
| $$       ______   ______ ____    ______   _______    ______    ___ | $$  ______        |  $$$$$$\ _ | $$_     ______   _______  ____ | $$
| $$      /      \ |      \    \  /      \ |       \  |      \  /      $$ /      \       | $$___\$$|   $$ \   |      \ |       \  /      $$
| $$     |  $$$$$$\| $$$$$$\$$$$\|  $$$$$$\| $$$$$$$\  \$$$$$$\|  $$$$$$$|  $$$$$$\       \$$    \  \$$$$$$    \$$$$$$\| $$$$$$$\|  $$$$$$$
| $$     | $$    $$| $$ | $$ | $$| $$  | $$| $$  | $$ /      $$| $$  | $$| $$    $$       _\$$$$$$\   | $$ __ /      $$| $$  | $$| $$  | $$
| $$_____| $$$$$$$$| $$ | $$ | $$| $$__/ $$| $$  | $$|  $$$$$$$| $$__| $$| $$$$$$$$      |  \__| $$  | $$|  \|  $$$$$$$| $$  | $$| $$__| $$
| $$     \\$$     \| $$ | $$ | $$ \$$    $$| $$  | $$ \$$    $$ \$$    $$ \$$     \       \$$    $$   \$$  $$ \$$    $$| $$  | $$ \$$    $$
 \$$$$$$$$ \$$$$$$$ \$$  \$$  \$$  \$$$$$$  \$$   \$$  \$$$$$$$  \$$$$$$$  \$$$$$$$        \$$$$$$     \$$$$   \$$$$$$$ \$$   \$$  \$$$$$$$
                                                                                                                                           ");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine(@"
$$\                                                                  $$\                  $$$$$$\    $$\                               $$\ 
$$ |                                                                 $$ |                $$  __$$\   $$ |                              $$ |
$$ |      $$$$$$\  $$$$$$\$$$$\   $$$$$$\  $$$$$$$\   $$$$$$\   $$$$$$$ | $$$$$$\        $$ /  \__|$$$$$$\    $$$$$$\  $$$$$$$\   $$$$$$$ |
$$ |     $$  __$$\ $$  _$$  _$$\ $$  __$$\ $$  __$$\  \____$$\ $$  __$$ |$$  __$$\       \$$$$$$\  \_$$  _|   \____$$\ $$  __$$\ $$  __$$ |
$$ |     $$$$$$$$ |$$ / $$ / $$ |$$ /  $$ |$$ |  $$ | $$$$$$$ |$$ /  $$ |$$$$$$$$ |       \____$$\   $$ |     $$$$$$$ |$$ |  $$ |$$ /  $$ |
$$ |     $$   ____|$$ | $$ | $$ |$$ |  $$ |$$ |  $$ |$$  __$$ |$$ |  $$ |$$   ____|      $$\   $$ |  $$ |$$\ $$  __$$ |$$ |  $$ |$$ |  $$ |
$$$$$$$$\\$$$$$$$\ $$ | $$ | $$ |\$$$$$$  |$$ |  $$ |\$$$$$$$ |\$$$$$$$ |\$$$$$$$\       \$$$$$$  |  \$$$$  |\$$$$$$$ |$$ |  $$ |\$$$$$$$ |
\________|\_______|\__| \__| \__| \______/ \__|  \__| \_______| \_______| \_______|       \______/    \____/  \_______|\__|  \__| \_______|");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine(@"
__                                                                   __                    ______     __                                __
|  \                                                                 |  \                 /      \   |  \                              |  \
| $$       ______   ______ ____    ______   _______    ______    ___ | $$  ______        |  $$$$$$\ _ | $$_     ______   _______  ____ | $$
| $$      /      \ |      \    \  /      \ |       \  |      \  /      $$ /      \       | $$___\$$|   $$ \   |      \ |       \  /      $$
| $$     |  $$$$$$\| $$$$$$\$$$$\|  $$$$$$\| $$$$$$$\  \$$$$$$\|  $$$$$$$|  $$$$$$\       \$$    \  \$$$$$$    \$$$$$$\| $$$$$$$\|  $$$$$$$
| $$     | $$    $$| $$ | $$ | $$| $$  | $$| $$  | $$ /      $$| $$  | $$| $$    $$       _\$$$$$$\   | $$ __ /      $$| $$  | $$| $$  | $$
| $$_____| $$$$$$$$| $$ | $$ | $$| $$__/ $$| $$  | $$|  $$$$$$$| $$__| $$| $$$$$$$$      |  \__| $$  | $$|  \|  $$$$$$$| $$  | $$| $$__| $$
| $$     \\$$     \| $$ | $$ | $$ \$$    $$| $$  | $$ \$$    $$ \$$    $$ \$$     \       \$$    $$   \$$  $$ \$$    $$| $$  | $$ \$$    $$
 \$$$$$$$$ \$$$$$$$ \$$  \$$  \$$  \$$$$$$  \$$   \$$  \$$$$$$$  \$$$$$$$  \$$$$$$$        \$$$$$$     \$$$$   \$$$$$$$ \$$   \$$  \$$$$$$$
                                                                                                                                           ");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine(@"
$$\                                                                  $$\                  $$$$$$\    $$\                               $$\ 
$$ |                                                                 $$ |                $$  __$$\   $$ |                              $$ |
$$ |      $$$$$$\  $$$$$$\$$$$\   $$$$$$\  $$$$$$$\   $$$$$$\   $$$$$$$ | $$$$$$\        $$ /  \__|$$$$$$\    $$$$$$\  $$$$$$$\   $$$$$$$ |
$$ |     $$  __$$\ $$  _$$  _$$\ $$  __$$\ $$  __$$\  \____$$\ $$  __$$ |$$  __$$\       \$$$$$$\  \_$$  _|   \____$$\ $$  __$$\ $$  __$$ |
$$ |     $$$$$$$$ |$$ / $$ / $$ |$$ /  $$ |$$ |  $$ | $$$$$$$ |$$ /  $$ |$$$$$$$$ |       \____$$\   $$ |     $$$$$$$ |$$ |  $$ |$$ /  $$ |
$$ |     $$   ____|$$ | $$ | $$ |$$ |  $$ |$$ |  $$ |$$  __$$ |$$ |  $$ |$$   ____|      $$\   $$ |  $$ |$$\ $$  __$$ |$$ |  $$ |$$ |  $$ |
$$$$$$$$\\$$$$$$$\ $$ | $$ | $$ |\$$$$$$  |$$ |  $$ |\$$$$$$$ |\$$$$$$$ |\$$$$$$$\       \$$$$$$  |  \$$$$  |\$$$$$$$ |$$ |  $$ |\$$$$$$$ |
\________|\_______|\__| \__| \__| \______/ \__|  \__| \_______| \_______| \_______|       \______/    \____/  \_______|\__|  \__| \_______|");
            Thread.Sleep(500);
        }
        

        public void StartGame()
        {
            FlashTitle();
            startPlayer.GetUserInfo();
            GameInfo();

            if (startStore.ShowMoney() > 0)
            {
                for (int dayIndex = 1; dayIndex <= numberOfDays; dayIndex++)
                {
                    Console.Clear();
                    Console.WriteLine("Day {0} of your Lemonade stand.", dayIndex);
                    startStore.GetWeather();
                    startStore.BuyLemons();
                    startStore.BuyIce();
                    startStore.BuySugar();
                    startStore.BuyCups();
                    startStore.inputPrice();
                    startStore.DetermineWillBuyPrice();
                    startStore.ShowPurchased();
                    startStore.ShowDidNotPurchase();
                    //startFileWriter.WriteInventory();                                      
                    Console.WriteLine("Press any key to start the next day");
                    Console.ReadKey();               
                }
                EndGame();
            }
            else
            {
                EndGame();
            }
        }
        public void EndGame ()
        {
            Console.WriteLine("The game has ended.  Would you like to try again?");
            choice = Console.ReadLine();
            bool correct = true;
            while (correct)
            {
                switch (choice)
                {

                    case ("yes"):
                        StartGame();
                        break;
                    case ("Yes"):
                        StartGame();
                        break;
                    case ("no"):
                        Environment.Exit(0);
                        break;
                    case ("No"):
                        Environment.Exit(0);
                        break;
                    default:
                        correct = false;
                        Console.WriteLine("Please try again, incorrect input.");
                        break;
                }
            }
        }

        public void GameInfo()
        {
            Console.WriteLine("Hello {0}!!", startPlayer.name);
            Console.WriteLine("Welcome to my Lemonade Stand!!!");
            Console.WriteLine("This game takes place across seven days.  Each glass of Lemonade needs a Cup, a Cup of Ice, two Servings of Sugar, and a Lemon.");
            Console.WriteLine("Make sure you have enough ingredients to get through each day, or the day will end early!");
            Console.WriteLine("You start the game with $7.00.");
            Console.WriteLine("Press any key to start the game!!!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}