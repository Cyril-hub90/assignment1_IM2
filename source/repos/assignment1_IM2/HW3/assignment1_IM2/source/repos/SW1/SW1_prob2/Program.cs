using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1_prob2
{
    class Program
    {
        const double PesoRate = 57.17;   
        const double YenRate = 146.67;  

       
        static (double peso, double yen) ConvertCurrency(double dollar)
        {
            double peso = dollar * PesoRate;
            double yen = dollar * YenRate;
            return (peso, yen);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter currency in ($): ");
            string input = Console.ReadLine();

            // Allow commas in the input (e.g., 59,200,500)
            if (double.TryParse(input.Replace(",", ""), out double dollar))
            {
                var (peso, yen) = ConvertCurrency(dollar);

                Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen (¥)");
                Console.WriteLine($"{dollar:N0}\t{peso:N2}\t{yen:N2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.ReadKey();
        }
    }
}
