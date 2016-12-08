using System;
namespace ShowMeDateBusiness
{
	public class DateBusiness
	{
		public DateTime returnDate()
		{
			ShowMeDateDataLayer.DateData donga = new ShowMeDateDataLayer.DateData();
			DateTime newDate = donga.returnDate();
			return newDate;
		}
			
	}
}
