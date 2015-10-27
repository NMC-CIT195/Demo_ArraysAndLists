using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfScores = 5;

            int[] scores = new int[numberOfScores];

            Console.WriteLine("Enter {0} quiz scores.\n", numberOfScores);
            for (int i = 0; i < numberOfScores; i++)
            {
               Console.Write("Enter a score: ");
               scores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe following scores were entered.\n");
            foreach (var score in scores)
            {
                Console.WriteLine("Score: {0}", score);
            }

            Console.WriteLine("\nEnter any key to continue.");
            Console.ReadKey();
        }
    }
}
