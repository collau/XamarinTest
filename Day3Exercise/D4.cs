using System;
namespace Day3Exercise
{
	public class D4
	{
		static void Main()
		{
			Console.Write("Please input a number: ");
			int n = Int32.Parse(Console.ReadLine());
			Random r = new Random();
			int g = r.Next(1, n);

			while (Math.Abs(g * g - n) < 0.00001)
			{
				g = (g + n / g) / 2;
			}

			Console.WriteLine("output is {0:###}", g);
		}
	}
}
