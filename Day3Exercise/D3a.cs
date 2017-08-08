using System;
namespace Day3Exercise
{
	public class D3a
	{
		static void Main()
		{
			Random r = new Random();
			int secret = r.Next(0, 10);
			int numOfGuesses = 0;
			bool correctguess = false;

			do
			{
				numOfGuesses++;
				//ask user for guess
				Console.Write("Please guess a number (0-9): ");
				int guess = Int32.Parse(Console.ReadLine());
				if (secret == guess)
				{
					correctguess = true;
				}
			}
			while (correctguess == false);

			Console.WriteLine("Congratulations!");
			Console.WriteLine("You took {0} tries", numOfGuesses);
		}
	}
}
