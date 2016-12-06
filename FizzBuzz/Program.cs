using System;

namespace FizzBuzz

//Build a fizz buzz program between the numbers 0 and 100 https://en.wikipedia.org/wiki/Fizz_buzz

{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int total = 100;
			int fizz = 3;
			int buzz = 5;

			for (int i = 0; i <= total; i++)
			{
				if (i % fizz == 0 && i % buzz == 0)
				{
					System.Console.WriteLine("Fizz Buzz");
				}
				else if (i % fizz == 0)
				{
					System.Console.WriteLine("Fizz");
				}
				else if (i % buzz == 0)
				{
					System.Console.WriteLine("Buzz");
				}
				System.Console.WriteLine(i);
			}
		}
	}
}
