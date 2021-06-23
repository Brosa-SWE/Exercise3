using System;
using System.Collections.Generic;

namespace Exercise3._2
{
    class Program
    {

        /*
            13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i
            vilken klass bör vi lägga det?
                S: Bird

            14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
                S: Animal
        */

        static List<Animal> Animals = new List<Animal>();

        static void Main(string[] args)
        {
            CreateAnimals();
            PrintAnimals();

            Console.ReadKey();
        }

        static private void PrintAnimals()
        {
            foreach (Animal animal in Animals)
            {
                Console.WriteLine(animal.Stats()) ;
                animal.DoSound();

            }
        }
        static private void CreateAnimals()
        {
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
            animal6.Age = 3;
            animal6.Name = "Hundis";
            animal6.Weight = 0.6;
            animal6.Personality = "Happy";
            Animals.Add(animal6);
        }
    }
}
