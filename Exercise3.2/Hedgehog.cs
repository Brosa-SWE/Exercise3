using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2
{
    class Hedgehog : Animal
    {
        public int NumberOfPins { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Grunt!");
        }

        public override string Stats()
        {
            return ($"{base.Stats()}, No of pins: {NumberOfPins}");
        }

    }
}
