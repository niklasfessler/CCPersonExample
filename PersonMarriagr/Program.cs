using System;

namespace PersonMarriagr
{
    class Program
    {
        static void Main(string[] args)
        {
            Person heidi = new Person("Heidi", "Hase", 24, Gender.FEMALE);
            Person harald = new Person("Harald", "Musetmann", 25, Gender.MALE);

            harald.Marry(heidi, true);
            harald.Divorce(heidi);

            harald.GetABabyWith(heidi, "Lisa", Gender.DIVERSE);
        }
    }
}
