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
		public static void HowRYou()
		{
			Console.WriteLine("Fine, thank you!");
		}
		public static void SayBye()
		{
			Console.WriteLine("Bye! See you again!");
		}
		public static void HandleElse()
		{
			Console.WriteLine("Sorry, I don't know about that");
		}
	}
}
