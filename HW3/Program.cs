using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            
            Dictionary<char, int> frequencies = GetCharacterFrequency(input);

            
            Console.WriteLine("\nCharacter Frequencies:");
            foreach (var kvp in frequencies)
            {
                Console.WriteLine($"{kvp.Key} = {kvp.Value}");
            }

            
            Console.ReadKey();
        }

        
        static Dictionary<char, int> GetCharacterFrequency(string text)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (char.IsLetter(c)) 
                {
                    if (freq.ContainsKey(c))
                        freq[c]++;
                    else
                        freq[c] = 1;
                }
            }

            return freq;
        }
    }
}
