using System;

namespace Loops
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//loopFunction();
			//helloWorld();
			//helloWorldArg(args[0]);
			read();
		}
	

		/// <summary>
		/// prints out all the odd integers between 1 and 100
		/// </summary>
		public static void loopFunction()
		{
			int x = 0;

			for (int i = 0; i <= 100; i++)
			{

				if (x % 2 != 0)
				{
					System.Console.WriteLine(x);
				}
				x++;

			}
		}


		/// <summary>
		///prints hello world
		/// </summary>
		public static void helloWorld()
		{
			System.Console.WriteLine("Hello World");
		}

		/// <summary>
		///reads in an argument and prints it with "Hello" preceeding
		/// </summary>
		/// <param name="arg1">Arg1.</param>
		public static void helloWorldArg(String arg1)
		{

			System.Console.WriteLine("Hello " + arg1);
		}


		/// <summary>
		/// asks for name, then prints name with "Hello" preceeding
		/// </summary>
		public static void read()
		{
			System.Console.Write("Enter a Name: ");
			var input = Console.ReadLine();

			System.Console.WriteLine("Hello " + input);
		}


	}



}
