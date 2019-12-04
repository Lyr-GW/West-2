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
        public static int finalBattleChoose()
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------------");
                if (Player.HP <= 0)
                {
                    Console.WriteLine("你死了");
                    return -1;                   
                }
                if (WeiMin2Heart.HP <= 0 && Player.HP > 0)
                {
                    Begin.finalVictory();
                    return 0;
                }
                Console.WriteLine("你的血量: " + Player.HP + "\t苇名二心的血量：" + WeiMin2Heart.HP);
                Console.WriteLine("选择你的下一步:    1.攻击(5体力)    2.防御(2体力)   3.发动技能(10体力)" + "你当前剩余体力: " + Player.POW);
                Console.Write("请输入选择:  ");
                string choi = Console.ReadLine();
                if (choi == "1")
                {
                    Player.POW -= 5;
                    return 1;
                }
                else if(choi == "2")
                {
                    Player.POW -= 2;
                    return 2;
                }
                else if(choi == "3")
                {
                    Player.POW -= 10;
                    return 3;
                }
                else
                {
                    Console.WriteLine("重新选择哟");
                }
            }
        }
        public static int capitalBattleChoose()
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------------");
                if (Player.HP <= 0)
                {
                    Console.WriteLine("你死了");
                    return -1;
                }
                if (Capital.HP <= 0 && Player.HP > 0)
                {
                    Begin.finalVictory();
                    return 0;
                }
                Console.WriteLine("你的血量: " + Player.HP + "\t骑马队长的血量：" + Capital.HP);
                Console.WriteLine("选择你的下一步:    1.攻击(5体力)    2.防御(2体力)   3.发动技能(10体力)" + "你当前剩余体力: " + Player.POW);
                Console.Write("请输入选择:  ");
                string choi = Console.ReadLine();
                if (choi == "1")
                {
                    Player.POW -= 5;
                    return 1;
                }
                else if (choi == "2")
                {
                    Player.POW -= 2;
                    return 2;
                }
                else if (choi == "3")
                {
                    Player.POW -= 10;
                    return 3;
                }
                else
                {
                    Console.WriteLine("重新选择哟");
                }
            }
        }
    }
}
