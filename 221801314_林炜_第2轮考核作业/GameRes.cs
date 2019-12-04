using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RPG
{
    public class Weapon
    {
        public string name { get; set; }
        public int atk { get; set; }
        public int price { get; set; }

    }
    public class Clothes
    {
        public string name { get; set; }
        public int def { get; set; }
        public int price { get; set; }
    }



    ////////////////////////////
    public class DetailInfo
    {
        public string name { get; set; }
        public int value { get; set; }
        public int price { get; set; }
    }
    public class JsonInfo
    {
        //public string type { get; set; }
        //public DetailInfo[] details;
        List<DetailInfo> detailInfo = new List<DetailInfo>();
        public List<DetailInfo> detailInfos
        {
            get { return detailInfo; }
            set { detailInfo = value; }
        }
      

    }
    public class Enemy
    {
        public string name;
        public int atk;
        public int HP;
        public int bonus;

        private Enemy Clone()
        {
            Enemy temp = new Enemy();

            temp.name = this.name;
            temp.atk = this.atk;
            temp.HP = this.HP;
            temp.bonus = this.bonus;
            return temp;
        }
    }

    class GameRes
    {
        public static string GetJsonFile(string filepath)
        {
            string json = string.Empty;
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    json = sr.ReadToEnd().ToString();
                }
            }
            return json;
        }

    public static void EditJson(string editString,int intChoi)
        {
            string jsonFile = @"S:\Unity_West2\RPG\RPG\GameRes.json";
            StreamReader file = File.OpenText(jsonFile);
            JsonTextReader reader = new JsonTextReader(file);
            JObject jobject = (JObject)JToken.ReadFrom(reader);
            jobject["weapon"][intChoi - 1]["status"] = "1";
            string convertString = jobject.ToString();
            File.WriteAllText(jsonFile, convertString);
            Console.WriteLine("成功购买");
        }
    
    public static bool LoadJSonWeapon()
        {
            //string jsonData = GetJsonFile(@"S:\Unity_West2\RPG\RPG\GameRes.json");
            string jsonFile = @"S:\Unity_West2\RPG\RPG\GameRes.json";


            StreamReader file = File.OpenText(jsonFile);
            JsonTextReader reader = new JsonTextReader(file);
            JObject jobject = (JObject)JToken.ReadFrom(reader);
            //可用jobject访问json文件
            if (jobject == null)
            {
                Console.WriteLine("json读取失败");
                return false;
            }
            Console.WriteLine();
            Console.WriteLine("1--名称:\t"+jobject["weapon"][0]["name"]);
            Console.WriteLine("   攻击力:\t" + jobject["weapon"][0]["value"]);
            Console.WriteLine("   价格:\t" + jobject["weapon"][0]["price"]);
            if(jobject["weapon"][0]["status"].ToString() == "1")
            {
                Console.WriteLine("\t"+"（已售出）");
            }
            Console.WriteLine();
            Console.WriteLine("2--名称:\t" + jobject["weapon"][1]["name"]);
            Console.WriteLine("   攻击力:\t" + jobject["weapon"][1]["value"]);
            Console.WriteLine("   价格:\t" + jobject["weapon"][1]["price"]);
            if (jobject["weapon"][1]["status"].ToString() == "1")
            {
                Console.WriteLine("\t" + "（已售出）");
            }
            Console.WriteLine();
            Console.WriteLine("3--名称:\t" + jobject["weapon"][2]["name"]);
            Console.WriteLine("   攻击力:\t" + jobject["weapon"][2]["value"]);
            Console.WriteLine("   价格:\t" + jobject["weapon"][2]["price"]);
            if (jobject["weapon"][0]["status"].ToString() == "1")
            {
                Console.WriteLine("\t" + "（已售出）");
            }
            Console.WriteLine();
            return true;
            //string weap = "weapon";
            //string cloth = "clothes";
            //List<JsonInfo> jsonInfos = new List<JsonInfo>();
            //jsonInfos = JsonConvert.DeserializeObject<List<JsonInfo>>(jsonData);

            //Console.WriteLine(jsonInfos[0].detailInfos[0].name); 
            //for(int i = 0; i < jsonInfos.Count; i++)
            //{
            //    Console.WriteLine("\t"+i);
            //    //DetailInfo[] details = jsonInfos[i].details;
            //    List<DetailInfo> detailInfos = jsonInfos[i].detailInfos;
            //    foreach (var item in detailInfos)
            //    {
            //        Console.WriteLine("name:"+item.name);
            //        Console.WriteLine("value:"+item.value);
            //        Console.WriteLine("price:"+item.price);
            //    }
            //}
            //Console.ReadKey();

        }
        public static bool LoadJSonClothes()
        {           
            string jsonFile = @"S:\Unity_West2\RPG\RPG\GameRes.json";
            StreamReader file = File.OpenText(jsonFile);
            JsonTextReader reader = new JsonTextReader(file);
            JObject jobject = (JObject)JToken.ReadFrom(reader);
            
            if (jobject == null)
            {
                Console.WriteLine("json读取失败");
                return false;
            }
            Console.WriteLine();
            Console.WriteLine("1--名称:\t" + jobject["clothes"][0]["name"]);
            Console.WriteLine("   防御力:\t" + jobject["clothes"][0]["value"]);
            Console.WriteLine("   价格:\t" + jobject["clothes"][0]["price"]);
            if (jobject["clothes"][0]["status"].ToString() == "1")
            {
                Console.WriteLine("\t" + "（已售出）");
            }
            Console.WriteLine();
            Console.WriteLine("2--名称:\t" + jobject["clothes"][1]["name"]);
            Console.WriteLine("   防御力:\t" + jobject["clothes"][1]["value"]);
            Console.WriteLine("   价格:\t" + jobject["clothes"][1]["price"]);
            if (jobject["clothes"][1]["status"].ToString() == "1")
            {
                Console.WriteLine("\t" + "（已售出）");
            }
            Console.WriteLine();
            Console.WriteLine("3--名称:\t" + jobject["clothes"][2]["name"]);
            Console.WriteLine("   防御力:\t" + jobject["clothes"][2]["value"]);
            Console.WriteLine("   价格:\t" + jobject["clothes"][2]["price"]);
            if (jobject["clothes"][0]["status"].ToString() == "1")
            {
                Console.WriteLine("\t" + "（已售出）");
            }
            Console.WriteLine();
            return true;        
        }
        public static void ReadJson(string key)
        {
        //    string jsonPath = @"S:\Unity_West2\RPG\RPG\GameRes.json";
        //    StreamReader file = File.OpenText(jsonPath);
        //    JsonTextReader reader = new JsonTextReader(file);
        //    JObject jo = (JObject)JToken.ReadFrom(reader);
        //    var value = jo[key].ToString();
        //    return value;
        }
    }
}
