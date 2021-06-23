using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Person
    {

        private int age;
        private string fname = "N/A";
        private string lname = "N/A";
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set {

                if (age < 0)
                {
                    throw new ArgumentException("Age must be more than 0");
                }

                age = value; }
        }


        public string Fname
        {
            get { return fname; }
            set { 
                
                if (!Tools.VerifyStringLength(value, 2, 10))
                {
                    throw new ArgumentException($"First Name must be between 2-10 chars. ({value}={value.Length} chars)");
                }
                
                fname = value; }
        }


        public string Lname
        {
            get { return lname; }
            set {

                if (!Tools.VerifyStringLength(value, 3, 15))
                {
                    throw new ArgumentException($"Last Name must be between 3-15 characters. ({value}={value.Length})");
                }
                lname = value; }
        }


        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public override string ToString()
        {
            return $"Name: {fname} {lname}, Age: {age}, Height: {height}, Weight: {weight}";
        }
    }
}
