using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 2, 3, 5, 8 };

            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
