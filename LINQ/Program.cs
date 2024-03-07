using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> countrySingers = new List<string>() { "Tim McGraw", "Dolly Parton", "George Strait", "Tom Jones",
                "Alan Jackson", "Garth Brooks", "Loretta Lynn", "Tammy Wynette", "Carrie Underwood", "Faith Hill", "Charlie Rich",
                "Brad Paisley"};
            Console.WriteLine("List of Unorderd Country Singers");
            countrySingers.ForEach(singer => { Console.WriteLine(singer); });
            Console.WriteLine("\nList of Ordered Country Singers, Length of Name, Alphabetically by LastName");
            countrySingers.OrderBy(singer => singer.Length).ThenBy(singer => singer.Substring(singer.LastIndexOf(' '),(singer.Length - singer.LastIndexOf(' ')))).ToList().ForEach(singer => Console.WriteLine(singer));
           //Console.WriteLine("Hello, World!");
        }
    }
}
