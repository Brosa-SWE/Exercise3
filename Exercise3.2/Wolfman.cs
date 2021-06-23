using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2
{
    class Wolfman : Wolf, IPerson
    {
        public void talk()
        {
            Console.WriteLine("I am what they say I am... I'm a monster.");
        }
    }
}
