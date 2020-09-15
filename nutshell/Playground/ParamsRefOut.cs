using System;

namespace Playground
{
    internal static class ParamsRefOut
    {
        public static void Examples()
        {
            Console.WriteLine(Util.PrettyHeader("Parameters. ref and out"));
            // ref:

            var a = 5;
            var b = 8;
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After swap: a = {a}, b = {b}");

            // out:

            const string fullName = "Freddy Mercury";

            Split(fullName, out var firstName, out var lastName);
            Console.WriteLine($"First: {firstName} Last: {lastName}");

            Split(fullName, out var anotherFirstName, out _);
            Console.WriteLine($"Just the first name: {anotherFirstName}");

        }

        private static void Split(string fullName, out string firstName, out string lastName)
        {
            var names = fullName.Split(" ");
            firstName = names[0];
            lastName = names[1];
        }

        private static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
