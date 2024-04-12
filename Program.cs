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
            numbers.Sort();
            int randomInt = 0;
            Random generator = new Random();
            Console.WriteLine();
            Console.Write("[ ");
            for (int i = 0; i < 25; i++)
            {
                randomInt = generator.Next(10, 21);
                numbers.Add(randomInt);
                Console.Write(numbers[i]+ ", ");
            }
            Console.WriteLine("]");
        }
    }
}