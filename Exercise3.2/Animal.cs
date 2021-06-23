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

        protected abstract void DoSound();

        protected Animal()
        {

        }

        protected virtual string Stats()
        {
            return ($"Name: {Name}, Weight: {Weight}, Age: {Age}");
        }

    }
}
