using System;

namespace Example005
{
    class WhichExceptionToCatch
    {

        /*In the Main method, catch the exception that GetMonthName can throw if the user inputs a non-existent month number, like -1 or 14. Don't catch all exceptions by type Exception - choose the most specific one. You can use this documentation to figure out which exception you need.
        In the catch block, output the exception's message to the screen.*/

        /*static string[] MonthNames = new[]
        {
            "Jannuary",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        public static void Main()
        {
            int monthNumber = 0;
            int.TryParse(Console.ReadLine(), out monthNumber);

            GetMonthName(monthNumber);
        }

        private static string GetMonthName(int monthNumber)
        {
            return MonthNames[monthNumber - 1];
        }*/

        static string[] MonthNames = new[]
        {
            "Jannuary",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        public static void Main()
        {
            try
            {
                int monthNumber = 0;
                int.TryParse(Console.ReadLine(), out monthNumber);

                Console.WriteLine(GetMonthName(monthNumber));
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Out of range !!!");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Not a number format !!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Other errors !!!");
            }
        }

        private static string GetMonthName(int monthNumber)
        {
            return MonthNames[monthNumber - 1];
        }
    }
}
