using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тип левого защемления: П-подвижная опора; Н-неподвижная опора");

            string Left = Console.ReadLine();
            Console.WriteLine("Введите силу постоянной нагрузки в кН");
            string F = Console.ReadLine();
            int f = Convert.ToInt32(F);

            Console.WriteLine("Введите силу момента в кН");
            string M = Console.ReadLine();
            int m = Convert.ToInt32(M);

            Console.WriteLine("Введите данные распределённой нагрузки:");
            string Q1 = Console.ReadLine();
            int q1 = Convert.ToInt32(Q1);

            string X1 = Console.ReadLine();
            int x1 = Convert.ToInt32(X1);

            string Q2 = Console.ReadLine();
            int q2 = Convert.ToInt32(Q2);
                        
            string X2 = Console.ReadLine();
            int x2 = Convert.ToInt32(X2);

            Console.WriteLine("Введите тип правого защемления: П-подвижная опора; Н-неподвижная опора");
            string Right = Console.ReadLine();

            Console.ReadKey();
        }

    }
}
