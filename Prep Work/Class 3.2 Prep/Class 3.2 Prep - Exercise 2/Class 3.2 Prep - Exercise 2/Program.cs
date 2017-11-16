using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveLetterWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = "watermelon, catepillar, mountain, dress, messy, this, that";

            string[] split = text.Split(',');

            foreach(string word in split)
            {
                if (word.Length == 6)
                {
                Console.WriteLine(word);
                }
            }
            Console.ReadLine();
        }
    }

}
