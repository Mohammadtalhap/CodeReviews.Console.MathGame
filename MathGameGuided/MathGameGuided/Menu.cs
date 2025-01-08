using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameGuided
{
    internal class Menu
    {
        GameEngine engine = new();
         internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Hello {name}! Its {date.DayOfWeek}.This is your Math Game.");
            bool GameOn = true;


            do
            {
                Console.Clear();
                Console.WriteLine(" Which game would you like to play today:\n");
                Console.WriteLine("P - Previous Games\nA - Addition\nS - Subtraction\nM - Multiplication\nD - Division\nQ - Quit the Program");
                Console.WriteLine("------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "p":
                        Helpers.PreviousRecords("Previous Records:");
                        break;
                    case "a":
                        engine.AdditionGame("Addition Game:");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction Game:");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication Game:");
                        break;
                    case "d":
                        engine.DivitionGame("Division Game:");
                        break;
                    case "q":
                        Console.WriteLine("Game Ended");
                        GameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.\nPress a key for the Main Menu.");
                        Console.ReadLine();
                        break;
                }
            } while (GameOn);

            
        }

    }
}
