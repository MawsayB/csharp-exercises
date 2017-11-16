using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double input;
                double pi = Math.PI;
                double area;

                Console.WriteLine("Enter a radius:");
                input = double.Parse(Console.ReadLine());

                if (input < 0)
                {
                    Console.WriteLine("Try again. Please enter a positive number.");
                    continue;
                }

                else
                {
                    area = pi * input * input;
                    Console.WriteLine("The area of a circle with radius " + input + " is: " + area);
                    Console.ReadLine();
                }
            }
        }
    }
}
