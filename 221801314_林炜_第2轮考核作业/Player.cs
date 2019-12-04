using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Player
    {
        static public string name;
        static public int atk = 10;//后期设成当前武器攻击力
        static public string skill = "降龙十巴掌";
        static public int percent = 30;
        static public int skillAtk = 50;
        //static public string weapon1;
        //static public string weapon2;
        //static public string armor;
        static public string[] package;
        public const int PACKMAXN = 20;
        static public int HP = 100;
        static public int POW = 30;
        static public int wallet = 20;
        //static public int packageCurPosi = 0;//当前背包位置
    }
    class WeiMin2Heart
    {
        static public string name = "苇名二心";
        static public int atk = 40;
        static public string skill;
        static public int percent = 20;
        static public int HP = 300;
        
    }
    class Capital
    {
        static public string name = "骑马队长";
        static public int atk = 20;
        static public string skill;
        static public int percent = 20;
        static public int HP = 50;

    }
}
