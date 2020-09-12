using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var people = new List<Person> { new Person("Amy", "Winehouse"),
                new Person("John", "Crichton"),
                new Person("Ralph", "Kramden"),
                new Person("Artie", "Lange"),
                new Person("Kana", "Rua")
            };

            foreach (Person person in people)
            {
                Console.WriteLine($"Hello {person.FirstName} {person.LastName}!");
            }
        }
    }
}
