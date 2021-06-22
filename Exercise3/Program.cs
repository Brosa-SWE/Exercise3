using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person();

            List<string> inputValidations = new List<string>();

            try
            {
                person.Age = 0;
            }
            catch (ArgumentException ex)
            {
                inputValidations.Add(ex.Message);
            }

            try
            {
                person.Fname = "NisseGurraAkterSnurra";
            }
            catch (ArgumentException ex)
            {
                inputValidations.Add(ex.Message);
            }

            try
            {
                person.Lname = "HejSvejsILingonSkogen";
            }
            catch (ArgumentException ex)
            {
                inputValidations.Add(ex.Message);
            }

            // Output
            if (inputValidations.Count == 0)
            {
            Console.WriteLine(person.ToString());
            }
            else
            {
                Tools.WriteStringListToConsole(inputValidations);
            }

            Console.ReadKey();

        }
    }
}
