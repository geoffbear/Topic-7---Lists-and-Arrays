using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Topic_7___Lists_and_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool menu = true;
            int randomInt = 0;
            int menuSelection;
            Random generator = new Random();
            Console.WriteLine("Welcome to Geoffrey's Legendary Lists :D (Type the numeric option you would like to preform)");
            Console.WriteLine();
            Console.WriteLine("Here is your random list:");

            Console.Write("[ ");
            for (int i = 0; i < 25; i++)
            {
                randomInt = generator.Next(10, 21);
                numbers.Add(randomInt);
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine("]");
            while (menu)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1 - Sort your list");
                Console.WriteLine("2 - Create a NEW list of random numbers");
                Console.WriteLine("3 - Remove a specified number");
                Console.WriteLine("4 - Add a value to your list");
                Console.WriteLine("5 - Count the number of occurrences of a specified number");
                Console.WriteLine("6 - Print largest value");
                Console.WriteLine("7 - Print smallest value");
                Console.WriteLine("8 - Print the sum and average of the numbers in the list");
                Console.WriteLine("9 - Determine the most frequently occurring value(s)");
                Console.WriteLine("10 - Quit");

                if (int.TryParse(Console.ReadLine().Trim(), out menuSelection))
                {
                    if (menuSelection == 1)
                    {
                        numbers.Sort();
                        Console.WriteLine();
                    }

                    if (menuSelection == 2)
                    {

                    }

                    if (menuSelection == 3)
                    {

                    }

                    if (menuSelection == 4)
                    {

                    }

                    if (menuSelection == 5)
                    {

                    }

                    if (menuSelection == 6)
                    {

                    }

                    if (menuSelection == 7)
                    {

                    }

                    if (menuSelection == 8)
                    {

                    }

                    if (menuSelection == 9)
                    {

                    }
                }
            }
        }
    }
}