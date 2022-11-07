using System.Linq;
using System.Collections.Generic;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> movieNames = new List<string>() { "Shrek", "Field of Dreams", "Maverick", "Mean Girls" };

            movieNames.OrderBy(x => x.Length).ToList().ForEach(Console.WriteLine);

          

        }
    }
}
