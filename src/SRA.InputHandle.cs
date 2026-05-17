using System;
namespace SRA
{
	class Response
	{
		static void HandleNull()
		{
			Console.WriteLine("Oops! Please talk anything!");
		}
		static void Greet()
		{
			Console.WriteLine("Hi there! What's up!");
		}
		static void ElseHandle()
		{
			ConsoleWriteLine("Sorry, I don'tbnow about that");
		}
	}
}
