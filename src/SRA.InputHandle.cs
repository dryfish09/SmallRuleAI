using System;
namespace SRA
{
	class Response
	{
		public static void HandleNull()
		{
			Console.WriteLine("Oops! Please talk anything!");
		}
		public static void Greet()
		{
			Console.WriteLine("Hi there! What's up!");
		}
		public static void HandleElse()
		{
			Console.WriteLine("Sorry, I don't know about that");
		}
	}
}
