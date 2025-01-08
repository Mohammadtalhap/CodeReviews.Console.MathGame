using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameGuided
{
    internal class GameEngine
    {

        Random random = new Random();

        internal void DivitionGame(string str)
        {
            int firstnum, secondnum, score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(str);
                secondnum = random.Next(1, 10);
                firstnum = random.Next(1, 30) * secondnum;

                Console.Write($"{firstnum} / {secondnum} = ");
                var result = Console.ReadLine();

                if (int.Parse(result) == (firstnum / secondnum))
                {
                    Console.WriteLine("Your Answer was Correct!\nPress a Key for the Main Menu.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your Answer was Incorrect!\nPress a Key for the Main Menu.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"GAME OVER.Your final answer is {score}.");
            Helpers.AddtoHistory(score, "Division");
            Console.ReadLine();
        }

        internal void MultiplicationGame(string str)
        {
            int firstnum, secondnum, score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(str);
                firstnum = random.Next(5, 30);
                secondnum = random.Next(1, 10);

                Console.Write($"{firstnum} * {secondnum} = ");
                var result = Console.ReadLine();

                if (int.Parse(result) == (firstnum * secondnum))
                {
                    Console.WriteLine("Your Answer was Correct!\nPress a Key for the Main Menu.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your Answer was Incorrect!\nPress a Key for the Main Menu.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"GAME OVER.Your final answer is {score}.");
            Helpers.AddtoHistory(score, "Multiplication");
            Console.ReadLine();
        }

        internal void SubtractionGame(string str)
        {
            int firstnum, secondnum, score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(str);
                firstnum = random.Next(30, 90);
                secondnum = random.Next(1, 30);

                Console.Write($"{firstnum} - {secondnum} = ");
                var result = Console.ReadLine();

                if (int.Parse(result) == (firstnum - secondnum))
                {
                    Console.WriteLine("Your Answer was Correct!\nPress a Key for the Main Menu.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your Answer was Incorrect!\nPress a Key for the Main Menu.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"GAME OVER.Your final answer is {score}.");
            Helpers.AddtoHistory(score, "Subtraction");
            Console.ReadLine();

        }

        internal void AdditionGame(string str)
        {
            int firstnum, secondnum, score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(str);
                firstnum = random.Next(1, 9);
                secondnum = random.Next(1, 9);

                Console.Write($"{firstnum} + {secondnum} = ");
                var result = Console.ReadLine();

                if (int.Parse(result) == (firstnum + secondnum))
                {
                    Console.WriteLine("Your Answer was Correct!\nPress a Key for the Main Menu.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your Answer was Incorrect!\nPress a Key for the Main Menu.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"GAME OVER.Your final answer is {score}.");
            Helpers.AddtoHistory(score, "Addition");
            Console.ReadLine();
        }
    }
}
