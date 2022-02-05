using System;

namespace Example002
{
    class IntParseWithExceptions
    {
        /*Put the whole given code snippet from the Main method into a try block.Add two catch blocks that handle different exceptions and output corresponding errors to the screen:
        If the user inputs a number in a wrong format, write to the console: "Port that you provided is not a number."
        If the user inputs a number that's too big, like 1234567890987654, write to the console: "Port that you provided is too big."*/

        static void Main(string[] args)
        {
            /*var port = int.Parse(Console.ReadLine());
            var message = Console.ReadLine();

            Console.WriteLine($"Sending message {message} to the port {port}");*/

            int port = 0;
            string message = "";

            try
            {
                port = int.Parse(Console.ReadLine());
                message = Console.ReadLine();

                Console.WriteLine($"Sending message {message} to the port {port}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Port that you provided is not a number.");
            }
            catch (OverflowException)
            {
                if(SByte.MaxValue > port)
                {
                    Console.WriteLine("Port that you provided is too big.");
                }
            }
        }
    }
}
