using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
//BLA blabla
            double a, x;
            Console.WriteLine("Enter value of parametr a: (it should be number value)");

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0)
                {
                    if (a > 1)
                    {
                        x = (1 - a) / (2 * a);
                    }
                    else
                    {
                        x = (a - 1) / (2 * a);
                    }
                }
                else
                {
                    x = Math.Log(Math.Sqrt(1 + Math.Pow(a, 2)), Math.E);
                }
                Console.WriteLine($"X --> {x}");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}