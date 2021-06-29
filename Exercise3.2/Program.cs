using System;
using System.Collections.Generic;

namespace Exercise3._2
{
    class Program
    {

        /*
            3.2.13
                F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
                S: Bird

            3.2.14
                F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
                S: Animal

            3.3.9
                F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
                S: Båda är subklasser till Animal

            3.3.10
                F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
                S: Animal

            3.3.13
                F: Förklara vad det är som händer.
                S: Statsen byggs ihop av att metoden Stats med gemensamma stats anropas från base class
                   och sen läggs den unika staten per unik sub class till.

                   DoSound anropas på den sub class vars instans djuret är skapat med trots att vi behandlar
                   djuret som base class Animal, därför blir det olika ljud

            3.3.16
                F: Kommer du åt den?
                S: Inte utan att casta om Animal object till ett Dog object i det fall object.GetType.Name returnerar "Dog",
                   på övriga djurtyper går det inte alls.

            3.3.17
                F: Varför?
                S: Man kan inte använda metoder och properties i en Sub Class från objekt skapade med en högre
                   Sub Class eller Base Class 
        */

        static List<Animal> Animals = new List<Animal>();

        static void Main(string[] args)
        {
            CreateAnimals();

            PrintAnimalTypesAndSounds();

            PrintAnimalStats();

            CreateDogList();

            PrintStatsForSpecificAnimal("Dog");

            Console.WriteLine(" ");
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }

        private static void PrintStatsForSpecificAnimal(string printAnimalType)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Stats of {printAnimalType}s + in Anmial List");
            Console.WriteLine("------------------------------------------------");

            foreach (Animal animal in Animals)
            {
                string objectAnimalType = animal.GetType().Name;

                if (objectAnimalType == printAnimalType)
                {
                    Console.WriteLine(animal.Stats());

                    if (objectAnimalType == "Dog")
                    {
                    Dog dog = (Dog)animal;
                    Console.WriteLine(dog.GetMagicString());
                    }

                }
 
            }
        }

        private static void CreateDogList()
        {
            List<Dog> dogs = new List<Dog>();

            Horse horse = new Horse();

            // Does not work: dogs.Add(horse);


        }

        static private void PrintAnimalStats()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Stats of Animals in Anmial List");
            Console.WriteLine("-------------------------------");

            foreach (Animal animal in Animals)
            {
                Console.WriteLine(animal.Stats());
            }
        }

        static private void PrintAnimalTypesAndSounds()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Animals in Anmial List");
            Console.WriteLine("----------------------");
  
            foreach (Animal animal in Animals)
            {
               Console.WriteLine(animal.GetType().Name);

                if (animal is IPerson)
                {   
                    // IPerson handles both Person and Wolfman
                    IPerson person = (IPerson)animal;
                    person.Talk();
                }
                else
                {
                    animal.DoSound();
                }

                Console.WriteLine(" ");

            }
        }
        static private void CreateAnimals()
        {
            Person person = new Person();
            person.Age = 50;
            person.Name = "NisseGurra Aktersnurra";
            person.Weight = 0;
            Animals.Add(person);

            Wolfman wolfman = new Wolfman();
            wolfman.Age = 20;
            wolfman.Name = "Warewolf";
            wolfman.Weight = 100;
            Animals.Add(wolfman);

            Bird animal1 = new Bird();
            animal1.Age = 2;
            animal1.Name = "Svanis";
            animal1.Weight = 11;
            animal1.Migrating = true;
            Animals.Add(animal1);

            Horse animal2 = new Horse();
            animal2.Age = 4;
            animal2.Name = "Hästis";
            animal2.Weight = 400;
            animal2.Color = "Brown";
            Animals.Add(animal2);

            Wolf animal3 = new Wolf();
            animal3.Age = 8;
            animal3.Name = "Vargis";
            animal3.Weight = 80;
            animal3.Rank = "Alpha";
            Animals.Add(animal3);

            Worm animal4 = new Worm();
            animal4.Age = 1;
            animal4.Name = "Maskis";
            animal4.Weight = 0.01;
            animal4.Length = 10;
            Animals.Add(animal4);

            Hedgehog animal5 = new Hedgehog();
            animal5.Age = 3;
            animal5.Name = "Kottis";
            animal5.Weight = 0.6;
            animal5.NumberOfPins = 890;
            Animals.Add(animal5);

            Dog animal6 = new Dog();
            animal6.Age = 2;
            animal6.Name = "Hundis1";
            animal6.Weight = 30;
            animal6.Personality = "Happy";
            Animals.Add(animal6);

            Dog animal7 = new Dog();
            animal7.Age = 10;
            animal7.Name = "Hundis2";
            animal7.Weight = 40;
            animal7.Personality = "Sleepy";
            Animals.Add(animal7);
        }
    }
}
