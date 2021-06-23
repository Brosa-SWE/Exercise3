using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2
{
    class Horse : Animal
    {
        public string Color { get; set; }

        protected override void DoSound()
        {
            Console.WriteLine("Gnägg!");
        }

        protected override string Stats()
        {
            return ($"{base.Stats()}, Color: {Color}");
        }
    }
}
