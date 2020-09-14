using System;

namespace Playground
{
    internal static class Strings
    {
        public static void Examples()
        {
            const string firstName = "Joe";
            const string lastName = "Danger";
            var fullName = $"{firstName} {lastName}"; // $ -> string interpolation
            Console.WriteLine(fullName);

            // @ -> verbatim string literals (without escape chars)
            const string path = @"C:\math\discrete.pdf";
            Console.WriteLine(path);

            const int lines = 2;
            // interpolated strings must complete on a single line, unless you specify the
            // verbatim string operator:
            var multiLine = $@"This {{spans}} {
                lines} lines"; // verbatim multi-line interpolated string
            Console.WriteLine(multiLine);
        }
    }
}
