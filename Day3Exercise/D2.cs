﻿using System;
namespace Day3Exercise
{
	public class D2
	{
		static void Main()
		{
			// input a
			Console.Write("Input first integer: ");
			int a = Int32.Parse(Console.ReadLine());
			int a1 = a;

			// input b
			Console.Write("Input second integer: ");
			int b = Int32.Parse(Console.ReadLine());
			int b1 = b;

			// if a does not equals b, larger number - smaller number
			while (a != b)
			{
				if (a > b)
				{
					a = a - b;
				}
				else
				{
					b = b - a;
				}
			}

			Console.WriteLine("HCF is {0}", a);
			int lCm = (a1 * b1 / a);
			Console.WriteLine("LCM is {0}", lCm);

		}
	}
}
