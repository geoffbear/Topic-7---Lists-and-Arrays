namespace Topic_7___Lists_and_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int remove;
            int add;
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
                Console.WriteLine("9 - Determine the most frequently occurring value(s)");
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
                        {
                            Console.Write(numbers[i] + ", ");
                        }
                    }

                    else if (menuSelection == 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 5 - Count the number of occurrences of a specified number");
                        Console.WriteLine("Which number would you like to count?");
                        int occur = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine("" + );
                    
                    
                    
                    }

                    else if (menuSelection == 6)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 6 - Print largest value");
                    }

                    else if (menuSelection == 7)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 7 - Print smallest value");
                    }

                    else if (menuSelection == 8)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 8 - Print the sum and average of the numbers in the list");
                    }

                    else if (menuSelection == 9)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have chosen 9 - Determine the most frequently occurring value(s)");
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
