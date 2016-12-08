using System;

namespace ShowMeDate
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			ShowMeDateBusiness.DateBusiness newBusinessDate = new ShowMeDateBusiness.DateBusiness();
			DateTime newDate = newBusinessDate.returnDate();
			Console.WriteLine(newDate);

            Console.ReadLine();
		}
	}
}
