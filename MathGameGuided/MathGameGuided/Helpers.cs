using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameGuided
{
    internal class Helpers
    {
        static List<string> games = new();
        internal static void PreviousRecords(string str)
        {
            Console.Clear();
            Console.WriteLine(str);
            Console.WriteLine("-------------------------------------------------------------");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Press a key to for the Main Menu.");
            Console.ReadLine();
        }


        internal static void AddtoHistory(int score, string GameType)
        {
            games.Add($"{DateTime.Now} - {GameType} :\t Score = {score}");
        }

    }
}
