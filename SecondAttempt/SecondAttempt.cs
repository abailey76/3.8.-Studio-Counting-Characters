using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondAttempt
{
    internal class SecondAttempt
    {
        static void Main(string[] args)
        {
            string myStr = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. " +
                "Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. " +
                "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Dictionary<char, int> characterCounts = new Dictionary<char, int>();

            foreach (char character in myStr)
            {
                if (characterCounts.ContainsKey(character))
                {
                    characterCounts[character]++;
                }
                else
                {
                    characterCounts.Add(character, 1);
                }
            }

            foreach (KeyValuePair<char, int> kvp in characterCounts)
            {
                Console.WriteLine($"key = { kvp.Key} and value = { kvp.Value }");
            }

        }
    }
}
