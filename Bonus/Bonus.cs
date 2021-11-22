using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Bonus
{
    internal class Bonus
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your string: ");
            string myStr = Console.ReadLine().ToLower();

            Dictionary<char, int> characterCounts = new Dictionary<char, int>();
            List<char> letters = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            foreach (char character in myStr)
            {

                if (Regex.IsMatch(character.ToString(), @"[a-z]"))
                {

                    if (characterCounts.ContainsKey(character))
                    {
                        characterCounts[character] ++;
                    }
                    else
                    {
                        characterCounts.Add(character, 1);
                    }


                    /*if (characterCounts.ContainsKey(character))
                    {
                        characterCounts[character]++;
                    }
                    else if (letters.Contains(character))
                    {
                        characterCounts.Add(character, 1);
                    }*/
                }

                
            }
                    foreach (KeyValuePair<char, int> kvp in characterCounts)
                    {
                        Console.WriteLine($"key = { kvp.Key} and value = { kvp.Value }");
                    }
        }
    }
}
//string mystring = File.ReadAllText(@"C:\Users\arb98\source\repos\textfile.txt", Encoding.UTF8)