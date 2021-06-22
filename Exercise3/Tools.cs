using System;
using System.Collections.Generic;

namespace Exercise3
{
    public static class Tools
    {
        // Shows prompt
        internal static string GetInputString(string prompt)
        {
            bool success = false;
            string answer;

            //***** Dimitris Björlingh *****
            //Loopa tills användaren har skrivit in något
            //Än så länge ingen annan validering.
            do
            {
                Console.Write(prompt + " ");
                answer = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine("Du måste skriva in något.");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;

        }

        internal static string GetInputString(string prompt, int minLength, int maxLength)
        {
            string input;
            bool success = false;

            do
            {
                input = GetInputString(prompt);

                if (VerifyStringLength(input, minLength, maxLength))
                {
                    Console.WriteLine($"Du måste ange mellan {minLength}-{maxLength} antal tecken.");
                }
                else
                {
                    success = true;
                }
            } while (!success);

            return input;

        }

        internal static bool VerifyStringLength(string input, int minLength, int maxLength)
        {
            if (input.Length < minLength || input.Length > maxLength)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal static int GetInputInt(string prompt)
        {
            bool success = false;
            int answer;

            do
            {
                string input = GetInputString(prompt);
                success = int.TryParse(input, out answer) && answer > 0;

                if (!success)
                {
                    Console.WriteLine("Du måste ange en siffra.");
                }
 

            } while (!success);

            return answer;

        }

        internal static string[] GetWords(string Prompt, int NumberOfWords)
        {
            string[] SplitInput;
            bool success = false;

            do
            {
                var answer = GetInputString(Prompt);

                SplitInput = answer.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (SplitInput.Length < NumberOfWords)
                {
                    Console.WriteLine("Du matade inte in " + NumberOfWords + " ord.");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return SplitInput;
        }

        internal static void WriteStringListToConsole(List<string> ListToWrite)
        {
            Console.WriteLine(string.Join("\u000A", ListToWrite));
        }
    }
}