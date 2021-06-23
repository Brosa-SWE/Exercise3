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

        protected override void DoSound()
        {
            Console.WriteLine("Auuuuuuh!");
        }

        protected override string Stats()
        {
            return ($"{base.Stats()}, Rank: {Rank}");
        }
    }
}
