using System;

namespace p15
{
	class MainClass
	{
		public static void Main (string[] args)
		{
				while (true) {
				Console.WriteLine ("在庫を入力");
				int zaiko = int.Parse(Console.ReadLine());
				var msg = "在庫がありません";
				if(zaiko == 0){
					Console.WriteLine(msg);
					continue;
				}else if (zaiko <= 3) {
					msg = ("在庫がわずかです");
				}else{
					msg = ("在庫があります");
				}
				Console.WriteLine(msg);

				/*
				switch(zaiko){
				case 0:
					break;
				case 1:
					msg = ("在庫がわずかです");
					break;
				case 2:
					msg = ("在庫がわずかです");
					break;
				case 3:
					msg = ("在庫がわずかです");
					break;
				*/
				}

		}
	}
}