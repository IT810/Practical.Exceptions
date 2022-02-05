using System;

namespace Example001
{
    class Program
    {

        /*This example can help to understand 'Exceptions' better*/
        /*A 'Try' block can have several corresponding 'Catch' blocks because code can throw exceptions of different types*/

        static void Main(string[] args)
        {
            Console.WriteLine(GetLengthRatio("ABC", null));
            Console.WriteLine(GetLengthRatio(null, "ABC"));
            Console.WriteLine(GetLengthRatio("ABC", ""));
        }

        // not using Exceptions

        // Using Exceptions
        // 1 try - 3 catch
        // This code can throw at least two different exceptions: NullReferenceException and DivideByZeroException.You can write code that handles exceptions in a different way depending on their type.
        public static double GetLengthRatio(string s1, string s2)
        {
            double ratio;

            try
            {
                var s1Length = s1.Length; // Can throw NullReferenceException if s1 is null
                var s2Length = s2.Length; // Can throw NullReferenceException if s2 is null
                ratio = s1Length / s2Length; // Can throw DivideByZeroException if s2 is empty => s2Length = 0
            }
            catch (NullReferenceException ex)  // Handling NullReferenceException
            {
                /*Console.WriteLine($"One of the provided strings is null! Exception: {ex.ToString()}");*/
                Console.WriteLine($"One of the provided strings is null!");
                ratio = 0.0;
            }
            catch (DivideByZeroException ex) // Handling DivideByZeroException
            {
                /*Console.WriteLine($"s2 is empty! Exception: {ex.ToString()}");*/
                Console.WriteLine($"s2 is empty!");
                ratio = double.MaxValue;
            }
            catch (Exception ex) // Handling all other exceptions
            {
                /*Console.WriteLine($"Unknown error. Exception: {ex.ToString()}");*/
                Console.WriteLine($"Unknown error.");
                ratio = 0.0;
            }
            return ratio;
        }

        /*Summary: a 'try' block can have several 'catch' blocks.*/
        /*Now let's come back to the order of catch blocks. When an exception occurs inside the try block, CLR first checks it against the first catch block; if it fits, that catch block is executed. If the first catch block doesn't match, it checks the second catch block, then the third, and so on, ending with the last catch block. This behavior forms a rule that you need to follow when you create a catch blocks chain - go from the most specific exception to the most general. As you see in my example, the most general is Exception (which means "any error"), and less specific are DivideByZeroException and NullReferenceException . Try to always specify the type of exceptions that can occur; don't just throw everything in one can of 'any error'.*/
    }
}
