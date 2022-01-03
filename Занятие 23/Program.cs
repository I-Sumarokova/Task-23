using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Занятие_23
{
    class Program
    {
        static int Factorial(int n)
        {
            int F = 1;
            Console.WriteLine("Factorial начал работу");
            for (int i = 1; i <= n; i++)
            {
                F = F*i;
                Thread.Sleep(100);
            }
            return (F);
            Console.WriteLine($"Факториал равен - {F}");
            Console.WriteLine("Factorial окончил работу");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n>0)
            {
                int F = FactorialAsync(n).Result;
                Console.WriteLine($"Факториал числа {n}: {F}");
            }
            else
            {
                Console.WriteLine("Было введено отрицательное число или 0!");
            }

            Console.ReadKey();
        }

        static async Task<int> FactorialAsync(int n)
        {
            Console.WriteLine("FactorialAsync начал работу");
            int result = await Task.Run(() => Factorial(n));
            Console.WriteLine("FactorialAsync окончил работу");
            return result;
        }
    }
}
