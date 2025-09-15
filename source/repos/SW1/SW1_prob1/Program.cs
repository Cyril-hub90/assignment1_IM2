using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    class Program
    {
        
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            
            string[] parts = input.Split(' ');

            int count = 1;
            foreach (string part in parts)
            {
                if (int.TryParse(part, out int num))
                {
                    if (IsPrime(num))
                        Console.WriteLine($"{count}.  {num}\tPrime");
                    else
                        Console.WriteLine($"{count}.  {num}\tComposite");
                    count++;
                }
            }

            
            Console.ReadKey();
        }
    }
}
