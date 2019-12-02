using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Player
    {
        static public string name;
        static public int atk;
        static public string skill;
        static public int percent;
        static public int skillAtk;
        //static public string weapon1;
        //static public string weapon2;
        //static public string armor;
        static public string[] package;
        public const int PACKMAXN = 20;
        static public int HP = 100, POW = 100;
        static public int wallet = 20;
        static public int packageCurPosi = 0;//当前背包位置
    }
}
