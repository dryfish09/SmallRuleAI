using System;
namespace SRA
{
	class Core
	{
		public static void Logic()
		{
			bool run = true;
			while(run)
			{
				Console.Write("You: ");
				string input = Console.ReadLine()?.ToLower().Trim() ?? "";
				Console.Write(" AI: ");
				if(string.IsNullOrWhiteSpace(input))
				{
					Response.HandleNull();
				}
				else if(input.Contains("hi") || input.Contains("hello"))
				{
					Response.Greet();
				}
				else if(input == "exit")
				{
					run = false;
				}
				else
				{
					Response.HandleElse();
				}
			}
		}
	}
}
