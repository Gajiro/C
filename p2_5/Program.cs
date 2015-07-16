using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores["矢吹"] =    2;
            scores["丹下"] =   74;
            scores["力石"] =   80;
            scores["白木"] =  100;
            scores["西　"] =   10;

            foreach (var name in scores.Keys)
            {
                //Console.Write("氏名：{0}　点数：{1,3}", name, scores[name]);

                var msg = "";
                switch (scores[name]/10)
                {
                   case 8 :
                   case 9:
                   case 10:
                        msg = "優";
                        break;
                    case 7:
                        msg = "良";
                        break;
                    case 6:
                        msg = "可";
                        break;
                    default: msg = "不可";
                        break;
                }
                //Console.WriteLine("評価：" + msg);

                Console.WriteLine("氏名：{0}　点数：{1,3}　評価：{2,2}", name, scores[name], msg);

            }

        }
    }
}
