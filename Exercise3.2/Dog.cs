using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2
{
    class Dog : Animal
    {
        public string Personality { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Voff!");
        }

        public override string Stats()
        {
            return ($"{base.Stats()}, Personality: {Personality}");
        }

        public string GetMagicString()
        {
            return "The Magic Dog String from the Dog Class";
        }
    }
}
