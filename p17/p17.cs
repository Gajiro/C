using System;

namespace p17
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while (true) {
				Console.WriteLine ("点数を入力");
				int score = int.Parse (Console.ReadLine ());
				var msg = "D判定";
				if(score >= 60) {
					msg = ("C判定");
				}
				if (score >= 70) {
					msg = ("B判定");
				}
				if (score >= 80) {
					msg = ("A判定");
				}
				Console.WriteLine (msg);
				
			}
		}
	}
}
