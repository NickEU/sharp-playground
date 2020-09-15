namespace Playground
{
    internal static class Util
    {
        private static readonly string DecorHyphens = new string('-', 30);

        public static string PrettyHeader(string sectionName)
        {
            return $"\n\n{Util.DecorHyphens} {sectionName} {Util.DecorHyphens}\n";
        }
    }
}
