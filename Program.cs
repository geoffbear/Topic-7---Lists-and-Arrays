using System.Net.Mime;

namespace Topic_7___Lists_and_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int remove, add, occur, occurCount = 0, sum = 0, average = 0;
            List<int> numbers = new List<int>();
            bool menu = true;
            int randomInt = 0;
            int menuSelection;
            Random generator = new Random();
            Console.WriteLine("Welcome to Geoffrey's Legendary Lists :D (Type the numeric option you would like to preform)");
            Console.WriteLine();
            Console.WriteLine("Here is your random list:");

            for (int i = 0; i < 25; i++)
            {
                randomInt = generator.Next(10, 21);
                numbers.Add(randomInt);
                Console.Write(numbers[i] + ", ");
            }
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
                Console.WriteLine("9 - Determine the median value");
                Console.WriteLine("10 - Quit");

                if (int.TryParse(Console.ReadLine().Trim(), out menuSelection))
                {
                    if (menuSelection == 1)
                    {
                        numbers.Sort();
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 1 - Sort your list");
                        Console.WriteLine("Your list has been sorted, here it is: ");
                        Console.WriteLine();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write(numbers[i] + ", ");
                        }
                    }

                    if (menuSelection == 2)
                    {
                        numbers.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 2 - Create a NEW list of random numbers");
                        Console.WriteLine("Here is your new random list");
                        Console.WriteLine();
                        for (int i = 0; i < 25; i++)
                        {
                            randomInt = generator.Next(10, 21);
                            numbers.Add(randomInt);
                            Console.Write(numbers[i] + ", ");
                        }
                    }

                    else if (menuSelection == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 3 - Remove a specified number");
                        Console.WriteLine("Which number would you like to remove?");
                        while (!Int32.TryParse(Console.ReadLine(), out remove))
                            Console.WriteLine("Invalid Numeric Input.  Try again.");

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers.Remove(remove);
                        }

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write(numbers[i] + ", ");
                        }
                    }

                    else if (menuSelection == 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 4 - Add a value to your list");
                        Console.WriteLine("Which value would you like to add?");
                        while (!Int32.TryParse(Console.ReadLine(), out add))
                            Console.WriteLine("Invalid Numeric Input.  Try again.");

                        numbers.Add(add);
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write(numbers[i] + ", ");

                    }

                    else if (menuSelection == 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 5 - Count the number of occurrences of a specified number");
                        Console.WriteLine("Which number would you like to count?");
                        while (!Int32.TryParse(Console.ReadLine(), out occur))
                            Console.WriteLine("Invalid Numeric Input.  Try again.");

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == occur)
                            {
                                occurCount++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("The number " + occur + " appears " + occurCount + " times in your list.");
                        occurCount = 0;
                    }

                    else if (menuSelection == 6)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 6 - Print largest value");
                        int biggestNumber = numbers[0];

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > biggestNumber)
                            {
                                biggestNumber = numbers[i];
                            }
                        }
                        Console.WriteLine("The largest number in your list is " + biggestNumber + ".");
                    }

                    else if (menuSelection == 7)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 7 - Print smallest value");
                        int smallestNumber = numbers[0];

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > smallestNumber)
                            {
                                smallestNumber = numbers[i];
                            }
                        }
                        Console.WriteLine("The largest number in your list is " + smallestNumber + ".");


                    }

                    else if (menuSelection == 8)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 8 - Print the sum and average of the numbers in the list");
                        Console.WriteLine();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum = numbers[i] + sum;
                        }
                        Console.WriteLine("The sum of your list is " + sum + ".");
                        Console.WriteLine("The average of your list is " + (sum / numbers.Count) + ".");
                        sum = 0;
                    }

                    else if (menuSelection == 9)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 9 - Determine the median value");

                        if (numbers.Count % 2 == 1)
                        {
                            numbers.Sort();
                            int median = numbers.Count / 2;
                            Console.WriteLine("Your median is " + numbers[median] + ".");
                        }
                        else if (numbers.Count % 2 == 0)
                        {
                            numbers.Sort();
                            int median = numbers.Count / 2;
                            Console.WriteLine("Your median is " + ((numbers[median] + numbers[median-1]) / 2) + ".");
                        }
                    }

                    else if (menuSelection == 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 10 - Quit");
                        Console.WriteLine("Goodbye!");
                        menu = false;
                    }
                }
            }
        }
    }
}
