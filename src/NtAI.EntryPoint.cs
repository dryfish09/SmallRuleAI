using System;
using DryFish.ILib;
namespace NtAI
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            string[] Starts = {
                "Hello! Let's start a new happy day by chatting with me! Type 'exit' to exit.",
                "How can I help you? If not, please type 'exit'.",
                "Ready to start? Type 'exit' to exit or not ready."
            };
            string start = Starts[rand.Next(Starts.Length)];
            Console.WriteLine(start);
            try
            {
                Core.Logic();
            }
            catch (Exception e) 
            {
                ILib.ILogError($"Unexpected error detected: {e}");
                ILib.IExit(1);
            }
        }
    }
}
