using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nEnter string: ");
                string input = Console.ReadLine();

                if (input == "*") 
                    break;

                string lowerInput = input.ToLower();
                string reversed = "";

                
                for (int i = lowerInput.Length - 1; i >= 0; i--)
                {
                    reversed += lowerInput[i];
                }

                
                string result = (lowerInput == reversed) ? "Yes" : "No";

             
                Console.WriteLine("\nOriginal String\t\tReversed String\t\tPalindrome?");
                Console.WriteLine("  " + input + "\t\t   " + reversed + "\t\t    " + result);
            }

            Console.WriteLine("\n//End execution");
        }
    }
}
