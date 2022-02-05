using System;

namespace Example003
{
    class GettingAccessWitchCatch
    {

        /*This code is protecting the server's secret data. It's impossible to change it, but there is a way to add one catch instruction to get access.
        Without changing any code that's already written, add one more catch block to make the code output "Access granted" when the user inputs a very long number as a numeric password. For example:
        Enter login
        >login
        Enter numeric password
        >1234567890987654321
        Access granted*/

        /*public static string Login { get; private set; }
        public static int NumericPassword { get; private set; }

        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter login");
                var login = Console.ReadLine();

                Console.WriteLine("Enter numeric password");
                var numericPassword = int.Parse(Console.ReadLine());

                if (login == Login && numericPassword == NumericPassword)
                {
                    Console.WriteLine("Access granted");
                }
                else
                {
                    Console.WriteLine("Access denied");
                }
            }
            // Write your code here
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong, restart the application and try again.");
            }
        }*/

        public static string Login { get; private set; }
        public static int NumericPassword { get; private set; }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter login");
                var login = Console.ReadLine();

                Console.WriteLine("Enter numeric password");
                var numericPassword = int.Parse(Console.ReadLine());

                if (login == Login && numericPassword == NumericPassword)
                {
                    Console.WriteLine("Access granted");
                }
                else
                {
                    Console.WriteLine("Access denied");
                }
            }
            // Write your code here
            catch (OverflowException ex)
            {
                Console.WriteLine("Access granted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong, restart the application and try again.");
            }
        }

    }
}

