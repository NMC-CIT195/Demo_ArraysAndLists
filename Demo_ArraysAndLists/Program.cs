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
            UseArrays();
            UseLists();
        }

        static void UseArrays()
        {
            const int numberOfFruit = 3;

            string[] fruits = new string[numberOfFruit];


            Console.WriteLine("Enter {0} fruits.\n", numberOfFruit);
            for (int i = 0; i < numberOfFruit; i++)
            {
                Console.Write("Enter a fruit: ");
                fruits[i] = Console.ReadLine();

            }
            ;
            Array.Sort(fruits);

            Console.WriteLine("\nThe following fruits were entered and sorted.\n");
            foreach (var fruit in fruits)
            {
                Console.WriteLine("Fruit: {0}", fruit);
            }

            Console.WriteLine("\nEnter any key to continue.");
            Console.ReadKey();
        }

        static void UseLists()
        {
            const int numberOfFruits = 3;

            // int[] scores = new int[numberOfScores];
            List<string> fruits = new List<string>();

            Console.WriteLine("Enter {0} fruits.\n", numberOfFruits);
            for (int i = 0; i < numberOfFruits; i++)
            {
                Console.Write("Enter a fruit: ");
                //scores[i] = int.Parse(Console.ReadLine());
                fruits.Add(Console.ReadLine());
            }

            fruits.Sort();

            Console.WriteLine("\nThe following fruits were entered and sorted.\n");
            foreach (var fruit in fruits)
            {
                Console.WriteLine("Fruit: {0}", fruit);
            }

            Console.WriteLine("\nEnter any key to continue.");
            Console.ReadKey();
        }
    }
}
