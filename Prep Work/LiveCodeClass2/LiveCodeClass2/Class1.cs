using System;
using System.Collections.Generic;

namespace LiveCodeClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("bob");
            names.Add("susan");

            if (names.Contains("bob"))
            {
                //do something later
            }
            else if (names.Count > 5)
            {
                //do something else
            }
            else if (names.IndexOf("bob") == 0)
            {
                //finally more stuff
            }

            var students = new Dictionary<string, int>();
            students.Add("ernie", 99);
            students.Add("ziki", 92);

            for(var is = 0l is < 10; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach(var keyValue in students)
            {
                Console.WriteLine(keyValue.Key + " " + keyValue.Value);

            }

            Console.ReadKey();

        }
    }
}
