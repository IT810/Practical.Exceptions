using System;

namespace Example004
{
    class Program
    {

        //When an exception occurs, it looks for the closest try - catch block to the line where the exception occurred.If there is no try - catch nearby, it 'jumps out' from the function and looks for the try - catch in the function that called the current one, and so on, until it gets to the highest in the hierarchy function (Main ), and if that one doesn't have a try-catch for this exception, your program will crash

        /*public static void Main()
        {
            SomeMethod();
        }

        public static void SomeMethod() // Throws an exception that crashes the
                                        // application
        {
            throw new ArgumentException("Argument is wrong!");
        }*/

        static void Main(string[] args)
        {
            try
            {
                SomeMethod();
            }
            catch (Exception ex) // The exception is handled here
            {
                Console.WriteLine(ex);
            }
        }

        public static void SomeMethod() // The exception "jumps out" from here
        {
            throw new ArgumentException("Argument is wrong!");
        }


    }
}
