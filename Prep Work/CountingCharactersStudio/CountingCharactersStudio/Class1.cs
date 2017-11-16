using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CountingCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                            Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. 
                            Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, 
                            non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. 
                            Donec nec velit non ligula efficitur luctus.";

            //Console.WriteLine("Please enter your text.")

            string textimported = File.ReadAllText("myText.txt");

            string lowertext;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            lowertext = text.ToLower();

            foreach (char c in lowertext)
            {
                if(!Char.IsLetter(c))
                {
                    continue; 
                }

                if(charCount.ContainsKey(c))
                {
                    // pull it out of the dictionary
                    var value = charCount[c];
                    // add one to it
                    value = value + 1;
                    // save it back to the dictionary  
                    charCount[c] = value; 
                }
                else
                {
                    charCount.Add(c, 1);
                }
            }

            foreach (var keyValuePair in charCount)
            {
                char c = keyValuePair.Key;
                int value = keyValuePair.Value;

                // print it out

                Console.WriteLine(keyValuePair.Key + ": " + keyValuePair.Value);
                
            }
            Console.ReadKey();
        }
    }
}