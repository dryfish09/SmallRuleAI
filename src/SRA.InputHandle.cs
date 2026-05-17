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
			ConsoleWriteLine("Sorry, I don'tbnow about that");
		}
	}
}
