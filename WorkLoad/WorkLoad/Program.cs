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
        static LongBalk MaKeLength()
        {
            LongBalk longBalk = new LongBalk();
            longBalk.Length = ReadDouble("Введите длину балки");
            return longBalk;
        }
        static Force MakeForce()
        {
            Force force = new Force();
            force.Value = ReadDouble("Введите значение");
            force.Angle = ReadDouble("Введите угол");
            return force;
        }
        static Moment MakeMoment()
        {
            Moment moment = new Moment();
            moment.Value = ReadDouble("Введите значение");
            return moment;
        }

        static void FixedPillar(Pillar pillar)
        {
            pillar.Distance = ReadDouble("Введите рассстояние ");
        }
        static void FloatingPillar(Pillar pillar)
        {
            pillar.Distance = ReadDouble("Введите рассстояние ");
        }
        static void Anchorage(Pillar pillar)
        {
            pillar.Distance = ReadDouble("Введите рассстояние ");
        }



        static void UniformlyDistributed(Loading loading)
        {
            loading.Distance = ReadDouble("Введите значение");
        }
        static void TransverseLoad(Loading loading)
        {
            loading.Distance = ReadDouble("Введите значение");
        }
        static void MomentLoad(Loading loading)
        {
            loading.Distance = ReadDouble("Введите значение");
        }

    }
}
