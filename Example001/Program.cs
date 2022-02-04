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
    }
}
