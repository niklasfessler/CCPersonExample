using System;
using System.Collections.Generic;

namespace PersonMarriagr
{
    public class Person
    {
        String FName;
        public String LName;
        String MaidenName;
        int Age;
        Gender Gender;
        Person marriedTo;
        List<Person> children = new List<Person>();

        public Person(string fName, string lName, int age, Gender gender)
        {
            FName = fName;
            LName = lName;
            Age = age;
            Gender = gender;
            MaidenName = lName;
        }

        public void Marry(Person personToMarry, bool adoptPartnername)
        {
            this.marriedTo = personToMarry;
            personToMarry.marriedTo = this;

            if (adoptPartnername)
            {
                this.MaidenName = LName;
                this.LName = personToMarry.LName;
            }
        }

        public void Divorce(Person divorceFrom)
        {
            divorceFrom.marriedTo = null;
            this.marriedTo = null;

            divorceFrom.LName = divorceFrom.MaidenName;
            this.LName = this.MaidenName;
        }

        public void GetABabyWith(Person babyWith, String fName, Gender gender)
        {
            Person baby = new Person(fName, this.LName, 0, gender);
            this.children.Add(baby);
            babyWith.children.Add(baby);
        }
    }
}
