namespace TestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var res = typeof(string).GetMethods()
                //.Watch(m => "SOURCE: " + m)
                .Where(m => m.Name.StartsWith("S"))
                .Watch(m => "WHERE: " + m.Name)
                .Select(m => m.Name)
                .Watch(m => "SELECT: " + m);

            foreach (var name in res)
            {
                Console.WriteLine(name);
            }
        }
    }
}