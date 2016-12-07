using System;

namespace HelloWorld
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			HelloWorldBusinessLayer.HelloWorldBusiness buisnessHelloWorld = new HelloWorldBusinessLayer.HelloWorldBusiness();
			string helloWorldText = buisnessHelloWorld.GetHelloWorld();
			Console.WriteLine(helloWorldText);
		}
	}
}
