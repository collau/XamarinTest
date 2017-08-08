using System;

namespace Day3Exercise
{
	class D1
	{
		public static void Main(string[] args)
		{
			int i = 88;
			int j = 0;
			//user enters a number
			Console.Write("Please enter a number: ");
			j = Int32.Parse(Console.ReadLine());

			//if its not 88, asks for another number
			while (j != i)
			{
				Console.Write("Please enter a number: ");
				j = Int32.Parse(Console.ReadLine());
			}

			//if its 88, "lucky you..."
			Console.WriteLine("Lucky you...");
		}
	}
}
