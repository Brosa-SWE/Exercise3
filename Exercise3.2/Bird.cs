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

        protected override void DoSound()
        {
            Console.WriteLine("Kvidevitt!");
        }

        protected override string Stats()
        {
            return ($"{base.Stats()}, Migrating: {Migrating}");
        }

    }
}
