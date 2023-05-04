namespace TestProject
{
    public static class EnumerableDebugger
    {
        public static IEnumerable<T> Watch<T>(this IEnumerable<T> input)
        {
            return Watch(input, item => item
            != null ? item.ToString() : "(null)");
        }

        public static IEnumerable<T> Watch<T>(this IEnumerable<T> input, Func<T, string> toString)
        {
            foreach (var item in input)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(toString(item));
                Console.ResetColor();
                yield return item;
            }
        }
    }
}