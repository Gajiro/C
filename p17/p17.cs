using System;

namespace p17
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while (true) {
				Console.WriteLine ("点数を入力");
				var input = (Console.ReadLine ());
                int score;
                if (int.TryParse(input, out score))
                {
                    var msg = "D判定";
                    if (score >= 60)
                    {
                        msg = ("C判定");
                    }
                    if (score >= 70)
                    {
                        msg = ("B判定");
                    }
                    if (score >= 80)
                    {
                        msg = ("A判定");
                    }
                    Console.WriteLine(msg);
                }else{
                    Console.WriteLine("整数を入力してください");
                    
                }

				
			}
		}
	}
}
