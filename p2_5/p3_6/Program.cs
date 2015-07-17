using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<string, int> dic = new Dictionary<string, int>();

            dic["1:"] = 0;
            dic["2:"] = 0;
            dic["3:"] = 0;
            dic["4:"] = 0;
            dic["5:"] = 0;
            dic["6:"] = 0;
            dic["6:"] = 0;
            dic["試行数:"] = 0;
            dic["平均値:"] = 0;

            var num = new List<int>();
            while (true)
            {

                System.Random rand = new System.Random();
                var i1 = rand.Next(1, 7);
                var input = Console.ReadLine();
                Console.WriteLine(i1);

                switch (i1)
                {
                    case 1:
                        dic["1:"]++;
                        break;
                    case 2:
                        dic["2:"]++;
                        break;
                    case 3:
                        dic["3:"]++;
                        break;
                    case 4:
                        dic["4:"]++;
                        break;
                    case 5:
                        dic["5:"]++;
                        break;
                    case 6:
                        dic["6:"]++;
                        break;
                    default:
                        break;
                }

                dic["試行数:"]++;
                dic["平均値:"] += i1;


                var msg = "履歴：";
                num.Add(i1);
                if (input == "h")
                {
                    foreach (var v in num)
                    {
                        msg += " " + v;
                    }
                    Console.WriteLine(msg);

                    foreach (var item in dic.Keys)
                    {
                        Console.Write("{0} {1}回", item, dic[item]);

                    }


                }

            */
                 var num = new List<int>();
                 double[] i1Array = new double[8];


                 while (true)
                 {

                     System.Random rand = new System.Random();
                     var i1 = rand.Next(1, 7);
                     var input = Console.ReadLine();
                     Console.WriteLine(i1);

                     switch (i1)
                     {
                         case 1:
                             i1Array[1]++;
                             break;
                         case 2:
                             i1Array[2]++;
                             break;
                         case 3:
                             i1Array[3]++;
                             break;
                         case 4:
                             i1Array[4]++;
                             break;
                         case 5:
                             i1Array[5]++;
                             break;
                         case 6:
                             i1Array[6]++;
                             break;
                        default:
                             break;
                     }

                     i1Array[0]++;
                     i1Array[7] += i1;


                     var msg = "履歴：";





                     num.Add(i1);
                     if (input == "h")
                     {
                         foreach (var v in num)
                         {
                             msg += " " + v;
                         }
                         Console.WriteLine(msg);
                         Console.WriteLine("出現数　1：{0}回　2:{1}回　3:{2}回　4:{3}回　5:{4}回　6:{5}回", i1Array[1], i1Array[2], i1Array[3], i1Array[4], i1Array[5], i1Array[6]);
                         Console.WriteLine("出現確率　1：{0:F}%　2:{1:F}%　3:{2:F}%　4:{3:F}%　5:{4:F}%　6:{5:F}%", (i1Array[1]/i1Array[0])*100, (i1Array[2] / i1Array[0]) * 100, (i1Array[3] / i1Array[0]) * 100, (i1Array[4] / i1Array[0]) * 100, (i1Array[5] / i1Array[0]) * 100, (i1Array[6] / i1Array[0]) * 100);
                         Console.WriteLine("試行数：" + i1Array[0]);
                         Console.WriteLine("平均値：{0:f}", (i1Array[7]/ i1Array[0]));

                     }
                     
                /*
                 var i1 = 0;
                Console.WriteLine();*/

            }
    }
    }

}
