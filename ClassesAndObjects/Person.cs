using System;

namespace ClassesAndObjects
{
    public class Person
    {
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;

        }
        // Auto implemented properties
        public DateTime Birthdate { get; private set; }
        // normal Properties
        public int age 
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }

        }
    }
}
