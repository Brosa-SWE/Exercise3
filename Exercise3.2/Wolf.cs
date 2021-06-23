using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2
{
    class Wolf : Animal
    {
        public string Rank { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Auuuuuuh!");
        }

        public override string Stats()
        {
            return ($"{base.Stats()}, Rank: {Rank}");
        }
    }
}
