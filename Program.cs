using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool exitCondition = true; // set initial condition for while statement
            string repeat = "I bet you won't guess this by accident"; // set initial condition for previous response
            Console.Write("Greetings human. I am a chat bot please respond: ");
            while (exitCondition)
            {
               string response = Console.ReadLine().ToLower();  // get user response
                // conditional statements to set program's response to user
                if (response == repeat)
                {
                    Console.WriteLine("Bot: I'm sorry but you have already said that");
                    Console.Write("You: ");
                }
                else if (response == "hello")
                {
                    Console.WriteLine("Bot: Hi good to see you");
                    Console.Write("You: ");
                    repeat = response;
                }
                else if (response == "sup")
                {
                    Console.WriteLine("Bot: I am good"); 
                    Console.Write("You: ");
                    repeat = response;
                }
                else if (response == "hello there")
                {
                    Console.WriteLine("Bot: General Kenobi");
                    Console.Write("You: ");
                    repeat = response;
                }
                else if (response == "bye")
                {
                    Console.WriteLine("Bot: Good bye");
                    exitCondition = false;  // set condition to end while statement
                }
                else
                {
                    Console.WriteLine("Bot: I'm sorry I didn't understand that");
                    Console.Write("You: ");
                }
                count++;
            }
        }
    }
}
