using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Battle
    {
        //Player player = new Player();

        private static void printInfo()
        {
            Enemy enemy = new Enemy();
            Console.WriteLine("战斗开始！！！");
            Console.WriteLine("{0} vs {1}",Player.name,enemy.name);
        }
        public static void start()
        {
            printInfo();
        }
    }
}
