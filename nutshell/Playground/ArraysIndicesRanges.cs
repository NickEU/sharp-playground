using System;

namespace Playground
{
    internal static class ArraysIndicesRanges
    {
        public static void Examples()
        {
            Console.WriteLine(Util.PrettyHeader("Indices and ranges"));
            string[] names = {"First", "Second", "Third", "Fourth", "Fifth"};
            PrintArr(names, nameof(names));

            // indices:

            Console.WriteLine("Getting individual elements using indices:");
            Index last = ^1;
            Console.WriteLine($"Last one -> {names[last]}");
            Console.WriteLine($"Second to last -> {names[^2]}");

            // ranges:
            // in x..y el with idx y is non inclusive!
            var firstFour = names[..4];
            PrintArr(firstFour, nameof(firstFour));

            var lastTwo = names[3..];
            PrintArr(lastTwo, nameof(lastTwo));

            var middle = names[2..3];
            PrintArr(middle, nameof(middle));

            Range r = ^2..; // from second el from the end till last one
            lastTwo = names[r];
            PrintArr(lastTwo, nameof(lastTwo));

            var allElements = names[..];
            PrintArr(allElements, nameof(allElements));
        }

        private static void PrintArr(string[] arr, string arrName)
        {
            Console.WriteLine($"\nArray {arrName} consists of the following elements: ");
            foreach (var el in arr) Console.Write(el + " ");
        }
    }
}
