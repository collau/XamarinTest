using System;
namespace Day3Exercise
{
	public class D3b
	{
		static void Main()
		{
			Random r = new Random();
			int secret = r.Next(0, 10);
			int numOfGuesses = 1;
			Console.Write("Please guess a number(0-9): ");
			int guess = Int32.Parse(Console.ReadLine());

			while (guess != secret)
			{
				numOfGuesses++;
				//ask user for guess
				Console.Write("Try again: ");
				guess = Int32.Parse(Console.ReadLine());
			}

			Console.WriteLine("Congratulations!");
			Console.WriteLine("You took {0} tries", numOfGuesses);

			if (numOfGuesses <= 2)
			{
				Console.WriteLine("You are a Wizard!");
			}
			else if (numOfGuesses <= 5)
			{
				Console.WriteLine("Good Guess!");
			}
			else
			{
				Console.WriteLine("You are lousy!");
			}
		}
	}
}
