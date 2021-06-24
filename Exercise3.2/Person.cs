using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2 
{
    class Person : Animal, IPerson
    {
        public override void DoSound()
        {
            throw new NotImplementedException();
        }

        public void Talk()
        {
            Console.WriteLine("Talk is cheap");
        }
    }
}
