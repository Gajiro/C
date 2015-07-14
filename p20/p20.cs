using System;

namespace p20
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            var KANEDA = ("かねだ");
            for (var k = 0; k <= 10; k++){
				Console.WriteLine (k + "：" + KANEDA);
                KANEDA += "あ";
			}
		}
	}
}
