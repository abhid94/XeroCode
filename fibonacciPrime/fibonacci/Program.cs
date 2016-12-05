using System;

namespace fibonacci
{
	class MainClass
	{
		/// <summary>
		/// Write a console app with a loop to display the fibonccci sequence between 0 and 100 is PRIME
		/// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34,
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args)
		{

			int fib1 = 0;
			int fib2 = 1;
			int total = 0;
			for (int i = 0; total < 100; i++)
			{

				checkPrime(total);

				total = fib1 + fib2;
				fib1 = fib2;
				fib2 = total;
				i++;
			}
		}

		public static bool checkPrime(int num)
		{

			for (int i = 2; i < Math.Sqrt(num); i++)
			{
				if (num % i == 0)
				{
					return false;
				}
	
			}
			if (num != 0 && num != 1)
			{
				System.Console.WriteLine(num);
			}
			return true;
		}

	}
}
