using System;

namespace p16
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while (true) {
				Console.WriteLine ("在庫を入力");
				int zaiko = int.Parse (Console.ReadLine ());
				var msg = "正の整数を入力してください";
					if (zaiko == 0) {
					msg = ("在庫がありません");
					}
					if (zaiko <= 3 && zaiko > 0) {
						msg = ("在庫がわずかです");
					} else if(zaiko > 3) {
						msg = ("在庫があります");
					}
					Console.WriteLine (msg);

			}
		}
	}
}