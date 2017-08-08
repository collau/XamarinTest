using System;
namespace Day3Exercise
{
	public class DoWhileEg
	{
		public static void Main()
		{
			string a;
			Console.WriteLine("Loop starts...");
			do
			{
				Console.Write("Type a name: ");
				a = Console.ReadLine();
				Console.WriteLine("You wrote: " + a);
			}
			while (a != "Quit!");
			Console.WriteLine("Loop Over");
		}
	}
}
