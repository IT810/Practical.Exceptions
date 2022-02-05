using System;

namespace Example007
{
    class GuessWhat
    {

        /*You have a guessing game written by a talented(but inexperienced) student who didn't know about exceptions. She used int.Parse but didn't handle situations when the input is invalid.For example, if instead of a number the input was !@#, the program crashes.
        Your task is to add two try-catch constructions: one in the beginning, when the user inputs the secret number that we'll guess, and one to cover each guessed number. If the user's input appears to be invalid, output "Your input is invalid. Try once again!". Keep asking the user to input a number until they input a valid number.Here is an example:
        Input a secret number
        >Hello!
        Your input is invalid.Try once again!
        >100
        Now start guessing
        >What am I supposed to do? !@#
        Your input is invalid.Try once again!
        >99
        Bigger
        >101
        Smaller
        >I'm tired
        Your input is invalid.Try once again!
        >100
        You've guessed! Woohoo!*/

        /*public static void Main()
        {
            Console.WriteLine("Input a secret number");

            // Write your code here

            var secretNumber = int.Parse(Console.ReadLine());

            // Write your code here

            GuessingGame(secretNumber);
        }

        private static void GuessingGame(int secretNumber)
        {
            Console.WriteLine("Now start guessing");
            var guessed = false;
            while (!guessed)
            {
                // Write your code here

                var number = int.Parse(Console.ReadLine());

                // Write your code here

                if (number == secretNumber)
                    guessed = true;
                else if (number > secretNumber)
                    Console.WriteLine("Smaller");
                else
                    Console.WriteLine("Bigger");
            }

            Console.WriteLine("You've guessed! Woohoo!");
        }*/

        public static void Main()
        {
            Console.WriteLine("Input a secret number");

            try
            {
                var secretNumber = int.Parse(Console.ReadLine());
                GuessingGame(secretNumber);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Your input is invalid. Try once again!");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Your input is invalid. Try once again!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Your input is invalid. Try once again!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Your input is invalid. Try once again!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Your input is invalid. Try once again!");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Your input is invalid. Try once again!");
            }
        }

        private static void GuessingGame(int secretNumber)
        {
            Console.WriteLine("Now start guessing");
            var guessed = false;
            while (!guessed)
            {
                // Write your code here

                var number = int.Parse(Console.ReadLine());

                // Write your code here

                if (number == secretNumber)
                    guessed = true;
                else if (number > secretNumber)
                    Console.WriteLine("Smaller");
                else
                    Console.WriteLine("Bigger");
            }

            Console.WriteLine("You've guessed! Woohoo!");
        }


    }
}
