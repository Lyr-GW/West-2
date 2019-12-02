using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace RPG
{
    class Begin
    {
        public static void startPage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\t~      CyberPunk-2078     ~");
            Console.WriteLine("\t~                         ~");
            Console.WriteLine("\t~       1.开始游戏        ~");
            Console.WriteLine("\t~                         ~");
            Console.WriteLine("\t~       2.退出游戏        ~");
            Console.WriteLine("\t~                         ~");
            Console.WriteLine("\t~                         ~");
            Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
            Console.WriteLine("  请选择:");
            string choi = Console.ReadLine();
            
            if(choi == "1")
            {
                Start();//
            }
            if(choi == "2")
            {
                Console.WriteLine("\t\t成功退出");
                Thread.Sleep(100);
                Environment.Exit(0);
                
            }
            else
            {
                Console.WriteLine("\t  错误输入,请重试");
                Console.ReadKey();
                Console.Clear();
                startPage();
            }
            

        }
        public static void Start()
        {
            plotIntroduce();
            createPlayer();
            chooseRoad();
        }
        public static void plotIntroduce()
        {//开场
            Console.WriteLine("--你醒了....\n--抬眼望去..四周都是荒原....\n\"怎么回事..\"--...你似乎什么事情都不记得了....\n(按任意键继续)");
            Console.ReadKey();
        }
        public static void createPlayer()
        {//角色创建
            Console.WriteLine("我是谁？..这又是哪..  (请输入角色名字“回车”结束)");
            Player.name = Console.ReadLine();
            Console.WriteLine("--你找到了你的剑，上面刻着 " + Player.name);
            Console.ReadKey();
            Console.WriteLine("我是" + Player.name + "?..大概吧..不重要了...");
            Console.ReadKey();
        }
        public static void chooseRoad()
        {
            Console.WriteLine("我觉得我现在应该去找个有人的地方先吃个饭...肚子已经在叫了..");
            Console.ReadKey();
            Console.WriteLine("--你看到了左边似乎有一些白烟，但不是很确定；右边貌似什么也没有...\n(请选择你要前往的方向 输入R/L)...");
            while (true)
            {
                string choi = Console.ReadLine();
                if (choi == "R" || choi == "r")
                {
                    Console.Clear();
                    Console.WriteLine("--你相信你的直觉走向了右边..");
                    Console.ReadKey();
                    chooseRight();
                    break;
                }
                else if (choi == "L" || choi == "l")
                {
                    Console.Clear();
                    Console.WriteLine("--你觉得白烟那应该会有人家，你便动身去向了左边..");
                    Console.ReadKey();
                    chooseLeft();
                    break;
                }
                else
                {
                    Console.WriteLine("--Oops..你似乎要失去同步了（重新选一次吧~ 输入R/L）");
                }
            }
        }
        public static void chooseRight()
        {
            Console.WriteLine("--这条路似乎十分的漫长...");
            Console.ReadKey();
            Console.WriteLine("--荒漠上真的是什么都没有,除了偶尔见到的一两棵仙人掌..");
            Console.ReadKey();
            Console.WriteLine("--又翻过一个沙坡后...");
            Console.ReadKey();
            Console.WriteLine("--你看到了一个小酒馆！！！门口有三四匹骆驼,看起来人很多的亚子 WOW~");
            Console.ReadKey();
            //此处可加偷骆驼选项 但有可能BE
            Console.WriteLine("--你走进了酒馆..许多西域的面孔...");
            Console.ReadKey();
            Console.WriteLine(@"“客官里边请~ ~ 您要点什么？”小二热情地迎上来");
            Console.ReadKey();
            Console.WriteLine(@"“来点什么呢?客官~”小二递过了菜单..");
            Console.ReadKey();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-              * * *                -");
            Console.WriteLine("-             -主 菜-               -");
            Console.WriteLine("-          1. 红烧一头狮子          -");
            Console.WriteLine("-          2. 清蒸一只野猪          -");
            Console.WriteLine("-          3. 白 米 饭              -");
            Console.WriteLine("-                                   -");
            Console.WriteLine("-             -酒 水-               -");
            Console.WriteLine("-          1. 82年精酿雪碧          -");
            Console.WriteLine("-          2. 2077特供拉菲          -");
            Console.WriteLine("-          3.纯净水星深层矿泉水     -");
            Console.WriteLine("-                                   -");
            Console.WriteLine("-------------------------------------");
            Console.ReadKey();
            Console.WriteLine("--你想吃什么呢？");
            while (true)
            {
                Console.WriteLine("1. 白米饭 2.矿泉水 --其他的你都买不起哦ooo~~~");
                string choi = Console.ReadLine();
                if (choi == "1")
                {
                    chooseRice();
                    break;
                }
                else if (choi == "2")
                {
                    chooseWater();
                    break;
                }
                else if (choi == "3")
                {
                    chooseHiddenMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("--不吃饭会饿死哦,看看吃点啥呗？");
                }
            }
            /////////这边没写！！！！
        }
        public static void chooseRice()
        {
            Console.Clear();
            Console.WriteLine("--你吃下了一碗白米饭..这饭居然有点夹生..");
            Console.ReadKey();
            Console.WriteLine("“算了..能填饱肚子就行”你心想到");
            Console.ReadKey();
            Console.WriteLine("--你起身准备离开");
            Console.ReadKey();
            Console.WriteLine("“少侠留步！”");
            Console.ReadKey();
            Console.WriteLine("--你回头见是一名着黑衣戴黑兜帽的男子在角落处叫住了你..");
            Console.ReadKey();
            Console.WriteLine("--你坐到他的对面,正想开口");
            Console.ReadKey();
            Console.WriteLine("“先不急问我是谁 我见你眉清目秀,骨骼精奇");
            Console.ReadKey();
            Console.WriteLine("“一看你就不是NPC吧（滑稽）”");
            Console.ReadKey();
            Console.WriteLine(". . . ");
            Console.ReadKey();
            Console.WriteLine("“好了说正事,近日有许多人在这小镇附近为非作歹...");
            Console.ReadKey();
            Console.WriteLine("“我看你是能成大事之人,不知你是否与我一同去除了这些歹人？”");
            Console.ReadKey();
            Console.WriteLine("是否要与他同去？ 1.当然  2.我不");
            string choi = Console.ReadLine();
            if(choi == "1")
            {
                Console.WriteLine("“成大事不敢当,但这些歹人我很乐意能帮得上忙。”");
            }
            else
            {
                Console.WriteLine("--我知道你是口是心非的,那就当你同意了吧~");
                Console.ReadKey();
                Console.WriteLine("--你默默地点了下头");
                Console.ReadKey();
            }
            //Console.WriteLine("“我知道附近有个好的铁匠铺子,整件趁手的兵器先吧”");
            Console.WriteLine("“附近正好有些店家,不如先准备些东西,之后也方便些~”");
            Console.ReadKey();
            Console.WriteLine("--你点头,跟着他上了集市..");
            toTheWeaponStore();
            toTheClothesStore();

            toFinalPlace();
            //选择分支
        }
        public static void chooseWater()
        {
            Console.Clear();
            Console.WriteLine("--你一口喝完了这瓶纯净水星深层矿泉水,不知为何有点像漂白水的味道..也许水星的水不太一样吧..");
            Console.ReadKey();
            Console.WriteLine("--你走出了店门...");
            Console.ReadKey();
            Console.WriteLine("--你刚走进一条小路,就被一群小混混围了起来");
            Console.ReadKey();
            Console.WriteLine("--你嗅到了一丝战斗的气息~~");
            Console.ReadKey();
            Console.WriteLine("--从人群后走来一个瘦高男子,嘴中仍嚼着口香糖");
            Console.WriteLine("“我见小哥你的剑怪好看的,不知可否借我把玩几天？”瘦高男子道");
            Console.ReadKey();
            Console.WriteLine("“不好意思,我的剑认人,恐怕不能给你”");
            Console.ReadKey();
            Console.WriteLine("“哦？那似乎还是把好剑。那我今天倒是非借不可咯！”说罢便冲上来要夺这剑");
            Console.ReadKey();
            Console.WriteLine("------战斗开始------");
            Console.ReadKey();
            ///////////这边没写完！！！！！！！！
            Battle.start();
        }
        public static void chooseHiddenMenu()
        {//         E N D I N G----撑死
            Console.Clear();
            Console.WriteLine("--什么?!给了1,2你却选了3？？ 那好吧,只好给你上隐藏的菜单了");
            Console.ReadKey();
            Console.WriteLine("“小二！快把客人请到SVIP包厢~”");
            Console.ReadKey();
            Console.WriteLine("“得嘞! 客官您这边请~”");
            Console.ReadKey();
            Console.WriteLine("--你跟着小二到了SVIP包厢,这包厢的确不一样..");
            Console.ReadKey();
            Console.WriteLine("--房间中间就是一个四百平米的大桌子,周围也都是各式各样的古董书画与名贵摆件儿");
            Console.ReadKey();
            Console.WriteLine("--你刚坐上铁王座不一会,菜就上上了");
            Console.ReadKey();
            Console.WriteLine("小二:“请容我介绍一下这些菜名:");
            Console.ReadKey();
            string menu = " 蒸羊羔、蒸熊掌、蒸鹿尾儿、烧花鸭、烧雏鸡、烧子鹅，\n" +
                "  卤猪、卤鸭、酱鸡、腊肉、松花、小肚儿、晾肉、香肠儿，\n" +
                "  什锦苏盘儿、熏鸡白肚儿、清蒸八宝猪、江米酿鸭子，\n" +
                "  罐儿野鸡、罐儿鹌鹑、卤什件儿、卤子鹅、山鸡、兔脯、菜蟒、银鱼、清蒸哈士蟆！\n" +
                "  烩腰丝、烩鸭腰、烩鸭条、清拌鸭丝儿、黄心管儿，\n" +
                "  焖白鳝、焖黄鳝、豆豉鲶鱼、锅烧鲤鱼、锅烧鲶鱼、清蒸甲鱼、抓炒鲤鱼、抓炒对虾、软炸里脊、软炸鸡！\n" +
                "  什锦套肠儿、麻酥油卷儿、卤煮寒鸦儿，熘鲜蘑、熘鱼脯、熘鱼肚、熘鱼骨、熘鱼片儿、醋熘肉片儿！\n" +
                "  烩三鲜儿、烩白蘑、烩全饤儿、烩鸽子蛋、炒虾仁儿、烩虾仁儿、烩腰花儿、烩海参、\n" +
                "  炒蹄筋儿、锅烧海参、锅烧白菜、炸开耳、炒田鸡，还有桂花翅子、清蒸翅子、炒飞禽、炸什件儿、清蒸江瑶柱、，\n" +
                "  拌鸡丝、拌肚丝、什锦豆腐、什锦丁儿，糟鸭、糟蟹、糟鱼、糟熘鱼片、熘蟹肉、炒蟹肉、清拌蟹肉，\n" +
                "  蒸南瓜、酿倭瓜、炒丝瓜、酿冬瓜、焖鸡掌儿、焖鸭掌儿、焖笋、烩茭白，茄干晒炉肉、鸭羹、蟹肉羹、三鲜木樨汤！\n" +
                "  红丸子、白丸子、熘丸子、炸丸子、南煎丸子、苜蓿丸子、三鲜丸子、四喜丸子、鲜虾丸子、鱼脯丸子、饹炸丸子、豆腐丸子！\n" +
                "  一品肉、樱桃肉、马牙肉、红焖肉、黄焖肉、坛子肉、烀肉、扣肉、松肉、罐儿肉、烧肉、烤肉、大肉、白肉、酱豆腐肉！\n" +
                "  红肘子、白肘子、水晶肘子、蜜蜡肘子、酱豆腐肘子、扒肘子！\n" +
                "  炖羊肉、烧羊肉、烤羊肉、煨羊肉、涮羊肉、五香羊肉、爆羊肉，\n" +
                "  氽三样儿、爆三样儿、烩银丝、烩散丹、熘白杂碎、三鲜鱼翅、栗子鸡、煎氽活鲤鱼、板鸭、筒子鸡\n";
            foreach(char ch in menu)
            {
                Console.Write(ch);
                Thread.Sleep(20);
            }
            
            Console.ReadKey();
            Console.WriteLine("“客官~菜齐了~”小二说到,“你有什么事叫我便是,小的先退下了”");
            Console.ReadKey();
            Console.WriteLine("--短暂地震惊过后,你便得意地吃了起来~~~");
            Console.ReadKey();
            Console.WriteLine("天色渐渐黑了...但桌上仍是满满当当,你更努力地吃了起来！！");
            Console.ReadKey();
            Console.WriteLine(". . . ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--第二天");
            Console.ReadKey();
            Console.WriteLine("--小二醒来才发现自己在包厢外睡了一夜,但包厢里没了动静");
            Console.ReadKey();
            Console.WriteLine("--小二一进门发现..你已没了气息...");
            Console.ReadKey();
            Console.WriteLine(". . . ");
            Console.ReadKey();
            Console.WriteLine("\t#你死了.. --死因:撑死");
            Console.ReadKey();
            Console.WriteLine("--正在返回开始菜单...");
            Thread.Sleep(500);
            Console.Clear();
            Begin.startPage();
        }
        public static void chooseLeft()
        {
            Console.WriteLine("--那白烟似乎一直远在天边,怎么也走不到...");
            Console.ReadKey();
            Console.WriteLine("--晌午,依稀看见了一些黑瓦");
            Console.ReadKey();
            Console.WriteLine("--你不由得加快了脚步");
            Console.ReadKey();
            Console.WriteLine("--咚...(疲惫的你倒在了村口)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--..再睁眼时发现自己躺在床上");
            Console.ReadKey();
            Console.WriteLine("“你醒啦~”只见一个农家姑娘走上前来");
            Console.ReadKey();
            Console.WriteLine("“来喝点粥吧~”,接过后你才发现已经傍晚");
            Console.ReadKey();
            Console.WriteLine("“看你这样不像是“三合会”的人,你是为何会出现在村口的？”");
            Console.ReadKey();
            Console.WriteLine("--你说了自己在沙漠中迷路找到这来的过程...也不紧好奇三合会是个什么组织");
            Console.ReadKey();
            Console.WriteLine("“哦~~ 一个人到沙漠里还是挺危险的”");
            Console.ReadKey();
            Console.WriteLine("“倒是你说的“三合会”是什么呀？”");
            Console.ReadKey();
            Console.WriteLine("“那些恶棍你不知道吗?!他们经常就是来各个村子掳掠,无恶不作!”姑娘无比生气");
            Console.ReadKey();
            Console.WriteLine("“他们经常会晚上出动来骚扰我们村庄！我们的粮食都不剩下多少了..”");
            Console.ReadKey();
            Console.WriteLine("“那这粥....”");
            Console.ReadKey();
            Console.WriteLine("--叮铃!叮铃!叮铃!");
            Console.ReadKey();
            Console.WriteLine("“糟了!他们又来了! 你快先躲起来!”");
            Console.ReadKey();
            Console.WriteLine("--你微微一笑走出了门,从腰间抽出了你的刀");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--出门只见村口处几点火苗飞速靠近...");
            Console.ReadKey();
            Console.WriteLine("--待到近处方才看清几个人在马上提着刀扎着头巾立在村口...");
            Console.ReadKey();
            Console.WriteLine("“这次的保护费是你们自己主动,还是又要我们去取啊 ！~ ~”,马上的一人高喊道");
            Console.ReadKey();
            Console.WriteLine("--你走至路中央,那头目似是看见了你...");
            Console.ReadKey();
            Console.WriteLine("“他们的粮给我做了粥,已经没有你的份了”,你说");
            Console.ReadKey();
            Console.WriteLine("--那人额上青筋渐渐暴起..");
            Console.ReadKey();
            Console.WriteLine("“你是哪来的杂碎,来碍我们三合会的事？你今天算是栽在我手里了！”");
            Console.ReadKey();
            Console.WriteLine("--说罢那人便拍马冲上前来");
            //string name = "三合会小队头目";
            ////////每个剧情独立战斗吧
            Battle.start();//带剧情战斗？
        }
        public static void leftBattleVictory()
        {//在和骑马队长战斗胜利之后
            //Console.Clear();
            Console.WriteLine("--骑马队长在那一击之后,连人带马地摔在地上");
            Console.ReadKey();
            Console.WriteLine("“快滚吧,不要再来了”你浅浅地说道");
            Console.ReadKey();
            Console.WriteLine("“你小子别太得意了！我们大哥回来收拾你的！”那队长悻悻地说着,“兄弟们先撤!”");
            Console.ReadKey();
            Console.WriteLine("--你成功地击退了敌人! 村庄得救了! ");
            Console.ReadKey();
            Console.WriteLine("--村民都纷纷来表示感谢...那姑娘眼里也满是笑意~");
            Console.ReadKey();
            Console.WriteLine("...");
            Console.ReadKey();
            Console.WriteLine("--在村子留宿一晚后,第二天一早你就动身前往镇上...");
            Console.ReadKey();
            arriveTown();
        }
        public static void arriveTown()
        {
            Console.Clear();
            Console.WriteLine("--刚到镇上,那告示栏周围聚集了许多人...");
            Console.ReadKey();
            Console.WriteLine("--你凑前一看,贴着几张通缉令.上面正有昨晚的那队长...");
            Console.ReadKey();
            Console.WriteLine("“全都是三合会的...”你心中默念");
            Console.ReadKey();
            Console.WriteLine("--虽说是通缉令,可那中间通缉令上的脸却满是和善...");
            Console.ReadKey();
            Console.WriteLine("--突然想起昨天听闻这镇上的铁匠铺有两手,打的兵器都不赖.便想着去看一看..");
            Console.ReadKey();
            Console.WriteLine("--走了一段,那清脆的打铁声已经能听到了...");
            Console.ReadKey();
            Console.WriteLine("走进铁匠铺...\nLoading...");
            Thread.Sleep(500);
            toTheWeaponStore();

            toTheClothesStore();

            toFinalPlace();
        }
        public static void toTheWeaponStore()
        {
            string jsonFile = @"S:\Unity_West2\RPG\RPG\GameRes.json";
            string packFile = @"S:\Unity_West2\RPG\RPG\Package.json";
            string tempFile = @"S:\Unity_West2\RPG\RPG\temp.json";
            StreamReader file = File.OpenText(jsonFile);
            JsonTextReader reader = new JsonTextReader(file);
            JObject jobject = (JObject)JToken.ReadFrom(reader);

            Console.Clear();
            Console.WriteLine("老板:“这些都是这月新做的件儿~看看呗~”");
            Thread.Sleep(200);
            

            while (true)
            {
                GameRes.LoadJSonWeapon();
                Console.WriteLine("请选择:  (1)买1\t(2)买2\t(3)买3\t(0)离开");
                Console.WriteLine("\t你当前口袋有:"+Player.wallet);
                string choi = Console.ReadLine();
                int intChoi = Convert.ToInt32(choi);

                if(choi == "0")
                {
                    Console.WriteLine("老板:“那下次见啦~”");
                    Console.ReadKey();
                    Console.WriteLine("...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("--你出了铁匠铺..");
                    Console.ReadKey();
                    break;
                }
                if(jobject["weapon"][intChoi-1]["status"].ToString() != "1")
                {
                    jobject["weapon"][intChoi - 1]["status"] = "1";
                    string convertString = jobject.ToString();
                    File.WriteAllText(tempFile, convertString);
                    string buyString = jobject["weapon"][intChoi - 1].ToString();
                    //File.WriteAllText(packFile, buyString);
                    File.AppendAllText(packFile, buyString);
                    string priceString = jobject["weapon"][intChoi - 1]["price"].ToString();
                    int price = Convert.ToInt32(priceString);
                    Player.wallet -= price;
                    file.Close();reader.Close();
                        
                    Console.WriteLine("成功购买");
                    Console.Clear();
                }
                
                
                else
                {
                    Console.WriteLine("没选好哦~再选一次吧");
                }
            }
        }
        public static void toTheClothesStore()
        {
            string jsonFile = @"S:\Unity_West2\RPG\RPG\GameRes.json";
            string packFile = @"S:\Unity_West2\RPG\RPG\Package.json";
            string tempFile = @"S:\Unity_West2\RPG\RPG\temp.json";
            StreamReader file = File.OpenText(jsonFile);
            JsonTextReader reader = new JsonTextReader(file);
            JObject jobject = (JObject)JToken.ReadFrom(reader);

            Console.Clear();
            Console.WriteLine("老板:“这儿都是这周新做的衣裳儿~瞧瞧呗~”");
            Thread.Sleep(200);


            while (true)
            {
                GameRes.LoadJSonClothes();
                Console.WriteLine("请选择:  (1)买1\t(2)买2\t(3)买3\t(0)离开");
                Console.WriteLine("\t你当前口袋有:" + Player.wallet);
                string choi = Console.ReadLine();
                int intChoi = Convert.ToInt32(choi);

                if (choi == "0")
                {
                    Console.WriteLine("老板娘:“那下次再见啦~”");
                    Console.ReadKey();
                    Console.WriteLine("...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("--你出了裁缝店..");
                    Console.ReadKey();
                    break;
                }
                if (jobject["clothes"][intChoi - 1]["status"].ToString() != "1")
                {
                    jobject["clothes"][intChoi - 1]["status"] = "1";
                    string convertString = jobject.ToString();
                    File.WriteAllText(tempFile, convertString);
                    string buyString = jobject["clothes"][intChoi - 1].ToString();
                    //File.WriteAllText(packFile, buyString);
                    File.AppendAllText(packFile, buyString);
                    string priceString = jobject["clothes"][intChoi - 1]["price"].ToString();
                    int price = Convert.ToInt32(priceString);
                    Player.wallet -= price;
                    file.Close(); reader.Close();

                    Console.WriteLine("成功购买");
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("没选好哦~再选一次吧");
                }
            }
        }
        public static void toFinalPlace()
        {

            FinalBattle();
        }
        public static void FinalBattle()
        {

            finalVictory();

            //defeated
            startPage();
        }
        public static void finalVictory()
        {
            //
            Console.WriteLine("\t\t成功退出");//改字
            Thread.Sleep(100);
            Environment.Exit(0);
        }
    }
}
