using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class PersonHandler
    {

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            try
            {
                Person person = new Person();
                person.Age = age;
                person.Fname = fname;
                person.Lname = lname;
                person.Height = height;
                person.Weight = weight;

                return person;
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
 
        }

        public void SetAge(Person pers, int age)
        {
            if (age < 0) {throw new ArgumentException("Age cannot be less than 0.");}

            pers.Age = age;
        }

        public void SetFname(Person pers, string fname)
        {
            if (fname.Length < 2 || fname.Length < 10) { throw new ArgumentException("First Name must be between 2-10 chars."); }
            pers.Fname = fname;
        }

        public void SetLname(Person pers, string lname)
        {
            if (lname.Length < 3 || lname.Length < 15) { throw new ArgumentException("Last Name must be between 3-15 chars."); }

            pers.Lname = lname;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

    }
}
