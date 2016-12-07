using System;
namespace HelloWorldBusinessLayer
{
	public class HelloWorldBusiness
	{
		
		public string GetHelloWorld()
		{
			HelloWorldDataLayer.HelloWorldData db = new HelloWorldDataLayer.HelloWorldData();
			String helloWorldText = db.GetHelloWorld();
			return helloWorldText;
		}

	}
}
