using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("0～6の数字を入力してください。対応した曜日を表示します。");
                    var input = Console.ReadLine();
                    int inputInt = int.Parse(input);
                    var msg = "";
                    switch (inputInt)
                    {
                        case 0:
                            msg = "日曜日";
                            break;
                        case 1:
                            msg = "月曜日";
                            break;
                        case 2:
                            msg = "火曜日";
                            break;
                        case 3:
                            msg = "水曜日";
                            break;
                        case 4:
                            msg = "木曜日";
                            break;
                        case 5:
                            msg = "金曜日";
                            break;
                        case 6:
                            msg = "土曜日";
                            break;
                        default:
                            msg = "0～6の範囲で入力してください";
                            break;
                    }
                    Console.WriteLine(msg);
                }
                catch
                {
                    Console.WriteLine("数字を入力してください");
                }

             }
         }
    }
}
