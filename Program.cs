using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_lab
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Addition");
            Console.WriteLine("\nPlease enter number n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter number m:");
            Console.WriteLine();
            int m = int.Parse(Console.ReadLine());
            int sum = CalculateSum(n, m);
            Console.WriteLine(sum);

            Console.WriteLine("\nDivision");
            Console.WriteLine("\nEnter your number:");
            int number = int.Parse(Console.ReadLine());
            int count = CountDivisionsByTwo(number);
            Console.WriteLine($"\nTotal number of divisions: {count}");

            Console.ReadLine();

        }


        static int CalculateSum(int n, int m)
        {
            if (n == m)
                return n;
            return n + CalculateSum(n + 1, m);
        }

        static int CountDivisionsByTwo(int number)
        {
            if (number % 2 != 0)
                return 0;
            return 1 + CountDivisionsByTwo(number / 2);
        }
    } 
}


