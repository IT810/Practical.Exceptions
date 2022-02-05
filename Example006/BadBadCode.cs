using System;

namespace Example006
{
    class BadBadCode
    {

        /*One of the students in your class did his homework, but their solution turned out to be a bit messy.You are provided with the code - it has a few mistakes and a lot of room for improvement.Your task is not to fix it, but rather to simply prevent it from crashing.
        Surround all code in the Main method with a try-catch construction.Find all exceptions that the code in Main can throw and catch them in different catch blocks.In each, print the message of the exception to the screen.Ignore OutOfMemoryException.*/

        /*public static void Main()
        {
            // Write your code here

            int[] array = ReadArray();
            var secondBiggest = GetSecondBiggestNumber(array);

            Console.WriteLine(secondBiggest);

            // Write your code here
        }

        private static int[] ReadArray()
        {
            var numberOfElements = ReadInteger();

            try
            {
                var array = new int[numberOfElements];
                for (int i = 0; i < numberOfElements; i++)
                {
                    array[i] = ReadInteger();
                }

                return array;
            }
            catch
            {
                return null;
            }
        }

        private static int GetSecondBiggestNumber(int[] array)
        {
            if (array.Length < 2)
                throw new ArgumentException();

            Array.Sort(array);

            return array[2];
        }

        private static int ReadInteger()
        {
            return int.Parse(Console.ReadLine());
        }*/

        public static void Main()
        {
            try
            {
                int[] array = ReadArray();
                var secondBiggest = GetSecondBiggestNumber(array);

                Console.WriteLine(secondBiggest);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int[] ReadArray()
        {
            var numberOfElements = ReadInteger();

            try
            {
                var array = new int[numberOfElements];
                for (int i = 0; i < numberOfElements; i++)
                {
                    array[i] = ReadInteger();
                }

                return array;
            }
            catch
            {
                return null;
            }
        }

        private static int GetSecondBiggestNumber(int[] array)
        {
            if (array.Length < 2)
                throw new ArgumentException();

            Array.Sort(array);

            return array[2];
        }

        private static int ReadInteger()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
