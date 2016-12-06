using System;

namespace FizzBuzz

//Build a fizz buzz program between the numbers 0 and 100 https://en.wikipedia.org/wiki/Fizz_buzz

{
	class MainClass
	{
		public static void Main(string[] args)
		{
			for (int i = 0; i <= 100; i++)
			{
				if (i == 0)
				{
					System.Console.WriteLine(i);
					continue;
				}
				if (i % 3 == 0 && i % 5 == 0)
				{
					System.Console.WriteLine("Fizz Buzz");
					continue;
				}
				if (i % 3 == 0)
				{
					System.Console.WriteLine("Fizz");
					continue;
				}
				if (i % 5 == 0)
				{
					System.Console.WriteLine("Buzz");
					continue;
				}
				System.Console.WriteLine(i);
			}
		}
	}
}
