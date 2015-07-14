using System;

namespace p14
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while (true) {
				Console.WriteLine ("Aの値");
				int inputA = int.Parse(Console.ReadLine());
				Console.WriteLine ("Bの値");
				int inputB = int.Parse(Console.ReadLine());
				string msg = string.Format("{0}と{1}は等しい",inputA,inputB);
				if (inputA > inputB) {
					msg = string.Format("{0}は{1}より大きい",inputA,inputB);
				}
				if (inputA < inputB) {
					msg = string.Format("{0}は{1}より小さい",inputA,inputB);
				}
				Console.WriteLine(msg);
			}
		}
	}
}
