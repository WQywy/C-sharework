using System;

namespace MulFrom_Keyboard
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b;
			Console.WriteLine("Please input integer a:");
			a = Convert.ToInt32(Console.ReadLine());      //get a
			Console.WriteLine("Please input integer b:");
			b = Console.Read();                           //get b

			Console.WriteLine("Multiply:{0}*{1}={2}", a, b, a * b);//get result

			Console.WriteLine("Enter any word and the process will exit.");
			System.Console.ReadKey();                              //control exit
		}
	}
}
