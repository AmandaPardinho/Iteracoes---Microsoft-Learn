using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IteracoesMicrosoft
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
                else if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}