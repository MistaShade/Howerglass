using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;
            Console.Write("Enter an odd number for a hourglass: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Please enter an odd number for a better hourglass.");
                return;
            }
            else
            {
                int middle = n / 2 + 1;
                int middlePartWidth = (n - 1) / 2;

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j >= middle - Math.Abs(i - middle) + 1 && j <= middle + Math.Abs(i - middle) + 1)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("_ ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }


    }
}