using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLoad
{
    class Program
    {
        static double ReadDouble(string message)
        {
            double result;
            bool parsed;
            do
            {
                Console.WriteLine(message);
                string d = Console.ReadLine();
                parsed = double.TryParse(d, out result);
            } while (!parsed);
            return result;
        }
        static Force MakeQ()
        {
            Force Q = new Force();
            Q.q1 = ReadDouble("Введите силу распределённой нагрузки Q:");
            Q.L4 = ReadDouble("Введите расстояние от начала отрезка:");
            Q.L5 = ReadDouble("Введите длинну действия нагрузки:");
            return Q;
        }
        static Force MakeF()
        {
            Force F = new Force();
            F.f = ReadDouble("Введите силу постоянной нагрузки F=кН:");
            F.L2 = ReadDouble("Введите расстояние от начала отрезка:");
            return F;
        }       
        static Force MakeForce()
        {
            Force force;
            Console.WriteLine("Введите тип нагрузки F/Q/M");
            string size = Console.ReadLine();
            switch (size)
            {
                case "F":
                    force = MakeF();
                    break;
                case "Q":
                    force = MakeQ();
                    break;
                default:
                    force = null;
                    Console.WriteLine("Вы ввели неверные данные");
                    break;
            }
            return force;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тип левого защемления: П-подвижная опора; Н-неподвижная опора");
            string Left = Console.ReadLine();
            double L = ReadDouble("Введите расстояние от начала отрезка до опоры:");

            Console.WriteLine("Введите тип правого защемления: П-подвижная опора; Н-неподвижная опора");
            string Right = Console.ReadLine();
            double L1 = ReadDouble("Введите расстояние от начала отрезка до опоры:");

            Console.WriteLine("Введите количество действующих сил:");
            string x = Console.ReadLine();
            int X = Convert.ToInt32(x);

            Force[] forces = new Force[X];
            for (int i = 0; i < forces.Length; i++)
            {
                Force force = null;
                do
                {
                 force = MakeForce();
                } while (force == null);
                forces[i] = force;
            }
             Console.ReadKey();
        }
    }
}
