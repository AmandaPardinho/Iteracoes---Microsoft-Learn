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
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for(int i = 0;i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7) break;
            }
            Console.WriteLine();

            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();

            //string[] names2 = { "Alex", "Eddie", "David", "Michael" };
            //foreach (string name in names2)
            //{
            //    if (name == "David") 
            //    {
            //        name = "Sammy";
            //    }
            //}
            //não é possível fazer esse foreach

            string[] names2 = { "Alex", "Eddie", "David", "Michael" };
            for (int i = 0; i < names2.Length; i++)
                if (names2[i] == "David") names2[i] = "Sammy";
            
            foreach(var name in names2) Console.WriteLine(name);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
