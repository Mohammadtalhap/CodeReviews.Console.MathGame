using MathGameGuided;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        var menu = new Menu();

        var date = DateTime.UtcNow;

        var games = new List<string>();

        string name = GetName();

        menu.ShowMenu(name, date);

        static string GetName()
        {
            Console.Write("Enter your Name:");
            var name = Console.ReadLine();
            return name;
        }
    }
}