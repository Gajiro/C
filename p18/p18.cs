using System;

namespace p18
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var i = 0;
			while (true) {
				Console.WriteLine("こんにちは");
				i++;
				if(i == 5){
					break;
				}
			}
		}
	}
}
