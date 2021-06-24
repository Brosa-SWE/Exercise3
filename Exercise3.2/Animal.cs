using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2
{
    public abstract class Animal
    {

        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
       

        public abstract void DoSound();

        protected Animal()
        {

        }

        public virtual string Stats()
        {
            return ($"{this.GetType().Name} Name: {Name}, Weight: {Weight}, Age: {Age}");
        }

    }
}
