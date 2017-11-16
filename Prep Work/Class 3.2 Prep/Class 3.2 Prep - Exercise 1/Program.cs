using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (num[i] % 2 == 0)
                {
                    sum = sum + num[i];
                }
            }
            Console.WriteLine("Sum:" + sum);
            Console.ReadLine();
        }
    }
}
