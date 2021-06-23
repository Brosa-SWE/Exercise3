using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2
{
    class Dog : Animal
    {
            {
        public string Personality { get; set; }

        protected override void DoSound()
        {
            Console.WriteLine("Voff!");
        }

        protected override string Stats()
        {
            return ($"{base.Stats()}, Personality: {Personality}");
        }
    }
}
