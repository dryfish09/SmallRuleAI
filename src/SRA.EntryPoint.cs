using System;

namespace SRA
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            string[] Starts = {
                "Hello! Let's start a new happy day by chatting with me!",
                "How can I help you?",
                "Ready to start?"
            };
            string start = Starts[rand.Next(Starts.Length)];
            Console.WriteLine(start);
            try
            {
                Core.Logic();
            }
            catch (Exception e) 
            {
                Console.WriteLine($"Unexpected error: {e}");
            }
        }
    }
}
