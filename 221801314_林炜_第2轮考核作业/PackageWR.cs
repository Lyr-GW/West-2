using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace RPG
{
    class PackageWR
    {
        private static string jsonString = "Package.json";

        public static void packageAdd(string s)
        {
            string jsonFile = File.ReadAllText(jsonString);
            JObject jo = JObject.Parse(jsonString);
            //JObject addTemp = JsonConvert.SerializeObject();
        }
        public static void packageDelete(string s,string sec)
        {
            
            //s传入weapon/clothes/其他...
            string jsonFile = File.ReadAllText(jsonString);
            JObject jo = JObject.Parse(jsonString);
            JObject tokenSelect = jo.SelectToken(s) as JObject; //嵌套
            tokenSelect.Remove(sec);      
        }
    }
}
