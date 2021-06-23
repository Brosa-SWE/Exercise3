using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2
{
    class Bird : Animal
    {
        public bool Migrating { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Kvidevitt!");
        }

        public override string Stats()
        {
            return ($"{base.Stats()}, Migrating: {Migrating}");
        }

    }
}
