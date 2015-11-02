using System.Collections.Generic;

namespace Chapter4
{
    class ObjectInitialization
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public void Run()
        {
            var people = new List<Person>
            {
                new Person
                {
                    FirstName = "John",
                    LastName = "Doe"
                },
                new Person
                {
                    FirstName = "Jane",
                    LastName = "Doe"
                }
            };
        }
    }
}