using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {

        static void Main(string[] args)
        {
            //  Part1_CreatePerson();

            Part2_CreatePersonsViaPersonHandler();


        }

        private static void Part2_CreatePersonsViaPersonHandler()
        {
            PersonHandler personHandler = new PersonHandler();

            try
            {

                Person person1 = personHandler.CreatePerson(10, "Kalle", "Kula", 120, 50);
                Console.WriteLine("Person1a: " + person1.ToString());

                personHandler.SetAge(person1, 30);
                personHandler.SetFname(person1, "Nisse-Gurra");
                personHandler.SetLname(person1, "Aktersnurra");
                personHandler.SetHeight(person1, 180);
                personHandler.SetWeight(person1, 80);

                Console.WriteLine("Person1b: " + person1.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        private static void Part1_CreatePerson()
        {
            Person person = new Person();

            try
            {
                person.Age = 0;
                person.Fname = "NisseGurraAkterSnurra";
                person.Lname = "HejSvejsILingonSkogen";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }


        }
    }
}
