using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "          and of having nothing to do: once or twice she had peeped into the book her sister " +
                "          was reading, but it had no pictures or conversations in it, 'and what is the use of a " +
                "          book,' thought Alice 'without pictures or conversation?";

            string find;
            string lowertext;

            Console.WriteLine("What word do you want to search for in the Alice's Adventures in Wonderland quote?");
            find = Console.ReadLine();

            lowertext = text.ToLower();

            if (lowertext.Contains(find))
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
                
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
        }
    }
}
