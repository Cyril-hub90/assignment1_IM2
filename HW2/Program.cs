using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int cols = int.Parse(Console.ReadLine());

            
            List<List<double>> matrix = new List<List<double>>();

            double sum = 0;
            int count = 0;


            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("Row " + (i + 1));
                List<double> row = new List<double>();

                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Enter number" + (j + 1) + ": ");
                    double num = double.Parse(Console.ReadLine());
                    row.Add(num);

                    sum += num;
                    count++;
                }

                matrix.Add(row);
            }

            
            Console.WriteLine("\nThe numbers are:");
            foreach (var row in matrix)
            {
                foreach (var num in row)
                {
                    Console.Write(num.ToString("0.0") + " ");
                }
                Console.WriteLine();

            }

            
            double average = sum / count;
            Console.WriteLine($"\nSum: {sum:0.0} ; Average: {average:0.0}");
            Console.ReadKey();
        }
    }
}
