using System;
using System.Collections.Generic;

namespace Chapter2
{
    class Person : IComparable
    {
        public DateTime Birthday { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Person p = obj as Person;

            if (p == null)
            {
                throw new ArgumentException("The object provided is not a Person.");
            }

            return this.Birthday.CompareTo(p.Birthday);
        }
    }

    public class MyCalendar
    {
        public static void Run()
        {
            List<Person> birthdaysCalendar = new List<Person>
            {
                new Person { Birthday = new DateTime(2015,10,21)},
                new Person { Birthday = new DateTime(2015,10,1)},
                new Person { Birthday = new DateTime(2015,10,13)},
                new Person { Birthday = new DateTime(2015,10,27)},
                new Person { Birthday = new DateTime(2015,10,30)},
            };

            birthdaysCalendar.Sort(); // Calls the CompareTo method
        }
    }
}