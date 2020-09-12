using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
            var people = new List<Person>
            {
                new Person("Amy", "Winehouse"),
                new Person("John", "Crichton"),
                new Person("Ralph", "Kramden"),
                new Person("Artie", "Lange"),
                new Person("Kana", "Rua")
            };

            foreach (var person in people)
            {
                Console.WriteLine($"Hello {person.FirstName} {person.LastName}!");
            }
        }
    }
}