﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2
{
    class Worm : Animal
    {
            {
        public double Length { get; set; }

        protected override void DoSound()
        {
            Console.WriteLine("_____");
        }

        protected override string Stats()
        {
            return ($"{base.Stats()}, Length: {Length}");
        }
    }
}